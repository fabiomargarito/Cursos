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

        public Resultado()
        {
        }

        public virtual Medico Medico { get; protected set; }
        public virtual string Laudo { get; protected set; }
        public virtual DateTime DataConclusaoAnalise { get; protected set; }
    }
}