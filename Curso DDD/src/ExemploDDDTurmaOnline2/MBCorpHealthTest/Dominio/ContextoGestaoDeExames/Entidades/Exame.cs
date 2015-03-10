using System;
using MBCorpHealthTest.Dominio.EventosDeDominio;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Exame
    {
        public Exame()
        {
        }

        public virtual TipoExame TipoExame { get; protected set; }
        public virtual CentroDiagnostico CentroDiagnostico { get; protected set; }
        public virtual DateTime DataDoAgendamento { get; protected set; }
        public virtual Laudo Laudo { get; protected set; }
        public virtual Double Preco { get; protected set; }

        public Exame(TipoExame tipoExame, CentroDiagnostico centroDiagnostico, DateTime dataDoAgendamento)
        {
            TipoExame = tipoExame;
            CentroDiagnostico = centroDiagnostico;
            DataDoAgendamento = dataDoAgendamento;
        }

        public virtual void EmitirLaudo(string resultado, Medico medicoAnalise)
        {
            Laudo = new Laudo(medicoAnalise, resultado);
            EventosDoDominio.Disparar(new LaudoEmitido());
        }
    }
}