namespace JBSHealthCare.Dominio.Entidade
{
    public class Agendamento
    {
        public Medico Medico
        {
            get; private set;}

    
        public Paciente Paciente { get; private set; }
        public CID Cid { get; set; }
    

        public void InformarMedico(Medico medico)
        {
            Medico = medico;
        }

        public void InformarCID(CID cid)
        {
            Cid = cid;
        }

        public void InformarPaciente(Paciente paciente)
        {
            Paciente = paciente;
        }
    }
}