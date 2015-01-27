using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
{
    public interface IMedicos
    {
        Medico PesquisarMedicoPorCRMEEstado(string crm, string estado);
    }
}