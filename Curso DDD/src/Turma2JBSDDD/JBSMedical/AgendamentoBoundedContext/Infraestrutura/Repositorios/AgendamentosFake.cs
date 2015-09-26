using JBSMedical.AgendamentoBoundedContext.Dominio.Contratos.Repositorios;
using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;

namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Repositorios
{
    public class AgendamentosFake : IAgendamentos
    {
        public bool Cadastrar(Agendamento agendamento)
        {
            return true;
        }
    }
}