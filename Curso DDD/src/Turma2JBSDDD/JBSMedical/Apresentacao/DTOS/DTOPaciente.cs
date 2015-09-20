namespace JBSMedical.Apresentacao.DTOS
{
    public class DTOPaciente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public DTOPaciente(string CPF, string Nome)
        {
            Cpf = CPF;
            this.Nome = Nome;
        }
    }
}