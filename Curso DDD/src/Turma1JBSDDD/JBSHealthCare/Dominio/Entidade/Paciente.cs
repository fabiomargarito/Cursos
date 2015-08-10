namespace JBSHealthCare.Dominio.Entidade
{
    public class Paciente
    {
        public string Cpf { get; }
        public string Nome { get; set; }

        public Paciente(string cpf, string nome)
        {
            this.Cpf = cpf;
            Nome = nome;
        }
    }
}