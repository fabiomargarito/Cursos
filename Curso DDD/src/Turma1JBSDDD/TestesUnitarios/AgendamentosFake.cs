using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Interface.Repositorio;

namespace TestesUnitarios
{
    public class AgendamentosFake:IAgendamentos
    {
        public bool Gravar(Agendamento agendamento)
        {
            return true;
        }
    }
}