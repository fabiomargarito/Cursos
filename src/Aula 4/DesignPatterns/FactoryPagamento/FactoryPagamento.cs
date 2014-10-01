using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FactoryPagamento
{


    public class Pagamento
    {
        public string CPF { get; set; }
        public string UF { get; set; }
        public string Estado { get; set; }
        private List<Item> _items = new List<Item>();
        private double _valorTotal;
        private double _ICMS;


        public List<Item> Items
        {
              get
            {
                return _items;
            }
        }

        public double ValorTotal
        {
            get { return _valorTotal; }
        }

        public double ICMS
        {
            get { return _ICMS; }
        }

        
        private void CalcularICMS()
        {
            _valorTotal = _items.Sum(x => x.Valor*x.Quantidade);
            _ICMS = _valorTotal*0.18;
            _valorTotal += ICMS;
        }

        

        public void AdicionarItem(string codigo, string descricao, int quantidade, double valor)
        {
            _items.Add(new Item{Codigo = codigo,Descricao = descricao,Quantidade = quantidade, Valor = valor});
            CalcularICMS();
        }

        public void ProcessarPagamento()
        {
            SistemaPagamento sistemaPagamento = new PayPall();
            sistemaPagamento.RegistrarPagamento(this);
        }

    }

    public class Item
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }


    //Product
    public abstract class SistemaPagamento
    {
        public abstract void RegistrarPagamento(Pagamento pagamento);
    }


    //Concrete Product
    public class PagSeguro:SistemaPagamento
    {
        public override void RegistrarPagamento(Pagamento pagamento)
        {
            Console.WriteLine("Pagamento com PagSeguro registrado no valor de {0}, obrigado",pagamento.ValorTotal);
        }
    }


    //Concrete Product
    public class PayPall : SistemaPagamento
    {
        public override void RegistrarPagamento(Pagamento pagamento)
        {
            Console.WriteLine("Pagamento com PayPall registrado no valor de {0}, obrigado", pagamento.ValorTotal);
        }
    }


    //Creator
    public abstract class PagamentoFactory
    {
        public abstract SistemaPagamento Criar();
    }

    //Concrete Creater
    public class PagSeguroFactory : PagamentoFactory
    {
        public override SistemaPagamento Criar()
        {
            return new PagSeguro();
        }
    }


    //Concrete Creator
    public class PayPallFactory : PagamentoFactory
    {
        public override SistemaPagamento Criar()
        {
            return new PayPall();
        }
    }

}

