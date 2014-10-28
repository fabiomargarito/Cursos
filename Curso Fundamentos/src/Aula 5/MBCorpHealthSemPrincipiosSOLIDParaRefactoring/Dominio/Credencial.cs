namespace MBCorpHealth.Dominio
{
    public class Credencial
    {
        public Credencial(string nomeDeUsuario, string senha)
        {
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha;
        }

        public string NomeDeUsuario { get; private set; }
        public string Senha { get; private set; }

      
    }
}
