using System;

namespace MBCORPHealthTests
{
    public class Exame
    {
        public Exame(TipoExame tipoExame, DateTime dataAgendametoExame)
        {
            TipoExame = tipoExame;
            DataAgendametoExame = dataAgendametoExame;
        }

        public Exame()
        {
        }

        public virtual TipoExame TipoExame { get; protected set; }
        public virtual DateTime DataAgendametoExame { get; protected set; }        
        public virtual Resultado Resultado { get; protected set; }

        public virtual void InformarResultado(Resultado resultado)
        {
            Resultado = resultado;
        }
    }
}