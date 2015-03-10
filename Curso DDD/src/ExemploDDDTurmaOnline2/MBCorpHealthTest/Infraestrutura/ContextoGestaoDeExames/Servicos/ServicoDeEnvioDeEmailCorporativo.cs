using MBCorpHealthTest.Infraestrutura.Contratos;

namespace MBCorpHealthTest.Infraestrutura.Servicos
{
    public class ServicoDeEnvioDeEmailCorporativoFake : IServicoDeEnvioDeEmail
    {
        public bool EnviarEmail(string de, string para, string assunto, string mensagem)
        {
            return true;
        }
    }
}