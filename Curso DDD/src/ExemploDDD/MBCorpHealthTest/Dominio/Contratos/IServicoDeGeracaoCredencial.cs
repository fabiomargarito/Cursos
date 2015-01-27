using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
{
    public   interface IServicoDeGeracaoCredencial
    {
        Credencial Gerar(Paciente paciente);
    }
}