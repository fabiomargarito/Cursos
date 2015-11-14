using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NHibernate;
using MBCorpHealth.Infraestrutura.Repositorio;

namespace ExemploDeCriacaoDeUmRepositorioTurma4
{
    [TestClass]
    public class TestesIntegrados
    {
        ISession _sessaoNHibernate;

        [TestInitialize]
        public void Inicializacao() {
            _sessaoNHibernate = ConfiguracaoNHibernate.Criar().OpenSession();
        }

        [TestMethod]
        public void ComoAdministradorQueroGravarUmAntendente()
        {


            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendente(_sessaoNHibernate);
            Atendente atendente = new Atendente("12334542312", "Fabio Margarito", DateTime.Now);
            Atendente atendente2 = new Atendente("23232423232", "Flavio Margarito", DateTime.Now);

            //Act
            bool retorno = repositorioAtendente.Gravar(atendente);
            bool retorno2 = repositorioAtendente.Gravar(atendente2);

            //Assert
            Assert.IsTrue(retorno);
            Assert.IsTrue(retorno2);
        }

        [TestMethod]
        public void ComoAdministradorQueroSelecionarUmAtendentePorCPF()
        {
            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendente(_sessaoNHibernate);

            //Act
            Atendente atendente = repositorioAtendente.retornarPorCPF("12334542312");

            //Assert

            Assert.IsTrue(atendente.Nome == "Fabio Margarito");
            Assert.IsTrue(atendente.CPF == "12334542312");

        }
              

        [TestMethod]
        public void ComoAdministradorQueroAListaDeTodosOsAtendentes()
        {
            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendente(_sessaoNHibernate);

            //Act
            IList<Atendente> atendentes = repositorioAtendente.retornarTodos();

            //Assert
            Assert.IsTrue(atendentes.Count > 0);


        }


        [TestMethod]
        public void ComoAdministradorQueroExcluirUmAntendente()
        {

            //Arrange
            IRepositorioAtendente repositorioAtendente = new RepositorioAtendente(_sessaoNHibernate);
            Atendente atendente = new Atendente("12334542312", "Fabio Margarito", DateTime.Now);
            Atendente atendente2 = new Atendente("23232423232", "Flavio Margarito", DateTime.Now);

            //Act
            bool retorno = repositorioAtendente.Excluir(atendente);
            bool retorno2 = repositorioAtendente.Excluir(atendente2);

            //Assert
            Assert.IsTrue(retorno);
            Assert.IsTrue(retorno2);

        }

    }
}
