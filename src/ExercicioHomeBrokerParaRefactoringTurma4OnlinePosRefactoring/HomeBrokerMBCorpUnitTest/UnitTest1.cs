using System;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Dominio.Servicos;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

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
            //Assert.IsTrue(empresa.Acoes.Count>0);

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

        [TestMethod]
        public void DeveGravarUmaEmpresaInformadaPeloUsuario() {

            //Arrange
            IRepositorio<Empresa> repositorioEmpresa = new RepositorioEmpresaFake();
            
            //Act
            repositorioEmpresa.Gravar(new Empresa("1234", "RazaoSocial"));

            //Assert
            Assert.IsTrue(repositorioEmpresa.RetornarPorID("1234").RazaoSocial == "RazaoSocial");

        }

        [TestMethod]
        public void DeveRetornarUmaListaDeEmpresasCadastradas() { 
            //Arrange
            IRepositorio<Empresa> repositorioEmpresa = new RepositorioEmpresaFake();

           //act
            var empresas = repositorioEmpresa.ListarTodos();

            //Assert
            Assert.IsTrue(empresas.Count >1);
            
        }



        [TestMethod]
        public void DeveRetornarUmaListaDeUsuariosCadastrados()
        {
            //Arrange
            IRepositorio<Usuario> repositorioUsuario = new RepositorioUsuarioFake();

            //act
            var usuarios = repositorioUsuario.ListarTodos();

            //Assert
            Assert.IsTrue(usuarios.Count > 1);

        }

        [TestMethod]
        public void DeveGravarUmUsuario()
        {
            
            //Arrange
            IRepositorio<Usuario> repositorioUsuario = new RepositorioUsuarioFake();

            //Act
            repositorioUsuario.Gravar(new Usuario("1234","Fabio Margarito"));

            //Assert
            Assert.IsTrue(repositorioUsuario.RetornarPorID("1234").Nome == "Fabio Margarito");

        }

        [TestMethod]
        public void DeveGravarUmUsuarioComUsuarioDoServico()
        {

            //Arrange
            UsuarioService usuarioService = new UsuarioService();
            

            //Act
            usuarioService.Gravar("1234", "fabio margarito",new RepositorioUsuarioFake());

            //Assert
            Assert.IsTrue( (new RepositorioUsuarioFake()).RetornarPorID("1234").Nome == "Fabio Margarito");

        }

       


      


      


    }
}
