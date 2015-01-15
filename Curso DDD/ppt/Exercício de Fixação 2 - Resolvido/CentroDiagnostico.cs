using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;

namespace MBCorpHealth
{
    public class CentroDiagnostico
    {
        public CentroDiagnostico(string cnpj, string nome)
        {
            CNPJ = cnpj;
            Nome = nome;
        }

        public string CNPJ { get; private set; }
        public String Nome { get; private set; }


        private void ValidarDadosCentroDiagnostico()
        {
            if (String.IsNullOrEmpty(CNPJ)) throw new ArgumentNullException("É necessário informar o cpf!");
            if (String.IsNullOrEmpty(Nome)) throw new ArgumentNullException("É necessário informar o Nome!");

        }
    }

    public class Agenda
    {
        public Agenda(CentroDiagnostico centroDiagnostico, DateTime data, TipoExame tipoExame)
        {
            CentroDiagnostico = centroDiagnostico;
            Data = data;
            TipoExame = tipoExame;
        }

        public CentroDiagnostico CentroDiagnostico { get; private set; }        
        public DateTime Data { get; private set; }
        public TipoExame TipoExame { get; private set; }
    }

    public class ServicoDeReservaDeDataParaExames
    {
        public List<Agenda> ConsultarDatasDisponiveis(TipoExame tipoExame)
        {
            List<Agenda> agendas = new List<Agenda>();
            
            agendas.Add(new Agenda(new CentroDiagnostico("123","Unidade Norte"),DateTime.Today,tipoExame ));
            agendas.Add(new Agenda(new CentroDiagnostico("123", "Unidade Leste"), DateTime.Today, tipoExame));

            return agendas;
        }

        public void ReservarDataParaOExame(Agenda agenda, Paciente paciente)
        {
        }
    }
}
