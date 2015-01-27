namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Credencial{
        public   Credencial(string user, string senha)
        {
            User = user;
            Senha = senha;
        }

        public Credencial()
        {
        }

        public virtual  string User { get; protected set; }
        public virtual  string Senha { get; protected set; }
        public virtual  int ID { get; set; }
    }
}