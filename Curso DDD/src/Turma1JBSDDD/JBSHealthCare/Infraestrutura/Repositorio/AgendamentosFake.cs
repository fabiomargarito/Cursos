using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Interface.Repositorio;

namespace JBSHealthCare.Infraestrutura.Repositorio
{
    public class AgendamentosFake:IAgendamentos
    {
        public bool Gravar(Agendamento agendamento)
        {
            return true;
        }
    }
}