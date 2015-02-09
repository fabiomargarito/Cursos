using System.Linq;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;
using MBCorpHealthTest.Dominio.Fabricas;
using NHibernate;
using NHibernate.Linq;

namespace MBCorpHealthTest.Infraestrutura.ContextoAdministracaoDeAgendamentosDeExame.Repositorios
{
    public interface IAgendamentos
    {
        Agendamento pesquisarPorPaciente(Credencial credencial);
        bool Gravar(Agendamento agendamento);
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
                _session.Query<Agendamento>().FirstOrDefault(ag => ag.Credencial.Senha == credencial.Senha && ag.Credencial.User == credencial.User);
        }

        public bool Gravar(Agendamento agendamento)
        {
      
                _session.SaveOrUpdate(agendamento);
                _session.Flush();
          
            return true;
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
            agendamento.Exames.First().EmitirLaudo(new Laudo("teste"));

            return agendamento;
        }

        public bool Gravar(Agendamento agendamento)
        {
            return true;
        }
    }
}
