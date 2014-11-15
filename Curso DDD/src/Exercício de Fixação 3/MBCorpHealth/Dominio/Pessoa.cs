using System;

namespace MBCorpHealth.Dominio
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public virtual string Nome { get;  set; }
        //public Credencial Credencial { get; private set; }
        public virtual string CPF { get;  set; }

        public Pessoa(string nome, string cpf)
        {
            ValidarDadosDaPessoa(nome,cpf);
            Nome = nome;
            CPF = cpf;
        }

        protected  virtual void ValidarDadosDaPessoa(string nome, string cpf)
        {
            if (String.IsNullOrEmpty(nome) ) throw new ArgumentNullException("É necessário informar o nome!");
            if (String.IsNullOrEmpty(cpf)) throw new ArgumentNullException("É necessário informar o cpf!");
        }

       
        //public void DefinirCredencial(Credencial credencial)
        //{
        //    Credencial = credencial;
        //}        
    }
}