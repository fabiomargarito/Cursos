using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Infraestrutura
{
    public class ServicoDeValidacaoDeCoberturaDeExame : IServicoDeValidacaoDeCoberturaDeExame
    {
        public bool VerificarCoberturaDoExame(TipoExame tipoExame, Paciente paciente)
        {
            return true;
        }
    }
}