namespace HomeBrokerMBCorp.Dominio
{

    public interface Imposto
    {
        double CalcularImposto(double valorOperacao);        
    }

    public abstract class Corretagem
    {
        public abstract double CalcularCorretagem(double valorOperacao);
    }

    public class CustoEmolumento : Imposto
    {
        public double CalcularImposto(double valorOperacao)
        {
            return valorOperacao * 0.000325;
        }
        
    }

    public class CustoIR : Imposto
    {
        public double CalcularImposto(double valorOperacao)
        {
            return valorOperacao * 0.15;
        }
        
    }

    public class CustoIRDayTrade : Imposto
    {
        public double CalcularImposto(double valorOperacao)
        {
            return valorOperacao * .20;
        }
     
    }

    public class CustoCorretagemItau : Corretagem
    {
        public override double CalcularCorretagem(double valorOperacao)
        {
            return (valorOperacao * 0.03) + 10;
        }
    }

    public class CustoCorretagemXPInvestimento : Corretagem
    {
        public override double CalcularCorretagem(double valorOperacao)
        {
            return valorOperacao * 14.90;
        }
    }

    public class CustoCorretagemAgora : Corretagem
    {
        public override double CalcularCorretagem(double valorOperacao)
        {
            return 20;
        }
    }

    public class CustoCorretagemCitiBank : Corretagem
    {
        public override double CalcularCorretagem(double valorOperacao)
        {
            if (valorOperacao < 100000)
                return 15;

            return CalcularCustoParaOperacaoAcimaDeCemMilReais(valorOperacao);
        }

        private double CalcularCustoParaOperacaoAcimaDeCemMilReais(double valorOperacao)
        {
            return valorOperacao * 0.02 + 15;
        }

    }

    public class CustoCorretagemBancoDoBrasil : Corretagem
    {
        public override double CalcularCorretagem(double valorOperacao)
        {
            return 10;
        }    
    }

    public class CustoCorretagemBarinsul : Corretagem
    {
        public bool ehClienteEspecial { get; set; }

        public override double CalcularCorretagem(double valorOperacao)
        {
            if(ehClienteEspecial)
                return 5;

            return 14;
        }
    }


}
