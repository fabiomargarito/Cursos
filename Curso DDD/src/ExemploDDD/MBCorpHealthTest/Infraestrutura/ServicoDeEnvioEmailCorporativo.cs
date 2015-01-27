using MBCorpHealthTest.Dominio.Contratos;

namespace MBCorpHealthTest.Infraestrutura
{
    public   class ServicoDeEnvioEmailCorporativo : IServicoDeEnvioEmail
    {
        public virtual  void Enviar(string de, string para, string asssunto, string mensagem)
        {

        }
    }
}