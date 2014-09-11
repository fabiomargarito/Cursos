using System;
using FluentNHibernate.Testing.Values;
using MBCORPHealthTests;
using MBCORPHealthTests.Dominio.Servico;
using MBCORPHealthTests.View;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGravarPaciente()
        {
            
            UnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IRepositorio<Paciente>,RepositorioPaciente>();
            
            //Arrange
            ServicoPersistenciaPaciente servicoPersistenciaPaciente = unityContainer.Resolve<ServicoPersistenciaPaciente>();
            
            
            //Act
            var paciente = new PacienteDTO();
            paciente.CPF = "1234";
            paciente.Nome = "fabio Margarito";
            paciente.Endereco = new Endereco("123","rua teste","sem complemento","Jardins","são paulo","SP");
            paciente.PlanoSaude = new PlanoSaude("Bradesco","123");


            var retorno = servicoPersistenciaPaciente.Gravar(paciente);

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveRetornarTodosOsPacientes()
        {
            //Arrange
            IRepositorio<Paciente> repositorioPaciente = new RepositorioPaciente();

            //Act
            
            var retorno = repositorioPaciente.ListarTodos();

            //Assert
            Assert.IsTrue(retorno.Count>1);
            
        }

        [TestMethod]
        public void DeveGravarUmMedico()
        {
            //Arrange
            IRepositorio<Medico> repositorioMedico = new RepositorioMedicoNHibernate();

            var servicoPersistenciaMedico = new ServicoPersistenciaMedico(repositorioMedico);

            //Act
            var medico= new MedicoDto();
            medico.CRM = Guid.NewGuid().ToString();
            medico.NOME = "fabio";

            var retorno = servicoPersistenciaMedico.Gravar(medico);

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveRetornarTodosOsMedicos()
        {
            //Arrange
            IRepositorio<Medico> repositorioMedico = new RepositorioMedicoNHibernate();

            //Act

            var retorno = repositorioMedico.ListarTodos();

            //Assert
            Assert.IsTrue(retorno.Count > 1);

        }


        
    
    }
}
