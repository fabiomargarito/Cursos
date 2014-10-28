using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealth.Infraestrutura.Repositorio;
using MBCorpHealthUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;

namespace MBCorpHealthIntegratedTest
{
    [TestClass]
    public class UnitTest1
    {
        private static ISession _session;

        [AssemblyInitialize]
        public static void CriarSessao(TestContext textTestContext)
        {
            _session = ConfiguracaoNHibernate.Criar().OpenSession();
        }


        [AssemblyCleanup]
        public static void FecharSessao()
        {
            _session.Dispose();
        }



        [TestMethod]
        public void DeveGravarUmCartao()
        {
         
                //Arrange
                IRepositorio<Cartao> repositorioCartao = new RepositorioCartao(_session);
                //Act
                var retorno = repositorioCartao.Gravar(new Cartao("123", "fabio m m barros", "123"));
                //Assert
                Assert.IsTrue(retorno);
        
        }


        [TestMethod]
        public void DeveRetornarTodosOsCartoes()
        {
         
                //Arrange
                IRepositorio<Cartao> repositorioCartao = new RepositorioCartao(_session);
                //Act
                List<Cartao> retorno = repositorioCartao.RetornarTodos();
                //Assert
                Assert.IsTrue(retorno.Count > 0);
           
        }

    }
}
