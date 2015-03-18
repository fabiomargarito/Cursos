namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Medico
    {
        public Medico(string crm, string nome)
        {
            CRM = crm;
        }

        public Medico()
        {
        }

        public virtual string CRM { get; protected set; }
        public virtual string Nome { get; protected set; }
    }
}