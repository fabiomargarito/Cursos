using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MBCorpHealthTest.Dominio.Entidades;
using Microsoft.Practices.Unity;
using Remotion.Linq.Clauses;

namespace MBCorpHealthTest.Dominio.Contratos
{
    public interface IEventoDeDominio
    {
    }

    public class AgendamentoCriado : IEventoDeDominio
    {
        public AgendamentoCriado(Agendamento agendamento)
        {
            Agendamento = agendamento;
        }

        public Agendamento Agendamento { get; set; }
    }

    public interface IManipuladorDeEvento<T> where T:IEventoDeDominio
    {
        void ManipularEvento(T evento);
    }

    public static class EventosDeDominio
    {                
        public static void Disparar<T>(T evento) where T : IEventoDeDominio
        {
            var unityContainer = new UnityContainer();            
            
            var manipuladoresDeEvento = unityContainer.ResolveAll<IManipuladorDeEvento<T>>();

            foreach (var manipuladorDeEvento in manipuladoresDeEvento)
            {
                manipuladorDeEvento.ManipularEvento(evento);
            }
        }
    }
   
    public class EnviarEmailQuandoAgendamentoCriado:IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Email Enviado");
        }
    }

    public class GravarNaBaseAgendamentoCriado : IManipuladorDeEvento<AgendamentoCriado>
    {
        public void ManipularEvento(AgendamentoCriado evento)
        {
            Console.WriteLine("Dado Gravado");
        }
    }
}
