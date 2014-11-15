namespace MBCorpHealth.Dominio
{
    public class Credencial
    {
        public string NomeDeUsuario { get; private set; }
        public string Senha { get; private set; }

        public Credencial GerarCredencialInicial(Pessoa pessoa)
        {
            var credencial = new Credencial();
            credencial.NomeDeUsuario = string.Format("{0}{1}", pessoa.Nome.Split(' ')[0], pessoa.CPF);
            credencial.Senha = pessoa.CPF;
            return credencial;
        }
    }
}
