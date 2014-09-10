namespace MBCORPHealthTests
{
    public  interface IServicoConsultaCoberturaPlano
    {
        bool ConsultarCoberturaParaOExame(TipoExame tipoExame);
        bool ConsultarTipoDePlanoDoPaciente(Paciente paciente);
    }
}