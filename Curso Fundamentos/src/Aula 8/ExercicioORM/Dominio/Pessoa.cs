using System;

namespace MBCorpHealth.Dominio
{
    public abstract class  Pessoa
    {
        public virtual string Nome { get; protected set; }
        public virtual Credencial Credencial { get; protected set; }
        public virtual string CPF { get; protected set; }
        protected  Pessoa()
        {
        }

        protected  Pessoa(string nome, string cpf)
        {
            ValidarDadosDaPessoa(nome,cpf);
            Nome = nome;
            CPF = cpf;
        }

        protected virtual void ValidarDadosDaPessoa(string nome, string cpf)
        {
            if (String.IsNullOrEmpty(nome) ) throw new ArgumentNullException("É necessário informar o nome!");
            if (String.IsNullOrEmpty(cpf)) throw new ArgumentNullException("É necessário informar o cpf!");
        }

       
        public virtual void DefinirCredencial(Credencial credencial)
        {
            Credencial = credencial;
        }        
    }
}