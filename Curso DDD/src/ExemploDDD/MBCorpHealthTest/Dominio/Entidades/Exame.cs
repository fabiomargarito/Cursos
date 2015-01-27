namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Exame
    {

        public   Exame(TipoExame tipoExame)
        {
            TipoExame = tipoExame;
        }

        public Exame()
        {
        }

        public virtual  TipoExame TipoExame { get; protected set; }
        public virtual  Laudo Laudo { get; protected set; }
        public virtual  int ID { get; set; }

        public virtual  void EmitirLaudo(Laudo laudo)
        {
            Laudo = laudo;

        }
    }
}