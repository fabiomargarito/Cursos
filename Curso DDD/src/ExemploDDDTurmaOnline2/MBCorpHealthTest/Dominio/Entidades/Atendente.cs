namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Atendente
    {
        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
        }

        public Atendente()
        {
        }

        public virtual string CPF { get; protected set; }
        public virtual string Nome { get; protected set; }
    }
}