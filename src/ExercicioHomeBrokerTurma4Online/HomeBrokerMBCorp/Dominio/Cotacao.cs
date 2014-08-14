using System;

namespace HomeBrokerMBCorp.Dominio
{
    public class Cotacao
    {
        public double Preco { get; set; }
        public double ValorDeAbertura { get; set; }
        public double ValorDeFechamento { get; set; }
        public double Oscilacao { get; set; }
        public double Volume { get; set; }
        public DateTime HoraDaCotacao { get; set; }

        public Cotacao RetornarCotacao(Acao acao)
        {
            return new Cotacao();
        }


    }
}