using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    [TestClass]
    public class TestesUnitariosRepositorioAtendente
    {
        [TestMethod]
        public void ComoAdministradorQueroSelecionarUmAtendentePorCPF()
        {
            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendenteFake();

            //Act
            Atendente atendente = repositorioAtendente.retornarPorCPF("12334542312");

            //Assert

            Assert.IsTrue(atendente.Nome == "Fabio Margarito");
            Assert.IsTrue(atendente.CPF == "12334542312");

        }

        [TestMethod]
        public void ComoAdministradorQueroGravarUmAntendente() {
            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendenteFake();
            Atendente atendente = new Atendente("12334542312", "Fabio Margarito", DateTime.Now);

            //Act
            bool retorno = repositorioAtendente.Gravar(atendente);

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void ComoAdministradorQueroExcluirUmAntendente() {

            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendenteFake();
            Atendente atendente = new Atendente("12334542312", "Fabio Margarito", DateTime.Now);

            //Act
            bool retorno = repositorioAtendente.Excluir(atendente);

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void ComoAdministradorQueroAListaDeTodosOsAtendentes() {
            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendenteFake();

            //Act
            IList<Atendente> atendentes = repositorioAtendente.retornarTodos();

            //Assert
            Assert.IsTrue(atendentes.Count>0);


        }

    }
}
