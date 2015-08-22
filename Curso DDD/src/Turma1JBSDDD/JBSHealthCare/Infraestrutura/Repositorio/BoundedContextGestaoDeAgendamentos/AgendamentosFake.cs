using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Interface.Repositorio.BoundedContextGestaoDeAgendamentos;

namespace JBSHealthCare.Infraestrutura.Repositorio.BoundedContextGestaoDeAgendamentos
{
    public class AgendamentosFake:IAgendamentos
    {
        public bool Gravar(Agendamento agendamento)
        {
            return true;
        }
    }
}