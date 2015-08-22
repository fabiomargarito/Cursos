namespace JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos
{
    public class Paciente
    {
        public Paciente()
        {
        }

        public virtual string Cpf { get; protected set; }
        public virtual string Nome { get; protected set; }

        public Paciente(string cpf, string nome)
        {
            this.Cpf = cpf;
            Nome = nome;
        }
    }
}