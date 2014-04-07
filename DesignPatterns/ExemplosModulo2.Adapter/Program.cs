using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter;
namespace ExemplosModulo2.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento meioDePagamentoCartao = new CartaoCredito();
            meioDePagamentoCartao.EfetuarPagamento(100);
            Console.ReadKey();

            meioDePagamentoCartao = new CartaoCreditoVisa();
            meioDePagamentoCartao.EfetuarPagamento(100);
            Console.ReadKey();

        }
    }
}
