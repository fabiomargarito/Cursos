using System;
using MBCorpHealthTest.Dominio.Contratos;

namespace MBCorpHealthTest.Dominio.EventosDeDominio.EventosAgendamentoCriado
{
    class LogarAtendenteQueCriouOAgendamentoQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine(string.Format("Agendamento de número {0} criado por {1}", evento.Agendamento.ID,evento.Agendamento.Atendente.Nome));
        }
    }
}