using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
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