using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;

namespace MBCorpHealthTest.Dominio.Servicos
{
    public class ServicoDeGeracaoCredencial:IServicoDeGeracaoCredencial
    {
        public Credencial Gerar(Paciente paciente)
        {
            return new Credencial (paciente.Email,paciente.CPF);
        }
    }
}