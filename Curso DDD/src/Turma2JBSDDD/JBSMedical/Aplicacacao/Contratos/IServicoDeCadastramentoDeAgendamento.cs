using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Aplicacacao.Contratos
{
    public interface IServicoDeCadastramentoDeAgendamento
    {
        bool Cadastrar(Agendamento agendamento);
    }
}