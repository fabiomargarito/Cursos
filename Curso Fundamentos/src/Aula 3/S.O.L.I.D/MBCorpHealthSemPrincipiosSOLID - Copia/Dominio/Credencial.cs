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
        public Credencial GerarCredencialInicial(Pessoa pessoa)
        {
            var credencial = new Credencial(string.Format("{0}{1}", pessoa.Nome.Split(' ')[0], pessoa.CPF), pessoa.CPF);
            return credencial;
        }

      
    }
}
