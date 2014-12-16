using System;
using System.Collections.Generic;
using System.Linq;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;

namespace MBCorpHealth.Aplicacao.Servico
{
    public class ServicoDeConsultaDeDadosDePaciente:IServicoDeConsultaDeDadosDePaciente
    {
        private readonly IRepositorioAgendamento _repositorioAgendamento;

        public ServicoDeConsultaDeDadosDePaciente(IRepositorioAgendamento repositorioAgendamento)
        {
            _repositorioAgendamento = repositorioAgendamento;
        }

        public IList<ResultadoViewModel> RetornarResultadosDeExame(string CPF)
        {
            var retorno = _repositorioAgendamento.RetornarResultadosPorCPFDoPaciente(CPF);

            return retorno.Select(resultado => new ResultadoViewModel {Data = resultado.DataResultado, Descricao = resultado.Descricao, MedicoResponsavel = resultado.MedicoResponsavel}).ToList();
        }
    }

    public class ResultadoViewModel
    {
        public DateTime Data { get;  set; }
        public string Descricao { get; set; }
        public Medico MedicoResponsavel { get; set; }
    }

}