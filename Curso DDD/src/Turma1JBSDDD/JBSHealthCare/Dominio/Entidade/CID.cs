namespace JBSHealthCare.Dominio.Entidade
{
    public class CID
    {
        public string Descricao { get; private set; }
        public string Numero { get; private set; }

        public CID(string numero, string descricao)
        {
            Descricao = descricao;
            this.Numero = numero;
        }
    }
}