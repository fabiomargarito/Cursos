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

        public Usuario()
        {
            
        }

        protected virtual void ValidarDadosDoUsuario(string cpf,string nome)
        {
             if (string.IsNullOrEmpty(cpf))
                throw new ArgumentNullException("Favor informar o cpf");

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("Favor informar o nome");
        }


        public virtual string CPF { get; protected set ; }
        public virtual string Nome { get; protected set ; }
    }



    public class UsuarioAdmin:Usuario
    {
        public string Setor { get; set; }
    }




}