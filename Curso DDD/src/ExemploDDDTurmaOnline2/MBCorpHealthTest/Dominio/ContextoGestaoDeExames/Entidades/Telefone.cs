namespace MBCorpHealthTest.Dominio.Entidades
{
    public  class Telefone   
    {
        public Telefone(string ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public Telefone()
        {
        }

        public virtual string DDD { get; protected set; }
        public virtual string Numero { get; protected set; }
    }
}