namespace AplicacaoParaRefactoringCompraEVendaDeAcoes
{
    public class Corretora
    {
        public double CustoOperacao;
        public void RegistrarCompraAcao(Acao acao, Cliente cliente)
        {
            CustoOperacao = acao.PrAcao * acao.Quantidade;
            CustoOperacao += 10;
            CustoOperacao += CustoOperacao * 0.003;
            CustoOperacao += CustoOperacao * 0.000325;

            GravarAcaoNaCarteira(acao.Codigo, acao.Valor, acao.Quantidade, acao.CustoOperacao, cliente, 1);
        }


        public void RegistrarVendaAcao(Acao acao, Cliente cliente)
        {
            CustoOperacao = acao.PrAcao * acao.Quantidade;
            CustoOperacao += 10;
            CustoOperacao += CustoOperacao * 0.003;
            CustoOperacao += CustoOperacao * 0.000325;

            GravarAcaoNaCarteira(acao.Codigo, acao.Valor, acao.Quantidade, CustoOperacao, cliente, 2);

        }


        public void GravarAcaoNaCarteira(string codigoAcao, double valorAcao, int quantidade, double ValorTotal, Cliente cliente, int tpOperacao)
        {
            Carteira carteira = new Carteira();

            carteira.Acao = new Acao { Codigo = codigoAcao, CustoOperacao = ValorTotal, Quantidade = quantidade, PrAcao = valorAcao, Valor = valorAcao };
            carteira.Cliente = cliente;
            carteira.TipoOperacao = tpOperacao;
            (new DalCarteira()).gravar(carteira);
        }
    }
}