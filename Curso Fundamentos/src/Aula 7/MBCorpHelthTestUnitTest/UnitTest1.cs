using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using MBCorpHealthUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHelthTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGravarUmPaciente()
        {
            //Arrange
            IRepositorio<Paciente> pacientes = new PacientesFake();

            //Act
            var retorno = pacientes.Gravar(new Paciente("fabio", "12345"));

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveExcluirUmPaciente()
        {
            //Arrange
            IRepositorio<Paciente> pacientes = new PacientesSQL();

            //Act
            var retorno = pacientes.Excluir(new Paciente("fabio", "12345"));

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveRetornarPacientesPorTrechoDoNome()
        {
            //Arrange
            IRepositorio<Paciente> pacientes = new PacientesSQL();

            //Act
            var retorno = pacientes.ConsultarPorTrechoNome("fabio");

            //Assert
            Assert.IsTrue(retorno.Count>0);
        }

        [TestMethod]
        public void DeveGravarUmCartao()
        {
            //Arrange
            IRepositorio<Cartao> cartoes = new Cartoes();

            //Act
            var retorno = cartoes.Gravar(new Cartao("123", "nome", "1234"));

            //Assert
            Assert.IsTrue(retorno);

        }
    }
}
