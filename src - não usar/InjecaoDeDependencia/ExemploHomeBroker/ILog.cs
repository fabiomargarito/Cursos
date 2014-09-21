namespace ExemploModulo3InjecaoDeDependencia
{
    public interface ILog
    {
        string Registrar(TipoLog informacao, string mensagem);
    }
}