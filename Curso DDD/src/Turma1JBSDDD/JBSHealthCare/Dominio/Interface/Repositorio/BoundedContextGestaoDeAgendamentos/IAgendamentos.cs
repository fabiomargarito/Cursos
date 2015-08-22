using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;

namespace JBSHealthCare.Dominio.Interface.Repositorio.BoundedContextGestaoDeAgendamentos
{
    public interface IAgendamentos
    {
        bool Gravar(Agendamento agendamento);
    }
}