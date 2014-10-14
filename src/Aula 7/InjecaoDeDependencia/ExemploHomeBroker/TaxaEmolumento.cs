namespace Dominio
{
    public class TaxaEmolumento : Taxa
    {
        public override double Calcular(Operacao operacao, Corretora corretora)
        {
            double total = operacao.Quantidade * operacao.Cotacao.Valor;          
            total += total * 0.000035;
            return total;
        }
    }
}