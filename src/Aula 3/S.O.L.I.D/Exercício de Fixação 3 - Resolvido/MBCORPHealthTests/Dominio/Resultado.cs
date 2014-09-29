using System;

namespace MBCORPHealthTests
{
    public class Resultado
    {
        public Resultado(Medico medico, string laudo, DateTime dataConclusaoAnalise)
        {
            Medico = medico;
            Laudo = laudo;
            DataConclusaoAnalise = dataConclusaoAnalise;
        }

        public Medico Medico { get; private set; }
        public string Laudo { get; private set; }
        public DateTime DataConclusaoAnalise { get; private set; }
    }
}