using System;
using MBCorpHealthTest.Dominio.Contratos;

namespace MBCorpHealthTest.Dominio.EventosDeDominio.EventosAgendamentoCriado
{
    class EnviarSmsParaOPacienteQuandoAgendamentoCRiado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine(string.Format("SMS enviado para o paciente {0}", evento.Agendamento.Paciente.Nome));
        }
    }
}