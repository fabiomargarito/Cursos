

namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Paciente
    {
        public Paciente(string cpf, string nome)
        {
            CPF = cpf;
        }

        public Paciente()
        {
        }

        public virtual string CPF { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual Telefone Telefone { get; protected set; }
        public virtual string Email { get; protected set; }
    }
}