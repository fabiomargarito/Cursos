using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.EventosAgendamentoCriado
{
    class AgendamentoCriado:IEventoDeDominio
    {
        public Agendamento Agendamento { get; set; }

        public AgendamentoCriado(Agendamento agendamento)
        {
            Agendamento = agendamento;
        }
    }
}