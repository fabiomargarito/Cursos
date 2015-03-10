namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Laudo
    {
        public Laudo(Medico medicoAnalise, string resultado)
        {
            MedicoAnalise = medicoAnalise;
            Resultado = resultado;
        }

        public Laudo()
        {
        }

        public virtual Medico MedicoAnalise { get; protected set; }
        public virtual string Resultado { get; protected set; }
        
    }
}

