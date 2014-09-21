using System;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeBrokerMBCorpUnitTest
{
    [TestClass]
    public class TestesIntegrados
    {
        [TestMethod]
        public void DeveGravarUmaEmpresaNoBancoDeDadosUtilizandoNHibernate()
        {
            var acao = new Acao("PETR4",Tipo.ON);
            
            var empresa = new Empresa("12345", "Petrobras Nova");
            empresa.AdicionarAcao(acao);

           IRepositorio<Empresa> repositorioEmpresa = new RepositorioEmpresaNhiberante();
           repositorioEmpresa.Gravar(empresa);
        }


        [TestMethod]
        public void DeveRetornarUmaListaDeEmpresasCadastradas()
        {

            //Arrange
            IRepositorio<Empresa> repositorioEmpresa = new RepositorioEmpresaNhiberante();
            var acao = new Acao("PETR4", Tipo.ON);

            var empresa = new Empresa("12345", "Petrobras Nova");

            empresa.AdicionarAcao(acao);            

            repositorioEmpresa.Gravar(empresa);
          
            //act          
            var empresas = repositorioEmpresa.ListarTodos();

            //Assert
            Assert.IsTrue(empresas.Count > 0);

        }
    }

}
