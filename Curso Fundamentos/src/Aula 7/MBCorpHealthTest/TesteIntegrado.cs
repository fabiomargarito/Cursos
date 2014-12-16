using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos;
using MBCorpHealth.Infraestrutura.Repositorio;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;

namespace MBCorpHealthTest
{
    [TestClass]
    public class TesteIntegrado
    {
        [TestMethod]
        public void DeveGravarUmPacienteNaBaseIntegrado()
        {
            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());

            //Arrange
            Paciente paciente = new Paciente("Fabio Margarito Martins de Barros", "12345623423");
            IRepositorioPaciente repositorioPaciente = unityContainer.Resolve<IRepositorioPaciente>();

            //Act
            var retorno = repositorioPaciente.Gravar(paciente);

            //Assert
            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void DeveListarPacientesPorTrechoDoNomeIntegrado()
        {
            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());

            //Arrange
            List<Paciente> pacientes = new List<Paciente>();
            IRepositorioPaciente repositorioPaciente = unityContainer.Resolve<IRepositorioPaciente>();

            //Act
            pacientes = repositorioPaciente.RetornarPorTrechoNome("fa");

            //Assert
            Assert.IsTrue(pacientes.Count > 0);


        }

        [TestMethod]
        public void DeveExcluirUmPacienteIntegrado()
        {
            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IRepositorioPaciente, RepositorioPaciente>();
            unityContainer.RegisterInstance<ISession>(ConfiguracaoNHibernate.Criar().OpenSession());

            //Arrange            
            IRepositorioPaciente repositorioPaciente = unityContainer.Resolve<IRepositorioPaciente>();
            Paciente paciente = new Paciente("Fabio Margarito", "23434343");

            //Act
            var retorno = repositorioPaciente.Excluir(paciente);

            //Assert
            Assert.IsTrue(retorno);


        }
    }
}
