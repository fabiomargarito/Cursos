using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    //Target
    //novo comentário
    public interface Pagamento
    {
        void EfetuarPagamento(double valor);
    }


    public class CartaoCredito : Pagamento
    {
        private double valorPagamento;
        public void EfetuarPagamento(double valor)
        {
            valorPagamento = valor;
            Console.WriteLine("Pagamento Efetuado");
        }
    }




    //Adaptee
    public class Visa { 
        
        private int codigoEmpresa;

        public void Pagar(int identificadorEmpresa, double valor){
            codigoEmpresa = identificadorEmpresa;
            Console.WriteLine("Pagamento Efetuado Por Empresa Terceira");
        }
    }
    
    //Adapter
    public class CartaoCreditoVisa : Pagamento
    {
        private Visa cartaoVisa;        

        public void EfetuarPagamento(double valor)
        {
            cartaoVisa = new Visa();
            cartaoVisa.Pagar(10, valor);
        }
    }

}