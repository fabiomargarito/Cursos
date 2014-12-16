using System;
using System.Collections.Generic;
using MBCorpHealth.Aplicacao.Servico;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio.Fakes;
using MBCorpHealth.View.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTest
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void DeveGravarUmPacienteNaBase()
        {
            
            //Arrange
            ServicoDePaciente servicoDePaciente = new ServicoDePaciente(new RepositorioPacienteFake());

            //Act
            var retorno = servicoDePaciente.Gravar(new PacienteViewModel{Nome = "fabio",Cpf = "123456677"});

            //Assert
            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void DeveListarPacientesPorTrechoDoNome()
        {
            //Arrange
            List<Paciente> pacientes = new List<Paciente>();
            IRepositorioPaciente repositorioPaciente = new RepositorioPacienteFake();

            //Act
            pacientes = repositorioPaciente.RetornarPorTrechoNome("fa");

           //Assert
            Assert.IsTrue(pacientes.Count>0);


        }

        [TestMethod]
        public void DeveExcluirUmPaciente()
        {
            //Arrange            
            IRepositorioPaciente repositorioPaciente = new RepositorioPacienteFake();
            Paciente paciente = new Paciente("Fabio Margarito","23434343");
            
            //Act
            var retorno = repositorioPaciente.Excluir(paciente);

            //Assert
            Assert.IsTrue(retorno);


        }

    }
}
