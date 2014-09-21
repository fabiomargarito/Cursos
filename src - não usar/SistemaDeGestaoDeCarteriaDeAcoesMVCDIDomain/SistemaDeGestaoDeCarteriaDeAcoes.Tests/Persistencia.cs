using System;
using System.Text;
using System.Collections.Generic;
using Domain;
using Infraestrutura;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeGestaoDeCarteriaDeAcoes.Controllers;

namespace SistemaDeGestaoDeCarteriaDeAcoes.Tests
{
    /// <summary>
    /// Summary description for Persistencia
    /// </summary>
    [TestClass]
    public class Persistencia
    {
        public Persistencia()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void DevePersistirUmaAcao()
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<IRepositorio<Acao>, RepositorioAcaoFake>();

            //arrange
            var empresa = new Empresa {CNPJEmpresa = "000.222.333/0001-20", Razaosocial = "Razao Teste"};
            var acao = new Acao {Codigo = "PETR", Empresa =empresa };

            ServicoPersistenciaAcao servicoPersistenciaAcao = unityContainer.Resolve<ServicoPersistenciaAcao>();
            //act and assert

            Assert.IsTrue(servicoPersistenciaAcao.Gravar(acao));

        }        
    }
}
