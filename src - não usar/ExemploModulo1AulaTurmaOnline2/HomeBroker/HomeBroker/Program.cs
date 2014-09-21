using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;

namespace HomeBroker
{
    //estou aqui!
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
    
    //Arquivo 
    public class Acao
    {
        public string Codigo { get; set; }
        public Empresa Empresa { get; private set; }
        public Cotacao Cotacao { get; private set; }
        public Compra.TipoAcao TipoAcao { get; set; }

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
        private List<Ordem> Ordems = new List<Ordem>();

        public void AdicionarOrdem(Ordem ordem, Corretora corretora)
        {              
            var corretagem = new Corretagem();
            ordem.Valor += corretagem.CalcularCorretagem(ordem.Valor, corretora);
            Ordems.Add(ordem);
        }

        public List<Ordem> RetornarOrdems()
        {
            return Ordems;
        }
    }

    public class Corretagem
    {
        public double CalcularCorretagem(Double valor,Corretora corretora)
        {                     
            //calcular
            if (corretora.Nome == "ITAU")
                valor =  new CorretagemItau().CalcularCorretagem(valor);    
            if (corretora.Nome == "XP")
                valor = new CorretagemXP().CalcularCorretagem(valor);
            if (corretora.Nome == "SOCOPA")
                valor = new CorretagemSOCOPA().CalcularCorretagem(valor);
            if (corretora.Nome == "BANIF")
                valor = new CorretagemSOCOPA().CalcularCorretagem(valor);
            if (corretora.Nome == "WintradePadrao")
            {
                CorretagemBase corretagem = new CorretagemWintradeInvestidorPadrao();               
                valor = corretagem.CalcularCorretagem(valor);
            }
            if (corretora.Nome == "WintradeQualificado")
            {
                CorretagemBase corretagem = new CorretagemWintradeInvestidorQualificado();
                valor = corretagem.CalcularCorretagem(valor);
            }

            return valor;
        }
    }


    public abstract class CorretagemBase
    {
        public abstract double CalcularCorretagem(double valor);
    }


    public class CorretagemAgora:CorretagemBase
    {
        public override double CalcularCorretagem(double valor)
        {
            valor += 13;
            return valor;
        }
    }


    public class CorretagemWintradeInvestidorPadrao : CorretagemBase
    {
        public int tipoInvestidor;

        public override double CalcularCorretagem(double valor)
        {
            if (tipoInvestidor==1)
                valor += 34;
            if (tipoInvestidor == 2)
                valor += 10;
            return valor;
        }
    }

    public class CorretagemWintradeInvestidorQualificado : CorretagemBase
    {
        public int tipoInvestidor;

        public override double CalcularCorretagem(double valor)
        {
            if (tipoInvestidor == 1)
                valor += 34;
            if (tipoInvestidor == 2)
                valor += 10;
            return valor;
        }
    }


    public interface IEmolumento
    {        
        double CalcularEmolumento(double valor);
    }


    public interface ICorretagem
    {
        double CalcularCorretagem(double valor);        
    }

    public class CorretagemItau:ICorretagem
    {
        public double CalcularCorretagem(double valor)
        {
            valor += 10 + valor * 0.03;
            return valor;
        }

        
    }

    public class  CorretagemXP:ICorretagem
    {
        public double CalcularCorretagem(double valor)
        {
            valor += 14.30;
            return valor;
        }

        
    }

    public class CorretagemSOCOPA : ICorretagem
    {
        public double CalcularCorretagem(double valor)
        {
            valor += 39;
            return valor;
        }

       
    }


    public class CorretagemBANIF : ICorretagem
    {
        public double CalcularCorretagem(double valor)
        {
            valor += 5;
            return valor;
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



        public class Venda : Ordem
        {
            public double ValorStopLoss { get; set; }

            public override bool Cancelar()
            {
                return true;
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

        public class HomeBroker
        {
        }
    }
}
