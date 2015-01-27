using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;

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