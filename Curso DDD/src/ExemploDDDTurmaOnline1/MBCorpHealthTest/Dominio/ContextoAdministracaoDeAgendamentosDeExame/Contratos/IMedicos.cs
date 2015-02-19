using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    public interface IMedicos
    {
        Medico PesquisarMedicoPorCRMEEstado(string crm, string estado);
    }
}