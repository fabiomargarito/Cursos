using System;

namespace MBCorpHealthTestTests
{
    public class Exame
    {
        public TipoExame TipoExame { get; private set; }
        public CentroDiagnostico CentroDiagnostico { get; private set; }
        public DateTime DataDoAgendamento { get; private set; }
        public Laudo Laudo { get; set; }
        public Double Preco { get; set; }

        public Exame(TipoExame tipoExame, CentroDiagnostico centroDiagnostico, DateTime dataDoAgendamento)
        {
            TipoExame = tipoExame;
            CentroDiagnostico = centroDiagnostico;
            DataDoAgendamento = dataDoAgendamento;
        }

        public void EmitirLaudo(string resultado, Medico medicoAnalise)
        {
            Laudo = new Laudo(medicoAnalise,resultado);
        }
    }
}