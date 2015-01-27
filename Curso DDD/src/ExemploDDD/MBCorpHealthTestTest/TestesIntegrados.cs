using System;
using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMedicos = MBCorpHealthTest.Dominio.Contratos.IMedicos;

namespace MBCorpHealthTestTest
{
    [TestClass]
    public   class TestesIntegrados
    {

        [TestMethod]
        public virtual  void ComoAtendenteQueroConsultarUmMedicoPorCRMEEstadoIntegrado()
        {
            //Arrange

            using (var session = NHibernateSessionFactory.Criar().OpenSession())
            {
                IMedicos medicos = new Medicos(session);

            
            //Act
            Medico medico = medicos.PesquisarMedicoPorCRMEEstado("123", "SP");

            //Assert
            Assert.IsTrue(medico != null);
            Assert.IsTrue(medico.CRM == "123");
            Assert.IsTrue(medico.Estado == "SP");

                }
        }


        [TestMethod]
        public virtual void ComoPacienteQueroConsultarOResultadoDosMeusExamesIntegrado()
        {
            using (var session = NHibernateSessionFactory.Criar().OpenSession())
            {
            //Assert
            IAgendamentos agendamentos = new Agendamentos(session);

            
                //Arrange
                Agendamento agendamento =
                    agendamentos.pesquisarPorPaciente((new Credencial("fabiomargarito@gmail.com", "1234")));

                //Assert
                Assert.IsTrue(agendamento.Exames[0].Laudo.Descricao == "teste");
            }
        }




    }
    
    
    }

