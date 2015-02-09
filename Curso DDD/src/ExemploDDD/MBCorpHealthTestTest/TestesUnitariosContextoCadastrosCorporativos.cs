using System;
using System.Runtime.InteropServices;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;
using MBCorpHealthTest.Infraestrutura.ContextoCadastrosCorporativos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTestTest
{
    [TestClass]
    public class TestesUnitariosContextoCadastrosCorporativos
    {
        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRMEEstado()
        {
            //Arrange
            IMedicos medicos = new MedicosFake();

            //Act
            Medico medico = medicos.PesquisarMedicoPorCRMEEstado("123", "SP");

            //Assert
            Assert.IsTrue(medico != null);
            Assert.IsTrue(medico.CRM == "123");
            Assert.IsTrue(medico.Estado == "SP");
        }


        [TestMethod]
        public void ComoAdministradorDoCadastroCorporativoQueroGravarUmAtendente()
        {
            //Arrange
            IAtendentes atendentes = new AtendentesFake();

            //Act
            Atendente atendente = new Atendente("1234","Fabio");
            var retorno = atendentes.Gravar(atendente);

            //Assert
            Assert.IsTrue(retorno);

        }


        [TestMethod]
        public void ComoAdministradorDoCadastroCorporativoQueroGravarUmTipoDeExame()
        {
            //Arrange
            ITiposDeExames tiposDeExames = new TiposDeExamesFake();

            //Act

            TipoExame tipoExame = new TipoExame("1234","teste",100);
            var retorno = tiposDeExames.Gravar(tipoExame);

            //Assert
            Assert.IsTrue(retorno);
        }

    }
}
