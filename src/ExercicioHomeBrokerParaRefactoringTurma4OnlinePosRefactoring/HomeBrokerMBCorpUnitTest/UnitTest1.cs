using System;
using HomeBrokerMBCorp.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeBrokerMBCorpUnitTest
{
    [TestClass]
    public class HomeBrokerMBCorpUnitTes
    {
        [TestMethod]
        public void DadoAAcaoPETR4RetornarACotacao()
        {
            //Arrange
            Cotacao cotacao = new Cotacao();

            //Act

            cotacao = cotacao.RetornarCotacao(new Acao {Codigo = "PETR4"});


            //Assert
            Assert.IsTrue(cotacao.Preco == 10);
        }

        [TestMethod]
        public void DeveInserirUmaAcaoNaListaDeAcoesDaEmpresa()
        {
            //arrange
            Empresa empresa = new Empresa("124", "Razao Social de Teste");

            //act
            empresa.AdicionarAcao(new Acao{Codigo = "PETR3"});

            //assert
            Assert.IsTrue(empresa.Acoes.Count>0);

        }

        [TestMethod]
        public void DeveInserirUmaOperacaoNaCarteira()
        {
            //arrange
            Carteira carteira = new Carteira();
            

            //act
            var corretora = new Corretora("123","Agora");
            var operacao = new Operacao(new Acao{Codigo = "PETR4"},10,10,new Usuario("12","fabio"),corretora,TipoOperacao.Compra);

            carteira.AdicionarOperacao(operacao);

            //Assert
            Assert.IsTrue(carteira.ListarOperacoes().Count>0);

        }

        [TestMethod]
        public void DeveRemoverUmaOperacaoDaCarteira()
        {
            //arrange
            Carteira carteira = new Carteira();


            //act
            var corretora = new Corretora("123", "Agora");
            var operacao = new Operacao(new Acao { Codigo = "PETR4" }, 10, 10, new Usuario("12", "fabio"), corretora, TipoOperacao.Compra);

            carteira.AdicionarOperacao(operacao);
            carteira.RemoverOperacao(operacao);

            //Assert
            Assert.IsTrue(carteira.ListarOperacoes().Count == 0);

        }

        [TestMethod]
        public void DeveCriarUmaOperacao()
        {
            //arrange
            var corretora = new Corretora("123", "Agora");
            


            //act
            var operacao = new Operacao(new Acao { Codigo = "PETR4" }, 10, 10, new Usuario("12", "fabio"), corretora, TipoOperacao.Compra);
            

            //Assert
            Assert.IsTrue(operacao!=null);

        }

        [TestMethod]
        public void DeveCalcularCorretagemDaCorretoraAlpesParaUmaOperacao()
        {
            //arrange
            IEstrategiaCorretagem estrategiaCorretagem = new EstrategiaCustoCorretagemAlpes();

            //act
            var valorCorretagem = estrategiaCorretagem.CalcularCorretagem(100);

            //assert
            Assert.IsTrue(valorCorretagem == 20);


        }

    }
}
