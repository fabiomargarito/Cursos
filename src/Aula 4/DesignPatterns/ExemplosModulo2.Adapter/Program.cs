using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter;
namespace ExemplosModulo2.Adapter
{
    class Program
    {
        private static void Main(string[] args)
        {
            Pagamento meioDePagamentoCartao = new CartaoVisa();
            meioDePagamentoCartao.EfetuarPagamento(100);
          
            Console.ReadKey();

        }

        }
    }
