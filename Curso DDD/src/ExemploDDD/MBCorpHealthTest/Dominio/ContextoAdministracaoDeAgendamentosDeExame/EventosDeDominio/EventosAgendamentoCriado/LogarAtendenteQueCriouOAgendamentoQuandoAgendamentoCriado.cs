using System;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.EventosAgendamentoCriado
{
    class LogarAtendenteQueCriouOAgendamentoQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine(string.Format("Agendamento de número {0} criado por {1}", evento.Agendamento.ID,evento.Agendamento.Atendente.Nome));
        }
    }
}