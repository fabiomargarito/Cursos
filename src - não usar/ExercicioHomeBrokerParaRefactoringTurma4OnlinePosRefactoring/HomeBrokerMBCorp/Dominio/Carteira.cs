using System;
using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Carteira
    {
        protected IList<Operacao> _operacoes; 
        public Usuario Usuario { get; private set; }

        public IList<Operacao> ListarOperacoes()
        {
            return _operacoes;
        }
        
        public void AdicionarOperacao(Operacao operacao)
        {
            DeveCriarListaDeOperacoesCasoNaoExista(operacao);
            _operacoes.Add(operacao);
        }


        private void DeveCriarListaDeOperacoesCasoNaoExista(Operacao operacao)
        {
            if (_operacoes == null)
                _operacoes = new List<Operacao>();
        }

        public void RemoverOperacao(Operacao operacao)
        {
            _operacoes.Remove(operacao);
        }

     
                   
    }
}