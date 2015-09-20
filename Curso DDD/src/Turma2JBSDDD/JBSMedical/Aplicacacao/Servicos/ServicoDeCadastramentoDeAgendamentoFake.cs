using JBSMedical.Aplicacacao.Contratos;
using JBSMedical.Dominio.Entidades;
using JBSMedical.Dominio.Eventos;
using JBSMedical.Infraestrutura.Contratos;

namespace JBSMedical.Aplicacacao.Servicos
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