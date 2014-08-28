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

        public string CNPJ { get; private set; }
        public string RazaoSocial { get; private set; }
        public List<Acao> Acoes { get; private set; }
        
        
        public void AdicionarAcao(Acao acao)
        {
            ValidarAcao(acao);
            CriarListaDeAcoesCasoNaoExista();         
            Acoes.Add(acao);
            
        }

        private void ValidarAcao(Acao acao)
        {
            if (String.IsNullOrEmpty(acao.Codigo))
                throw new Exception("Acao inválida!");
        }

        private void CriarListaDeAcoesCasoNaoExista()
        {
            if (Acoes == null)
                Acoes = new List<Acao>();                    
        }



    }
}