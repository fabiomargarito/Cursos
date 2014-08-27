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
            return new List<Operacao>();
        }
        
        public void AdcOperacao(Operacao operacao)
        {
            VldDadosOperacao(operacao);
            _operacoes.Add(operacao);
        }


        private void VldDadosOperacao(Operacao operacao)
        {
            if (operacao == null)
                _operacoes = new List<Operacao>();
        }

        public void rmOperacao(Operacao operacao)
        {
            _operacoes.Remove(operacao);
        }

        public double CalcularCorretagemCorretoraAlpes(double valorOperacao)
        {
            return 20;
        }
                   
    }
}