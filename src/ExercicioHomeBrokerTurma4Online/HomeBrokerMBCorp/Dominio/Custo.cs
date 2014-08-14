using System.Security;

namespace HomeBrokerMBCorp.Dominio
{
    public class Custo
    {
        public TipoCusto TipoCusto { get; set; }
        public double Valor { get; set; }
        public double Percentual { get; set; }

        public abstract double CalcularCusto(double valorOperacao);

    }



    public class CustoCorretagemXpInvestimento : Custo
    {
        public CustoCorretagemXpInvestimento()
        {
            TipoCusto = TipoCusto.TaxaCorretagem;
            Valor = 10;
        }

        public override double CalcularCusto(double valorOperacao)
        {
            return Valor;
        }
    }


    public class CustoCorretagemItau : Custo
    {
        public CustoCorretagemItau()
        {
            TipoCusto = TipoCusto.TaxaCorretagem;
            Valor = 10;
            Percentual = 0.03;
        }

        public override double CalcularCusto(double valorOperacao)
        {
            return (valorOperacao*0.03) + valorOperacao;
        }
    }

}