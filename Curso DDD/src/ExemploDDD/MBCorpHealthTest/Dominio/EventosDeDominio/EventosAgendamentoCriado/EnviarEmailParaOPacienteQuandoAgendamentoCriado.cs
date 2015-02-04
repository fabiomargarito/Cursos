using System;
using MBCorpHealthTest.Dominio.Contratos;

namespace MBCorpHealthTest.Dominio.EventosDeDominio.EventosAgendamentoCriado
{
    class EnviarEmailParaOPacienteQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        private readonly IServicoDeEnvioEmail _servicoDeEnvioEmail;

        public EnviarEmailParaOPacienteQuandoAgendamentoCriado(IServicoDeEnvioEmail servicoDeEnvioEmail)
        {
            _servicoDeEnvioEmail = servicoDeEnvioEmail;
        }

        public void ManipularEvento(AgendamentoCriado evento)
        {
            _servicoDeEnvioEmail.Enviar("fabiomargarito@gmail.com","fabiomargarito@gmail.com","meu assunto de teste","mensagem");
            Console.WriteLine(string.Format("Email enviado para o paciente {0}",evento.Agendamento.Paciente.Nome));
        }
    }
}