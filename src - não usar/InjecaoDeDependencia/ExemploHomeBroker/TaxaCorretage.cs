namespace Dominio
{
    public class TaxaCorretage : Taxa
    {
        public override double Calcular(Operacao operacao, Corretora corretora)
        {
            double total = operacao.Quantidade*operacao.Cotacao.Valor;
            total += 10;
            total += total*0.03;

            return total;
        }
    }
}