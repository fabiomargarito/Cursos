using System;

namespace MBCORPHealthTests
{
    public class CredencialAcesso
    {
        public CredencialAcesso(string nomeUsuario, string senha)
        {

            if (string.IsNullOrEmpty(NomeUsuario)) throw new Exception("NomeUsuario inválido");
            if (string.IsNullOrEmpty(Senha)) throw new Exception("Senha inválido");

            NomeUsuario = nomeUsuario;
            Senha = senha;
        }

        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }
    }
}