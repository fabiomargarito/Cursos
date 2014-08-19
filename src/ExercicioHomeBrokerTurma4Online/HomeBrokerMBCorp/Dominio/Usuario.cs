using System;

namespace HomeBrokerMBCorp.Dominio
{
    public class Usuario
    {
        //*
        public Usuario(string cpf, string nome)
        {
            ValidarDadosDoUsuario(cpf, nome);

            CPF = cpf;
            Nome = nome;
        }

        private void ValidarDadosDoUsuario(string cpf,string nome)
        {
             if (string.IsNullOrEmpty(cpf))
                throw new ArgumentNullException("Favor informar o cpf");

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("Favor informar o nome");
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
    }
}