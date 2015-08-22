using System;
using System.Collections.Generic;
using JBSHealthCare.View.ViewModels;
using JBSHealthCare.View.ViewModels.BoundedContextGestaoDeAgendamentos;
using Microsoft.Practices.Unity;

namespace JBSHealthCare.Dominio.EventoDominio.BoundedContextGestaoDeAgendamentos
{

    //Subject
    public interface IEventoDeDomino
    {
        string NomeDoEvento { get; set; }
    }

    public class AgendamentoCancelado:IEventoDeDomino
    {
        public AgendamentoCancelado(AgendamentoViewModel agendamentoViewModel)
        {
            NomeDoEvento = "AgendamentoCancelado";
            AgendamentoViewModel = agendamentoViewModel;
        }

        public string NomeDoEvento { get; set; }
        public AgendamentoViewModel AgendamentoViewModel { get; set; }
    }

    //Concrete Subject
    public class AgendamentoCriado : IEventoDeDomino
    {
        public AgendamentoCriado(AgendamentoViewModel agendamento)
        {
            NomeDoEvento = "AgendamentoCriado";
            AgendamentoViewModel = agendamento;
        }

        public string NomeDoEvento { get; set; }
        public AgendamentoViewModel AgendamentoViewModel { get; set; }
    }


    //Observer
    public interface IManipuladorDeEvento<T> where T : IEventoDeDomino
    {
        //update
        void ManipularEvento(T evento);
    }


    //Concrete Observer
    public class EnviarSMSQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        //update    
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("SMS Enviado para o cliente:" + evento.AgendamentoViewModel.cpf);
        }
    }

    public class EnviarEmailParaCentroDiagnosticoQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Email Enviado para o centro de diagnóstico de saúde:" + evento.AgendamentoViewModel.cpf);
        }
    }


    public class NotificarAtendenteQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Atendente Notificado");
        }
    }

    //Concrete Observer
    public class EnviarSMSQuandoAgendamentoCancelado : IManipuladorDeEvento<AgendamentoCancelado>
    {
        //update    
        public void ManipularEvento(AgendamentoCancelado evento)
        {
            Console.WriteLine("SMS Enviado para o cliente:" + evento.AgendamentoViewModel.cpf);
        }
    }


    //Notify
    class EventosDoDominio
    {
        public static void Disparar<T>(T evento) where T : IEventoDeDomino
        {
            var unityContainer = new UnityContainer();

            //Attach  
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarSMSQuandoAgendamentoCriado>("EnviarSMSQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarEmailParaCentroDiagnosticoQuandoAgendamentoCriado>("EnviarEmailParaCentroDiagnosticoQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, NotificarAtendenteQuandoAgendamentoCriado>("NotificarAtendenteQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCancelado>, EnviarSMSQuandoAgendamentoCancelado>("EnviarSMSQuandoAgendamentoCancelado");



            IList<IManipuladorDeEvento<T>> manipuladoresDeEventos =
                (IList<IManipuladorDeEvento<T>>) unityContainer.ResolveAll<IManipuladorDeEvento<T>>();


            foreach (var manipuladorDeEvento in manipuladoresDeEventos)
            {
                manipuladorDeEvento.ManipularEvento(evento);
            }

        }
    }
}
