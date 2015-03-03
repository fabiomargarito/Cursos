namespace MBCorpHealthTest.Dominio.ObjetosDeValor
{
    public class CID
    {
        public CID(string descricao)
        {
            Descricao = descricao;
        }

        public CID()
        {
        }

        public virtual string Descricao { get; protected set; }


    }
}