using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;

namespace JBSMedical.AgendamentoBoundedContext.Dominio.Contratos.Repositorios
{
    public interface IAgendamentos
    {
        bool Cadastrar(Agendamento agendamento);
    }
}