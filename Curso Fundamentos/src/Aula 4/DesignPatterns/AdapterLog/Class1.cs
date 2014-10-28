using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterLog;

namespace AdapterLog
{
    public enum TipoLog 
    {
    Erro,Aviso,Rastreabilidade
    }  ;


    //Target
    public interface ILog
    {
        void RegistrarLog(string mensagem, TipoLog tipoLog);
    }


    public class Log : ILog
    {
        public void RegistrarLog(string mensagem, TipoLog tipoLog)
        {
            Console.WriteLine("log padrão da aplicação {0} {1}", mensagem,tipoLog);
        }
    }

    //Adaptee
    public class LOG4NET
    {
        public void Write(string mensagem)
        {
            Console.WriteLine("Log for NET {0}", mensagem);
        }

    }

    //Adapter
    public class LOG4NETAdaptado : ILog
    {
        
        public void RegistrarLog(string mensagem, TipoLog tipoLog)
        {
            new LOG4NET().Write(mensagem);
        }
    }
}
