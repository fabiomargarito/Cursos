using System;
using System.Collections;
using System.Collections.Generic;
using JBSMedical.AgendamentoBoundedContext.Aplicacacao.Contratos;
using JBSMedical.AgendamentoBoundedContext.Aplicacacao.Servicos;
using JBSMedical.AgendamentoBoundedContext.Dominio.Entidades;
using JBSMedical.AgendamentoBoundedContext.Dominio.Fabricas;
using JBSMedical.AgendamentoBoundedContext.Infraestrutura.Contratos;
using JBSMedical.AgendamentoBoundedContext.Infraestrutura.Servicos;
using JBSMedical.CadastrosBoundedContext.Aplicacacao.Servicos;
using JBSMedical.CadastrosBoundedContext.Apresentacao.DTOS;
using JBSMedical.CadastrosBoundedContext.Dominio.Contratos.Repositorios;
using JBSMedical.CadastrosBoundedContext.Dominio.Entidades;
using JBSMedical.CadastrosBoundedContext.Infraestrutura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pagseguro;

namespace SistemaJBSHealth.TestesUnitarios
{
    [TestClass]
    public class TestesUnitariosJbs
    {
        [TestMethod]
        public void ComoAtendenteQueroUmServicoQueRetorneUmaAgendaParaUmTipoDeExameNoCdDesejado()
        {
            //Arrange
            IServicoBooking servicoBooking = new ServicoBooking();

            //Act
            IList<DateTime> datas = servicoBooking.ConsultarDisponibilidade("1234", "123");

            //Assert
            Assert.IsTrue(datas.Count > 0);

        }

        [TestMethod]
        public void ComoAtendenteQueroCadastrarUmPaciente()
        {
            //Arrange
            DTOPaciente paciente = new DTOPaciente("12345", "Fabio Margarito");
            ServicoDeGravacaoDePaciente servicoDeGravacaoDePaciente = new ServicoDeGravacaoDePaciente(new DalPacienteFake());
              

            //Act
            //paciente.InformarPlanoDeSaude(new PlanoDeSaude { CNPJ = "456", RazaoSocial = "JBS Medical Services" });

            var retorno = servicoDeGravacaoDePaciente.GravarPaciente(paciente);
            var retorno2 = servicoDeGravacaoDePaciente.ConsultarDadosDoPaciente("12345");

            //Assert
            Assert.IsTrue(retorno);
            Assert.IsTrue(retorno2.CPF=="12345");
            Assert.IsTrue(retorno2.Nome == "Fabio Margarito","Assert fail on Nome");
            Assert.IsTrue(retorno2.PlanoDeSaude.CNPJ == "456");
            Assert.IsTrue(retorno2.PlanoDeSaude.RazaoSocial == "JBS Medical Services");

        }

        [TestMethod]
        public void ComoAtendenteQueroCadastrarUmAgendamento()
        {
            //Arrange
            Agendamento agendamento =
               (new FabricaDeAgendamento())                    
                    .InformarExame("234","Exame 2",200)
                    .InformarMedico("444", "Dr.Joao")
                    .InformarPaciente("12345", "Fabio Margarito")
                    .InformarExame("1234", "Exame Sangue Completo", 100)
                    .Criar();

            SessionORM sessaoNHibernate = new SessionORM();

            IServicoDeCadastramentoDeAgendamento servicoDeCadastramentoDeAgendamento = new ServicoDeCadastramentoDeAgendamentoFake(sessaoNHibernate);            

            //Act
            var retorno = servicoDeCadastramentoDeAgendamento.Cadastrar(agendamento);
           
            //Assert
            Assert.IsTrue(agendamento.Medico!=null);
            Assert.IsTrue(agendamento.Paciente != null);
            Assert.IsTrue(((IList) agendamento.Exames).Count >0);
            Assert.IsTrue(retorno);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComoAtendenteQueroCadastrarUmPacienteInconsistenteParaSistemaValidar()
        {
            //Arrange
            Paciente paciente = new Paciente("", " ");

            //Act
            paciente.InformarPlanoDeSaude(new PlanoDeSaude { CNPJ = "456", RazaoSocial = "JBS Medical Services" });

            IPacientes dalPaciente = new DalPacienteFake();

            var retorno = dalPaciente.Gravar(paciente);
            var retorno2 = dalPaciente.RetornarPorCPF("12345");

            //Assert
            Assert.IsTrue(retorno);
            Assert.IsTrue(retorno2.CPF == "12345");
            Assert.IsTrue(retorno2.Nome == "Fabio Margarito", "Assert fail on Nome");
            Assert.IsTrue(retorno2.PlanoDeSaude.CNPJ == "456");
            Assert.IsTrue(retorno2.PlanoDeSaude.RazaoSocial == "JBS Medical Services");

        }

        [TestMethod]
        public void ComoAtendenteQueroEnviarFatura()
        {

            //Arrange
            IServicoDePagamento servicoDePagamento = new ServicoDePagamentoPagSeguro();

            //Act
            var retorno = servicoDePagamento.SolicitarCobranca(100, "fabiomargarito@gmail.com");

            //assert
            Assert.IsTrue(retorno=="1234");
        }        


    }
}
