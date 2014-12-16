using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Testing.Values;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio.Fakes;
using MBCorpHealth.View.ViewModel;

namespace MBCorpHealth.Aplicacao.Servico
{
    public class ServicoDePaciente
    {
        private readonly IRepositorioPaciente _repositorioPaciente;


        public ServicoDePaciente(IRepositorioPaciente repositorioPaciente)
        {
            _repositorioPaciente = repositorioPaciente;
        }

        public bool Gravar(PacienteViewModel paciente)
        {
                        
            PlanoDeSaude planoDeSaude = new PlanoDeSaude("1234", "Teste", "Tipo Plano");            
            Credencial credencial = new Credencial("Fabio","FabioCPF");                        
            Paciente pacient = new Paciente(paciente.Nome,paciente.Cpf);


            pacient.DefinirPlanoDeSaude(planoDeSaude);
            pacient.DefinirCredencial(credencial);

            return _repositorioPaciente.Gravar(pacient);
        }

        public List<PacienteViewModel> ListarPorTrecho(string nome)
        {
            return _repositorioPaciente.RetornarPorTrechoNome(nome).Select(paciente => new PacienteViewModel { Cpf = paciente.CPF, Nome = paciente.Nome }).ToList();
        }

        public bool Excluir(PacienteViewModel paciente)
        {

            return _repositorioPaciente.Excluir(new Paciente(paciente.Nome, paciente.Cpf));
        }
    }
}