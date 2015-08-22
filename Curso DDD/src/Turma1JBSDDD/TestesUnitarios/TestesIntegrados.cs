using System;
using System.Text;
using System.Collections.Generic;
using JBSHealthCare.Aplicacao.Servico;
using JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Fabrica;
using JBSHealthCare.Dominio.Fabrica.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Infraestrutura.Repositorio;
using JBSHealthCare.Infraestrutura.Repositorio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.View.ViewModels;
using JBSHealthCare.View.ViewModels.BoundedContextGestaoDeAgendamentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{    

    /// <summary>
    /// Summary description for TestesIntegrados
    /// </summary>
    [TestClass]
    public class TestesIntegrados
    {

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ComoAtendenteEuQueroCriarUmAgendamento()
        {

            //arrange
            FabricaDeAgendamento fabricaDeAgendamento = new FabricaDeAgendamento();

            //act
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel { cpf = "2345", crm = "1234", numeroCID = "21-9" };


            
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new AgendamentosFake());
            var retorno = servicoDeAgendamento.CriarAgendamento(agendamentoViewModel);
                      
            
            

        }


        public TestesIntegrados()
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
    }
}
