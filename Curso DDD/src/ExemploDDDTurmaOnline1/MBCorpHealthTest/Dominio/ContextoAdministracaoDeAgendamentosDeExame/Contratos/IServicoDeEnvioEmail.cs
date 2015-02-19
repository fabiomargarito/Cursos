namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    public interface IServicoDeEnvioEmail
    {
        void Enviar(string de, string para, string asssunto, string mensagem);
    }
}