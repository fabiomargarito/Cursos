using System;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;
using MBCorpHealthTest.Infraestrutura.ContextoAdministracaoDeAgendamentosDeExame.Repositorios;

namespace MBCorpHealthTest.Dominio.Fabricas
{
    public class FabricaDeAgendamento
    {

        protected String cpfPaciente;
        protected String crmMedico;
        protected String cpfAtendente;

        public FabricaDeAgendamento InformarPaciente(String cpf)
        {

            cpfPaciente = cpf;

            return this;

        }

        public FabricaDeAgendamento InformarMedicoSolicitante(String crm)
        {

            crmMedico = crm;

            return this;

        }

        public FabricaDeAgendamento InformarAtendente(String cpf)
        {

            cpfAtendente = cpf;

            return this;

        }

        public Agendamento Criar()
        {

            var repositorio = new Repositorio();

            var paciente = repositorio.ObterPacientePeloCPF(cpfPaciente);

            var medico = repositorio.ObterMedicoPeloCrm(crmMedico);

            var atendente = repositorio.ObterAtendentePeloCPF(cpfAtendente);

            return new Agendamento(paciente, medico, atendente);

        }

    }
}