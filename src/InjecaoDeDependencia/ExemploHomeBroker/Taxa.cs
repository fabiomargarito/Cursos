namespace Dominio
{
    public class Taxa
    {
        public double Valor { get; set; }        
        public virtual double Calcular(Operacao operacao, Corretora corretora)
        {
            return 1;
        }
    }
}