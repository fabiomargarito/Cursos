namespace MBCorpHealth.Dominio
{
    public class Cartao
    {
        public Cartao(string numeroDoCartao, string nomeConformeEscritoNoCartao, string codigoDeSeguranca)
        {
            NumeroDoCartao = numeroDoCartao;
            NomeConformeEscritoNoCartao = nomeConformeEscritoNoCartao;
            CodigoDeSeguranca = codigoDeSeguranca;
        }

        public Cartao()
        {
        }

        public virtual string NumeroDoCartao {  get; protected set; }
        public virtual string NomeConformeEscritoNoCartao {  get; protected set; }
        public virtual string CodigoDeSeguranca {  get; protected set; }        
    }



}
