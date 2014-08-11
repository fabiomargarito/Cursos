using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;
using AplicacaoParaRefactoringCompraEVendaDeAcoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeBrokerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetornarListaDeOperacoes()
        {
                var cliente = new Cliente("123.133.132-23","Cliente de teste");                

                DalOperacao carteira = new DalOperacao();
            var acoes = carteira.RetornarOperacoes(cliente);

            Assert.IsTrue(acoes.Count > 0);
        }

        [TestMethod]
        public void DeveGravarDadosDoCliente()
        {
            //arrange
            var cliente = new Cliente("123.133.132-23", "Cliente de teste");
            

            //act
            
            var retorno = (new ServicoDeCliente()).GravarCliente(cliente);

            //assert

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void DeveRetornarCotacaoDeUmaAcao()
        {
            //arrange
            Acao acao = new Acao();

            //act
            var cotacao = acao.RetornarCotacao("PETR3");

            //assert
            Assert.IsTrue(cotacao.Valor != 0);

        }


        [TestMethod]
        public void DeveGravarUmaCotacao()
        {
            //arrange

            var cotacao = new Cotacao(10, new Acao {Codigo = "PETR4"});
            IRepositorio<Cotacao> RepositorioCotacao = new RepositorioCotacaoMock();


            //act
            var retorno = RepositorioCotacao.Gravar(cotacao);
            
            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveRetornarUmaCotacaoParaUmCodigoDeAcaoInformado()
        {
            //arrange
            
            IRepositorio<Cotacao> RepositorioCotacao = new RepositorioCotacaoMock();

            //act
            IList<Cotacao> retorno = RepositorioCotacao.RetornarPorCodigo("PETR4");

            //assert
            Assert.IsTrue(retorno.Count > 0);
        }
    }

    public interface IRepositorio<T>
    {
        bool Gravar(T entidade);
        IList<T> RetornarPorCodigo(string codigo);
    }



    public class RepositorioCotacaoMock:IRepositorio<Cotacao>
    {
        public bool Gravar(Cotacao cotacao)
        {
            return true;
        }
        public IList<Cotacao> RetornarPorCodigo(string codigoDaAcao)
        {
            IList<Cotacao> cotacoes = new List<Cotacao>();
            cotacoes.Add(new Cotacao(10, new Acao{Codigo = "PETR4"}));

            return cotacoes;
        }
    }
}
