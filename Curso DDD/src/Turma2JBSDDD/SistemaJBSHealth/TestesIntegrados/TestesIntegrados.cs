using System.Collections;
using JBSMedical.Aplicacacao.Contratos;
using JBSMedical.Aplicacacao.Servicos;
using JBSMedical.Dominio.Entidades;
using JBSMedical.Dominio.Fabricas;
using JBSMedical.Infraestrutura.Contratos;
using JBSMedical.Infraestrutura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaJBSHealth.TestesUnitarios;

namespace SistemaJBSHealth.TestesIntegrados
{
    [TestClass]
    public class TestesIntegrados
    {
        [TestMethod]
        public void TesteIntegradoComoAtendenteQueroCadastrarUmAgendamento()
        {
            //Arrange
            Agendamento agendamento =
               (new FabricaDeAgendamento())
                    .InformarExame("234", "Exame 2", 200)
                    .InformarMedico("444", "Dr.Joao")
                    .InformarPaciente("12345", "Fabio Margarito")
                    .InformarExame("1234", "Exame Sangue Completo", 100)
                    .Criar();

            bool retorno;
            ISessionORM sessaoNHibernate = new SessionORMNHibernate();
            using (var sessao = NHibernateSessionFactory.Criar().OpenSession())
            {
                ((SessionORMNHibernate)sessaoNHibernate).Sessao = sessao;
                IServicoDeCadastramentoDeAgendamento servicoDeCadastramentoDeAgendamento = new ServicoDeCadastramentoDeAgendamento(sessaoNHibernate);
                retorno = servicoDeCadastramentoDeAgendamento.Cadastrar(agendamento);
                sessao.Flush();
            }


            //Assert
            Assert.IsTrue(agendamento.Medico != null);
            Assert.IsTrue(agendamento.Paciente != null);
            Assert.IsTrue(((IList)agendamento.Exames).Count > 0);
            Assert.IsTrue(retorno);
        }
    }
}

