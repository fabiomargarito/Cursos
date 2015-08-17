namespace JBSHealthCare.Dominio.Entidade
{
    public class Medico
    {
        public Medico()
        {
        }

        public virtual string Crm { get; protected set; }
        public virtual string Nome { get; protected set ; }

        public  Medico(string crm, string nome)
        {
            this.Crm = crm;
            Nome = nome;
        }
    }
}