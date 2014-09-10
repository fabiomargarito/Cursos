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

        public TipoExame TipoExame { get; private set; }
        public DateTime DataAgendametoExame { get; private set; }        
        public Resultado Resultado { get; private set; }

        public void InformarResultado(Resultado resultado)
        {
            Resultado = resultado;
        }
    }
}