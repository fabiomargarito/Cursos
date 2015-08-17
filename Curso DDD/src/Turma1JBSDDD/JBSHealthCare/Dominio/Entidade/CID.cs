namespace JBSHealthCare.Dominio.Entidade
{
    public class CID
    {
        public CID()
        {
        }

        public virtual string Descricao { get; protected set; }
        public virtual string Numero { get; protected set; }

        public  CID(string numero, string descricao)
        {
            Descricao = descricao;
            this.Numero = numero;
        }
    }
}