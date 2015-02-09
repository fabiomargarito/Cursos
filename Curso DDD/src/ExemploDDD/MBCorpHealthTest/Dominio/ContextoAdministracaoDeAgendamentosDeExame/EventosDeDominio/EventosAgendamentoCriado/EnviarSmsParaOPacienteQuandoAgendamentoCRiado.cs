using System;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.EventosAgendamentoCriado
{
    class EnviarSmsParaOPacienteQuandoAgendamentoCRiado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine(string.Format("SMS enviado para o paciente {0}", evento.Agendamento.Paciente.Nome));
        }
    }
}