using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace HomeBroker
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Acao
    {
        public string Codigo { get; set; }
        public Empresa Empresa { get; private set; }
        public Cotacao Cotacao { get; private set; }
        public TipoAcao TipoAcao { get; set; }

        public void ConsultarCotacao()
        {
            
        }
    }

    public class Cotacao
    {
        public double ValorUnitario { get; set; }
    }
    
    public class Empresa
    {
        public string Nome { get; set; }
    }

    public class Carteira
    {
        public List<Ordem> Ordems { get; private set; }

        public void AdicionarOrdem(Ordem ordem)
        {
            Ordems.Add(ordem);
        }
    }

    public class Corretora
    {
        public string Nome { get; set; }        
        public double TaxaDeServico { get; set; }

        public void EnviarOrdem(Ordem ordem)
        {
        }
    }

    public abstract class Ordem
    {
        public Acao Acao { get; set; }
        public DateTime DataOrdem { get; set; }
        public DateTime Validade { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }

        public abstract bool Cancelar();
        public abstract bool Executar();
       
    }

    public class Compra : Ordem
    {
        public override bool Cancelar()
        {
            throw new NotImplementedException();
        }

        public override bool Executar()
        {
            throw new NotImplementedException();
        }
    }

    public class Venda : Ordem
    {
        public double ValorStopLoss { get; set; }

        public override bool Cancelar()
        {
            throw new NotImplementedException();
        }

        public override bool Executar()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Cliente
    {
        public Carteira Carteira { get; set; }
        public TipoInvestidor TipoInvestidor { get; set; }
    }

    public class ClienteFisica : Cliente
    {
        public string CPF { get; set; }
    }

    public class ClienteJuridica : Cliente
    {
        public string CNPJ { get; set; }
    }

    public enum TipoInvestidor
    {
        AltoRisco,
        Normal

    }

    public enum TipoAcao
    {
        ON,
        PN
    }

    public class HomeBroker{}
}
