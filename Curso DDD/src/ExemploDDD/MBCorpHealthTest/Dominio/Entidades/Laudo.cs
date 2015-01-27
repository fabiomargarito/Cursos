namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Laudo
    {
        public string Descricao { get; protected set; }

        public Laudo(string descricao)
        {


            Descricao = descricao;

        }

        public Laudo()
        {
        }

        public int ID { get; set; }
    }
}