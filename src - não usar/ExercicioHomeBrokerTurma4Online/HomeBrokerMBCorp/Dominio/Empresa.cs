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
            ValidarExistenciaDaListaDeAcoes(acao);
            Acoes.Add(acao);
        }

        private void ValidarExistenciaDaListaDeAcoes(Acao acao)
        {
            if (Acoes == null)
                Acoes = new List<Acao>();
        }
    }
}