namespace ExemploModulo3InjecaoDeDependencia
{
    public class Log : ILog
    {
        public string Registrar(TipoLog informacao,string mensagem)
        {
            return "IDLog";
        }        
    }



    public class LogNovo : ILog
    {
        public string Registrar(TipoLog informacao, string mensagem)
        {
            return "IDLog Logo Novo";
        }
    }
}