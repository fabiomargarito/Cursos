using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Dominio.Contratos.Repositorios
{
    public interface IAgendamentos
    {
        bool Cadastrar(Agendamento agendamento);
    }
}