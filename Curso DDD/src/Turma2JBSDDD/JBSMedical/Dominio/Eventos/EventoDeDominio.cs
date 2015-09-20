using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBSMedical.Dominio.Entidades;
using Microsoft.Practices.Unity;

namespace JBSMedical.Dominio.Eventos
{
    //Subject
    public interface IEventoDeDomino
    {
        string NomeDoEvento { get; set; }
    }

    public class PacienteCadastrado:IEventoDeDomino
    {
        public PacienteCadastrado()
        {
            NomeDoEvento = "Paciente Cadastrado";
        }

        public string NomeDoEvento { get; set; }
    }

    //Concrete Subject
    public class AgendamentoCriado  : IEventoDeDomino
    {
        public Agendamento Agendamento { get; set; }

        public AgendamentoCriado(Agendamento agendamento)
        {
            Agendamento = agendamento;
            NomeDoEvento = "AgendamentoCriado";
        }

        public string NomeDoEvento { get; set; }
        
    }


    //Observer
    public interface IManipuladorDeEvento<T> where T : IEventoDeDomino
    {
        //update
        void ManipularEvento(T evento);
    }


    //Concrete Observer
    public class EnviarEmailQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        //update    
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Evento de envio de e-mail disparado");
        }
    }


    public class EnviarMsgWhatsappQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        //update    
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Evento zapzap disparado");
        }
    }


    public class EnviarSMSQuandoAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        //update    
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Evento de envio de sms disparado");
        }
    }


    public class EnviarSMSQuandoPacienteCadastrado : IManipuladorDeEvento<PacienteCadastrado>
    {
        //update    
        public void ManipularEvento(PacienteCadastrado evento)
        {
            Console.WriteLine("Evento de envio de sms disparado quando paciente cadatrado");
        }

      
    }

    //Notify
    public class EventosDoDominio
    {
        public static void Disparar<T>(T evento) where T : IEventoDeDomino
        {
            var unityContainer = new UnityContainer();

            //Attach  
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarEmailQuandoAgendamentoCriado>("EnviarEmailQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarSMSQuandoAgendamentoCriado>("EnviarSMSQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<AgendamentoCriado>, EnviarMsgWhatsappQuandoAgendamentoCriado>("EnviarMsgWhatsappQuandoAgendamentoCriado");
            unityContainer.RegisterType<IManipuladorDeEvento<PacienteCadastrado>, EnviarSMSQuandoPacienteCadastrado>("EnviarSMSQuandoPacienteCadastrado");



            IList<IManipuladorDeEvento<T>> manipuladoresDeEventos =
                (IList<IManipuladorDeEvento<T>>) unityContainer.ResolveAll<IManipuladorDeEvento<T>>();


            foreach (var manipuladorDeEvento in manipuladoresDeEventos)
            {
                manipuladorDeEvento.ManipularEvento(evento);
            }

        }
    }
}
