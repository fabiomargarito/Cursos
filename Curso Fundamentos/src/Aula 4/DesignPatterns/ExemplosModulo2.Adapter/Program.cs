using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Adapter;
namespace ExemplosModulo2.Adapter
{
    class Program
    {
        
        public string Nome { get; set; }

        private static void Main(string[] args)
        {
            Pagamento meioDePagamentoCartao = new CartaoAdaptado();
            meioDePagamentoCartao.EfetuarPagamento(100);
          
            Console.ReadKey();

        }

        }
    }
