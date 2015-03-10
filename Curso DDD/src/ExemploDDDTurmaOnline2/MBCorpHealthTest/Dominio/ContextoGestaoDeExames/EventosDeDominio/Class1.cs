using System;
using System.Collections.Generic;
using MBCorpHealthTest.Dominio.Entidades;
using Microsoft.Practices.Unity;

namespace MBCorpHealthTest.Dominio.EventosDeDominio
{
    
    //Subject
    public interface IEventoDeDomino
    {
        string NomeDoEvento { get; set; }
    }


    //Concrete Subject
    public class LaudoEmitido:IEventoDeDomino
    {
        public string NomeDoEvento { get; set; }
    }

    //Concrete Subject
    public class AgendamentoCriado:IEventoDeDomino
    {
        public AgendamentoCriado(Agendamento agendamento)
        {
            NomeDoEvento = "Agendamento Criado";
            Agendamento = agendamento;
        }

        public string NomeDoEvento { get; set; }
        public Agendamento Agendamento { get; set; }
    }


    //Observer
    public interface IManipuladorDeEvento<T> where T : IEventoDeDomino
    {
        //update
        void ManipularEvento(T evento);
    }


    //Concrete Observer
    public class EnvioDeEmailQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        //update    
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Evento Disparado e Email enviado");
        }
    }

    public class EnvioDeSmsQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Evento Disparado e SMS enviado");
        }
    }

    public class EnvioDeSMSQuandoLaudoEmitido:IManipuladorDeEvento<LaudoEmitido>
    {
        public void ManipularEvento(LaudoEmitido evento)
        {
            Console.WriteLine("Evento Laudo Emitido Disparado e SMS Enviado");
        }
    }

    public class EnvioDeEmailQuandoLaudoEmitido:IManipuladorDeEvento<LaudoEmitido>
    {
        public void ManipularEvento(LaudoEmitido evento)
        {
            Console.WriteLine("Evento Laudo Emitido Disparado e e-mail Enviado");
        }
    }


    public class GravaLogQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine(string.Format("Evento Disparado e LOG criado para o agendamento: {0} ",evento.Agendamento.Numero));
        }
    }


    //Notify
    class EventosDoDominio
    {
        public static void Disparar<T>(T evento) where T : IEventoDeDomino
        {
            var unityContainer = new UnityContainer();

            //Attach  
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnvioDeEmailQuandoAgendamentoCriado>("EnvioDeEmailQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnvioDeSmsQuandoAgendamentoCriado>("EnvioDeSmsQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, GravaLogQuandoAgendamentoCriado>("GravaLogQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<LaudoEmitido>, EnvioDeEmailQuandoLaudoEmitido>("EnvioDeEmailQuandoLaudoEmitido");
            unityContainer.RegisterType<IManipuladorDeEvento<LaudoEmitido>, EnvioDeSMSQuandoLaudoEmitido>("EnvioDeSMSQuandoLaudoEmitido");
      

            IList<IManipuladorDeEvento<T>> manipuladoresDeEventos = (IList<IManipuladorDeEvento<T>>)  unityContainer.ResolveAll<IManipuladorDeEvento<T>>();


            foreach (var manipuladorDeEvento in manipuladoresDeEventos)
            {
                manipuladorDeEvento.ManipularEvento(evento);
            }

        }
    }
}


