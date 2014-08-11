using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod;

namespace FactoryMethodn
{
    public class Pagamento
    {
        public string CPF { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public double ValorTotal { get; set; }
    }

    public interface IHubPagamento
    {
        bool RegistrarPagamento(Pagamento pagamento);
    }

    public enum TipoHub
    {
        PAGSEGURO,
        PAYPALL
    }

    public class PagamentoFactory
    {
        public  IHubPagamento CriarHubPagamento(TipoHub tipoHub)
        {
            switch (tipoHub)
            {
                case TipoHub.PAGSEGURO: return new PagSeguro();
                case TipoHub.PAYPALL: return new PayPall();               
                default: throw new Exception("HUB de pagamento informado não exite");
            }
        }
    }

    public class PagSeguro:IHubPagamento
    {
        public bool RegistrarPagamento(Pagamento pagamento)
        {
            Console.WriteLine("Pagamento efetuado com pagseguro");
            return true;
        }
    }


    public class PayPall : IHubPagamento
    {
        public bool RegistrarPagamento(Pagamento pagamento)
        {
            Console.WriteLine("Pagamento efetuado com pagseguro");
            return true;
        }
    }
}
