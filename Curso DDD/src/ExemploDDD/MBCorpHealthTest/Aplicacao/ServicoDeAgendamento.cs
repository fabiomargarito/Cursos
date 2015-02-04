using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.EventosDeDominio;

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