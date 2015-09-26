using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;

namespace JBSMedical.AgendamentoBoundedContext.Aplicacacao.Contratos
{
    public interface IServicoDeCadastramentoDeAgendamento
    {
        bool Cadastrar(Agendamento agendamento);
    }
}