namespace MBCorpHealthTest.Dominio.Entidades
{
    public class TipoExame
    {
        public TipoExame()
        {
        }

        public virtual string CBHPM { get; protected set; }
        public virtual double Preco { get; protected set; }

        public TipoExame(string cbhpm, double preco)
        {
            CBHPM = cbhpm;
            Preco = preco;
        }
    }
}