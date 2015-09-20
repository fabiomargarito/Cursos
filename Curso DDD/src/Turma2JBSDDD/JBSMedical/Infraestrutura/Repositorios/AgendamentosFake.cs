using JBSMedical.Dominio.Contratos.Repositorios;
using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Infraestrutura.Repositorios
{
    public class AgendamentosFake : IAgendamentos
    {
        public bool Cadastrar(Agendamento agendamento)
        {
            return true;
        }
    }
}