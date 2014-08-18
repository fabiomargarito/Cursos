namespace HomeBrokerMBCorp.Dominio
{
    public class Custo
    {
        private TipoCusto _tipoCusto;

        public Custo(TipoCusto tipoCusto)
        {
            _tipoCusto = tipoCusto;
        }
              
        public double CalcularCusto(double valorOperacao)
        {
            double valorCalculado = double.MinValue;

            if (_tipoCusto == TipoCusto.Emolumento)
            {
                valorCalculado=valorOperacao*0.000325;
            }
            else if (_tipoCusto == TipoCusto.IR)
            {
                valorCalculado = valorOperacao * 0.15;
            }
            else if (_tipoCusto == TipoCusto.IRDaytrade)
            {
                valorCalculado = valorOperacao * 0.20;
            }
            else if (_tipoCusto == TipoCusto.IR)
            {
                valorCalculado = valorOperacao * 0.15;
            }
            else if (_tipoCusto == TipoCusto.IR)
            {
                valorCalculado = valorOperacao * 0.15;
            }
            else if (_tipoCusto == TipoCusto.CorretagemItau)
            {
                valorCalculado = (valorOperacao*0.03) + 10;
            }
            else if (_tipoCusto == TipoCusto.CorretagemXPInvestimento)
            {
                valorCalculado = valorOperacao * 0.05;
            }
            return valorCalculado;
        }
    }   
}