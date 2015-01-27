using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
{
    public   interface IServicoDeValidacaoDeCoberturaDeExame
    {
        bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente);
    }
}