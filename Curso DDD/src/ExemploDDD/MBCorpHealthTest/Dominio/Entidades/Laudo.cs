namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Laudo
    {
        public string Descricao { get; protected set; }

        public Laudo(string descricao)
        {


            Descricao = descricao;

        }

        protected Laudo()
        {
        }

        public int ID { get; set; }
    }
}