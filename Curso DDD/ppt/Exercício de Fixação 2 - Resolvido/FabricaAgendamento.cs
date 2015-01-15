namespace MBCorpHealth.Dominio
{
    public class FabricaAgendamento
    {
        private Agendamento _agendamento;

        public FabricaAgendamento CriarAgendamento()
        {
            _agendamento = new Agendamento();
            return this;
        }

        public FabricaAgendamento InformarPaciente(Paciente paciente)
        {
            _agendamento.InformarPaciente(paciente);
            return this;
        }

        public Agendamento InformarMedicoSolicitante(Medico medicoSolicitante)
        {
            _agendamento.InformarMedicoSolicitante(medicoSolicitante);
            return _agendamento;
        }
    }
}