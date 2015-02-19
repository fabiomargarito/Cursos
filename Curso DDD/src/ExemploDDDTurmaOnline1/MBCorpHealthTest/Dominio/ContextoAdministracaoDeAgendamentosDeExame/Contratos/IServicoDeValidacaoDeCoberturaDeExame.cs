using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    public interface IServicoDeValidacaoDeCoberturaDeExame
    {
        bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente);
    }
}