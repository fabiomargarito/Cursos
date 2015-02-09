using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio.EventosAgendamentoCriado;

namespace MBCorpHealthTest.Aplicacao
{
    public   class ServicoDeAgendamento
    {        
        protected readonly IServicoDeGeracaoCredencial _servicoDeGeracaoCredencial;

        public   ServicoDeAgendamento(IServicoDeGeracaoCredencial servicoDeGeracaoCredencial)
        {
     
            _servicoDeGeracaoCredencial = servicoDeGeracaoCredencial;
        }

        public virtual  Agendamento CadastrarAgendamento(Agendamento agendamento)
        {
            //Persistir na Base
            agendamento.Credencial = _servicoDeGeracaoCredencial.Gerar(agendamento.Paciente);
            

            //Disparar Eventos
            EventosDoDominio.Disparar(new AgendamentoCriado(agendamento));
            

            return agendamento;
        }
    }
}