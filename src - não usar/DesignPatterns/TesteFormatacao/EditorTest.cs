using CommandFormat;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExercicioDecorator;

namespace TesteFormatacao
{
    
    
    /// <summary>
    ///This is a test class for EditorTest and is intended
    ///to contain all EditorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EditorTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FormatarTudo
        ///</summary>
        [TestMethod()]
        public void FormatarTudoTest()
        {
            Texto textoHTML = new TextoHTML();
            textoHTML.texto = "Curso de Fundamentos em Arquitetura de Software";

            TipoFormatacao bold = new Bold(textoHTML);
            TipoFormatacao center = new Center(bold);
            Console.WriteLine(center.Formatar());

            //<center><bold>Curso de Fundamentos em Arquitetura de Software</bold></center>
        }
    }
}
