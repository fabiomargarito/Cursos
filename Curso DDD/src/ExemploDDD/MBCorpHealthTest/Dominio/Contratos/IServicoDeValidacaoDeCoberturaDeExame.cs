public interface IServicoDeValidacaoDeCoberturaDeExame
{
    bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente);
}