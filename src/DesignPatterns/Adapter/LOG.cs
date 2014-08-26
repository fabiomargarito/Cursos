using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Adapter
{
    public enum TipoLog
    {
        Erro,
        Warning
    }

    public interface ILOG
    {
        void RegistrarLog(String mensagem,TipoLog tipoLog);
    }

    class LOG: ILOG
    {
        public void RegistrarLog(String mensagem,TipoLog tipoLog)
        {
            Console.WriteLine("Log gravado com");
        }
    }

    class LOG4NETAdapter:ILOG
    {
        public void RegistrarLog(string mensagem, TipoLog tipoLog)
        {
              switch (tipoLog)
            {
                //case TipoLog.Erro: (new LOG4NET()).Write(mensagem, "Erro");
                //case TipoLog.Warning: (new LOG4NET()).Write(mensagem, "Aviso");
                //default: throw new Exception("Tipo de erro não exite");
            }
            
        }
    }


    class LOG4NET
    {
        public void Write(String texto, string TipoErro)
        {
            Console.WriteLine("Log gravado");
        }
    }
}
