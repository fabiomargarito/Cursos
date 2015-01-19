using System;

namespace MBCorpHealthTestTest
{
    public class FabricaDeAgendamento
    {

        private String cpfPaciente;

        private String crmMedico;

        private String cpfAtendente;

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

    public class Repositorio
    {

        internal Paciente ObterPacientePeloCPF(string cpfPaciente)
        {

            return new Paciente(cpfPaciente,"teste","teste");

        }

        internal Medico ObterMedicoPeloCrm(string crmMedico)
        {

            return new Medico(crmMedico, "teste", "SP");

        }

        internal Atendente ObterAtendentePeloCPF(string cfpAtendente)
        {

            return new Atendente(cfpAtendente, "teste");

        }

    }

}