using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthUnitTest
{
    [TestClass]
    public class Infraestrutura
    {
        [TestMethod]
        public void DeveRetornarResultadosDeUmAgendamentoParaUmCliente()
        {
            //Arrange
            IRepositorioAgendamento repositorioAgendamento = new RepositorioAgendamentoMock();

            //Act
            List<Resultado> retorno = repositorioAgendamento.RetornarResultadosPorCPFDoPaciente("28440492123");

            //Assert
            Assert.IsTrue(retorno.Count > 0);
        }

        [TestMethod]
        public void DeveGravarUmPaciente()
        {
            //Arrange
            IRepositorio<Paciente> repositorioPaciente = new RepositorioPacienteMock();

            //Act
            Paciente paciente = new Paciente("fabio", "1234");
            paciente.DefinirPlanoDeSaude(new PlanoDeSaude());

            var retorno = repositorioPaciente.Gravar(paciente);

            //Assert
            Assert.IsTrue(retorno);
        }
    }
}
