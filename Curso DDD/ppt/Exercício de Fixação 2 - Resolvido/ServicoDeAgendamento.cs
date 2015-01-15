namespace MBCorpHealth.Dominio
{
    public class ServicoDeAgendamento
    {
        private IServicoDeEnvioDeEmail servicoDeEnvioDeEmail;        


        public ServicoDeAgendamento(IServicoDeEnvioDeEmail servicoDeEnvioDeEmail)
        {
            this.servicoDeEnvioDeEmail = servicoDeEnvioDeEmail;
            
        }

        public void CadastrarAgendamento(Agendamento agendamento)
        {
            //gravar --vermos mais adiante
            servicoDeEnvioDeEmail.EnviarEmail("from",agendamento.Paciente.Email,"Confirmação de Agendamento","texto");                        
        }
    }
}