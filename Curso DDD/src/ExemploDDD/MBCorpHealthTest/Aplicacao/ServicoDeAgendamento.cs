public class ServicoDeAgendamento
{
    private readonly IServicoDeEnvioEmail _servicoDeEnvioEmail;

    public ServicoDeAgendamento(IServicoDeEnvioEmail servicoDeEnvioEmail)
    {
        _servicoDeEnvioEmail = servicoDeEnvioEmail;
    }

    public Agendamento CadastrarAgendamento(Agendamento agendamento)
    {
        //Persistir na Base

        //Enviar Email
        _servicoDeEnvioEmail.Enviar("mbcorp@mbcorp.com.br", agendamento.Paciente.Email, "Agendamento Confirmado", "Mensagem para o paciente");

        return agendamento;
    }
}