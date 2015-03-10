namespace MBCorpHealthTest.Infraestrutura.Contratos
{
    public interface IServicoDeEnvioDeSMS
    {
        bool Enviar(string DDD, string numeroTelefone, string mensagem);

    }
}