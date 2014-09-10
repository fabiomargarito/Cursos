using System;

namespace MBCORPHealthTests
{
    public  class CredencialAcesso
    {
        public  CredencialAcesso(string nomeUsuario, string senha)
        {

            if (string.IsNullOrEmpty(nomeUsuario)) throw new Exception("NomeUsuario inválido");
            if (string.IsNullOrEmpty(senha)) throw new Exception("Senha inválido");

            NomeUsuario = nomeUsuario;
            Senha = senha;
        }

        public CredencialAcesso()
        {
        }

        public virtual string NomeUsuario { get; protected set; }
        public virtual string Senha { get; protected set; }
        public virtual int ID { get; protected set; }
    }
}