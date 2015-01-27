namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Credencial
    {
        public Credencial(string user, string senha)
        {
            User = user;
            Senha = senha;
        }

        public Credencial()
        {
        }

        public string User { get; protected set; }
        public string Senha { get; protected set; }
        public int ID { get; set; }
    }
}