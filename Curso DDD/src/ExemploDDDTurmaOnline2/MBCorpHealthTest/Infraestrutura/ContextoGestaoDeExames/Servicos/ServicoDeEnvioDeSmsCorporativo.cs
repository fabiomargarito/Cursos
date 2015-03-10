using MBCorpHealthTest.Infraestrutura.Contratos;

namespace MBCorpHealthTest.Infraestrutura.Servicos
{
    public class ServicoDeEnvioDeSmsCorporativoFake : IServicoDeEnvioDeSMS
    {
        public bool Enviar(string DDD, string numeroTelefone, string mensagem)
        {
            return true;
        }
    }
}