using System;

namespace AplicacaoParaRefactoringCompraEVendaDeAcoes
{
    public class Corretora
    {
        public double CustoOperacao;
        public Boolean RegistrarCompraAcao(Acao acao, Cliente cliente)
        {
            CustoOperacao = acao.PrAcao * acao.Quantidade;
            CustoOperacao += 10;
            CustoOperacao += CustoOperacao * 0.003;
            CustoOperacao += CustoOperacao * 0.000325;

           return GravarAcaoNaCarteira(acao.Codigo, acao.Valor, acao.Quantidade, acao.CustoOperacao, cliente, 1);
        }


        public Boolean RegistrarVendaAcao(Acao acao, Cliente cliente)
        {
            CustoOperacao = acao.PrAcao * acao.Quantidade;
            CustoOperacao += 10;
            CustoOperacao += CustoOperacao * 0.003;
            CustoOperacao += CustoOperacao * 0.000325;

            return GravarAcaoNaCarteira(acao.Codigo, acao.Valor, acao.Quantidade, CustoOperacao, cliente, 2);

        }


        public Boolean GravarAcaoNaCarteira(string codigoAcao, double valorAcao, int quantidade, double ValorTotal, Cliente cliente, int tpOperacao)
        {
            Operacao operacao = new Operacao();

            operacao.Acao = new Acao { Codigo = codigoAcao, CustoOperacao = ValorTotal, Quantidade = quantidade, PrAcao = valorAcao, Valor = valorAcao };
            operacao.Cliente = cliente;
            operacao.TipoOperacao = tpOperacao;
            return (new DalOperacao()).gravar(operacao);
        }
    }
}