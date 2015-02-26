namespace MBCorpHealthTest.Dominio.Entidades
{
    public class TipoExame
    {
        public TipoExame()
        {
        }

        public string CBHPM { get; private set; }
        public double Preco { get; private set; }

        public TipoExame(string cbhpm, double preco)
        {
            CBHPM = cbhpm;
            Preco = preco;
        }
    }
}