using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCorpHealth
{
    public interface IServicoDeEnvioDeEmail
    {
        void EnviarEmail(string emailOrigem, string emailDestino, string assunto, string message);
    }

    public class ServicoDeEnvioDeEmailCorporativo:IServicoDeEnvioDeEmail
    {
        public void EnviarEmail(string emailOrigem, string emailDestino, string assunto, string message)
        {            
        }
    }

    public interface IServicoDeEnvioSMS
    {
        void EnviarSMS(string DDD, string telefone, string mensagem);
    }

    public class ServicoDeEnvioSMSCorporativo:IServicoDeEnvioSMS
    {
        public void EnviarSMS(string DDD, string telefone, string mensagem)
        {
            
        }
    }
}
