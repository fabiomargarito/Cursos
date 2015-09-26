using JBSMedical.AgendamentoBoundedContext.Aplicacacao.Contratos;
using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;
using JBSMedical.CadastrosBoundedContext.Dominio.Eventos;
using JBSMedical.CadastrosBoundedContext.Infraestrutura.Contratos;

namespace JBSMedical.AgendamentoBoundedContext.Aplicacacao.Servicos
{
    public class ServicoDeCadastramentoDeAgendamentoFake : IServicoDeCadastramentoDeAgendamento
    {
        public ServicoDeCadastramentoDeAgendamentoFake(ISessionORM sessao)
        {
            
        }

        public bool Cadastrar(Agendamento agendamento)
        {
            EventosDoDominio.Disparar(new AgendamentoCriado(agendamento));
            return true;
        }
    }
}