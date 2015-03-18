namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Medico
    {
        public Medico(string crm, string nome)
        {
            CodigoCRM = crm;
        }

        public Medico()
        {
        }

        public virtual string CodigoCRM { get; protected set; }
        public virtual string Nome { get; protected set; }
    }
}