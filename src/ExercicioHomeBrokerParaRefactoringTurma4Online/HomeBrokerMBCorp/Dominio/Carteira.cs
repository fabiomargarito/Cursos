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


        //*
        public void AdicionarOperacao(Operacao operacao)
        {
            ValidarDadosOperacao(operacao);
            _operacoes.Add(operacao);
        }


        private void ValidarDadosOperacao(Operacao operacao)
        {
            if (operacao == null)
                _operacoes = new List<Operacao>();
        }

        public void RemoverOperacao(Operacao operacao)
        {
            _operacoes.Remove(operacao);
        }
    }
}