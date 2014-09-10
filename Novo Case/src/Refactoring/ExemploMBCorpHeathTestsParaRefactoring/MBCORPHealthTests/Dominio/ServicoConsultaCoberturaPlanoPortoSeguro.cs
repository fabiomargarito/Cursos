using System;

namespace MBCORPHealthTests
{
    public class ServicoConsultaCoberturaPlanoPortoSeguro:IServicoConsultaCoberturaPlano {
        public bool ConsultarCoberturaParaOExame(TipoExame tipoExame)
        {
            //Em um caso real, consultaríamos o serviço disponibilizado pela Porto Seguro
            return true;
        }

        public bool ConsultarTipoDePlanoDoPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}