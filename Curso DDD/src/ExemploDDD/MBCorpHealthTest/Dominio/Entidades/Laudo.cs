namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Laudo
    {

        

        public virtual  string Descricao { get; protected set; }

        public   Laudo(string descricao)
        {


            Descricao = descricao;

        }


        public Laudo()
        {
        }

        public virtual  int ID { get; set; }
    }
}