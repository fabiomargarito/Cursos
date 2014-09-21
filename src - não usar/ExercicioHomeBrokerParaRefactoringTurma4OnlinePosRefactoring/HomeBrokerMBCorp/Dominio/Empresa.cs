using System;
using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Empresa
    {
        public Empresa(string cnpj, string razaoSocial)
        {
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
        }

        public Empresa()
        {
        }

        public virtual string CNPJ { get; protected set; }
        public virtual string RazaoSocial { get; protected set; }
       public virtual IList<Acao> Acoes { get; protected set; }


        public  virtual void AdicionarAcao(Acao acao)
        {
            ValidarAcao(acao);
            CriarListaDeAcoesCasoNaoExista();         
            Acoes.Add(acao);
            
        }

        protected virtual void ValidarAcao(Acao acao)
        {
            if (String.IsNullOrEmpty(acao.Codigo))
                throw new Exception("Acao inválida!");
        }

        protected virtual void CriarListaDeAcoesCasoNaoExista()
        {
            if (Acoes == null)
               Acoes = new List<Acao>();                    
        }
    }
}