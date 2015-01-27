namespace MBCorpHealthTest.Dominio.Contratos
{
    public   interface IServicoDeEnvioEmail
    {
        void Enviar(string de, string para, string asssunto, string mensagem);
    }
}