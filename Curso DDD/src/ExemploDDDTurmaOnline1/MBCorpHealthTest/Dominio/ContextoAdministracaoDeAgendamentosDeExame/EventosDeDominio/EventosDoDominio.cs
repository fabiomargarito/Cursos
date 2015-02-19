using System.Collections.Generic;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.EventosAgendamentoCriado;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.ManipuladoresDeEventosLaudoEmitido;
using MBCorpHealthTest.Infraestrutura;
using Microsoft.Practices.Unity;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio
{
    class EventosDoDominio
    {
        public static void Disparar<T>(T evento) where T : IEventoDeDominio
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>,EnviarEmailParaOPacienteQuandoAgendamentoCriado>("EnviarEmailAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarSmsParaOPacienteQuandoAgendamentoCRiado>("EnviarSMSAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, LogarAtendenteQueCriouOAgendamentoQuandoAgendamentoCriado>("LogarAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<LaudoEmitido>, EnviarEmailParaPacienteQuandoLaudoEmitido>("EnviarEmailLaudoEmitido");
            unityContainer.RegisterType<IServicoDeEnvioEmail, ServicoDeEnvioEmailCorporativo>();


            IList<IManipuladorDeEvento<T>> manipuladoresDeEventos = (IList<IManipuladorDeEvento<T>>)  unityContainer.ResolveAll<IManipuladorDeEvento<T>>();


            foreach (var manipuladorDeEvento in manipuladoresDeEventos)
            {
                manipuladorDeEvento.ManipularEvento(evento);
            }


        }
    }
}