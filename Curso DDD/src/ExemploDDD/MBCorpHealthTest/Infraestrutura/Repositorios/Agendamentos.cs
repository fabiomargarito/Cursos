using System.Linq;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.Fabricas;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealthTestTest
{
    public interface IAgendamentos
    {
        Agendamento pesquisarPorPaciente(Credencial credencial);
    }

    public class Agendamentos : IAgendamentos
    {
        private readonly ISession _session;

        public Agendamentos(ISession session)
        {
            _session = session;
        }

        public Agendamento pesquisarPorPaciente(Credencial credencial)
        {
            return
                _session.Query<Agendamento>().SingleOrDefault(ag => ag.Credencial.Senha == credencial.Senha && ag.Credencial.User == credencial.User);




        }
    }

    public class AgendamentosFake : IAgendamentos
    {
        public Agendamento pesquisarPorPaciente(Credencial credencial)
        {
            Agendamento agendamento =
                (new FabricaDeAgendamento()).InformarPaciente("123")
                    .InformarMedicoSolicitante("12345")
                    .InformarAtendente("12345")
                    .Criar();

            agendamento.AdicionarExame(new Exame(new TipoExame("1234", "sangue", 120)));
            agendamento.Exames[0].EmitirLaudo(new Laudo("teste"));

            return agendamento;
        }
    }
}
