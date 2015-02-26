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

        public Medico MedicoAnalise { get; private set; }
        public string Resultado { get; private set; }
        
    }
}