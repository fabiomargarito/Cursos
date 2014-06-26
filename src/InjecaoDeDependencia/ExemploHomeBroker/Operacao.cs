using System;

namespace Dominio
{
    public class Operacao
    {
        public Acao Acao { get; set; }
        public Cotacao Cotacao { get; set; }
        public double Quantidade { get; set; }
        public DateTime Vencimento { get; set; }
        //1 compra e 2 Venda
        public int Tipo { get; set; }
    }
}