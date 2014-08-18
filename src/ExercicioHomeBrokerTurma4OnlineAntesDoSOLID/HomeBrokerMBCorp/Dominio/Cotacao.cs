using System;

namespace HomeBrokerMBCorp.Dominio
{
    public class Cotacao
    {
        public double Preco { get; private set; }
        public double ValorDeAbertura { get; private set; }
        public double ValorDeFechamento { get; private set; }
        public double Oscilacao { get; private set; }
        public double Volume { get; private set; }
        public DateTime HoraDaCotacao { get; private set; }

        public Cotacao RetornarCotacao(Acao acao)
        {
            Preco = 10;
            ValorDeAbertura = 11;
            ValorDeFechamento = 12;
            Oscilacao = ((12/11) - 1)*100;
            Volume = 100000;
            HoraDaCotacao = DateTime.Today;
            return this;
        }


    }
}