using JBSHealthCare.Dominio.Entidade;

namespace JBSHealthCare.Dominio.Interface.Repositorio
{
    public interface IAgendamentos
    {
        bool Gravar(Agendamento agendamento);
    }
}