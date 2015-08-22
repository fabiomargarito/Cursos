using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;
using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;

namespace JBSHealthCare.Dominio.Fabrica.BoundedContextGestaoDeAgendamentos
{
    public class FabricaDeAgendamento
    {
        private Medico _medico;
        private Paciente _paciente;
        private CID _cid;

        public FabricaDeAgendamento InformarMedico(string crm)
        {
            _medico = new Medico(crm,"");
            return this;

        }

        public FabricaDeAgendamento InformarPaciente(string cpf)
        {
            _paciente = new Paciente(cpf,"");
            return this;
        }

        public FabricaDeAgendamento InformarCID(string codigo)
        {
            _cid = new CID(codigo,"");
            return this;
        }

        public Agendamento Criar()
        {
            Agendamento agendamento = new Agendamento();
            agendamento.InformarMedico(_medico);
            agendamento.InformarPaciente(_paciente);
            agendamento.InformarCID(_cid);
            return agendamento;
        }



    }
}