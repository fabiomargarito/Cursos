using System;

namespace MBCORPHealthTests
{
    public class ServicoConsultaCoberturaPlanoPortoSeguro:IServicoConsultaCoberturaPlano {
        public ServicoConsultaCoberturaPlanoPortoSeguro()
        {
        }

        public virtual bool ConsultarCoberturaParaOExame(TipoExame tipoExame)
        {
            //Em um caso real, consultaríamos o serviço disponibilizado pela Porto Seguro
            return true;
        }


    }
}