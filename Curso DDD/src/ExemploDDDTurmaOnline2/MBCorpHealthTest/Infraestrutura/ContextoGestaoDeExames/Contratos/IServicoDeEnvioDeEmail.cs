namespace MBCorpHealthTest.Infraestrutura.Contratos
{
    public interface IServicoDeEnvioDeEmail
    {
        bool EnviarEmail(string de, string para, string assunto, string mensagem);
    }
}