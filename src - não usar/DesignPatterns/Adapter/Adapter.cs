using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    
    public class CartaoVisa:Pagamento
    {
        
        public void EfetuarPagamento(double valor)
        {
            Visa visa = new Visa();
            visa.Pagar(123,valor);
            Console.WriteLine("Pago com visa");
        }
    }

    //Target    
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
            Console.WriteLine("Pagamento Efetuado Por Empresa Terceira a Visa");
        }
    }


    //Adapter
    public class AdaptadorCartaoVisa:Pagamento
    {
        public void EfetuarPagamento(double valor)
        {
            Visa visa = new Visa();
            visa.Pagar(1234,valor);
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