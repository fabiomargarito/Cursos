using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using JBSHealthCare.Aplicacao.Servico;
using JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Aplicacao.Servico.BoundedContextGestaoPlanoSaude;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;
using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Fabrica;
using JBSHealthCare.Dominio.Fabrica.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Interface.Repositorio;
using JBSHealthCare.Dominio.Interface.Repositorio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Infraestrutura.Repositorio;
using JBSHealthCare.Infraestrutura.Repositorio.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.View.ViewModels;
using JBSHealthCare.View.ViewModels.BoundedContextGestaoDeAgendamentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class TestesUnitarios
    {
        [TestMethod]


        public void ComoDesenvolvedorQueroUmaFabricaDeAgendamento()
        {
            //arrange
            FabricaDeAgendamento fabricaDeAgendamento = new FabricaDeAgendamento();

            //act

            Agendamento agendamento =
                fabricaDeAgendamento.
                InformarPaciente("2345").
                InformarMedico("1234").
                InformarCID("21-9").
                Criar();

            //assert

            Assert.IsTrue(agendamento.Medico.Crm == "1234");
            Assert.IsTrue(agendamento.Paciente.Cpf == "2345");
            Assert.IsTrue(agendamento.Cid.Numero == "21-9");

        }

        public void EuComoAtendenteQueroInicarUmAgendamento()
        {
            //Arrange
            Agendamento agendamento = new Agendamento();
            Medico medico = new Medico("12345","Fabio");
            Paciente paciente = new Paciente("2345","Joao");
            CID cid = new CID("21-9","Virose");




            //Act
            agendamento.InformarMedico(medico);
            agendamento.InformarCID(cid);
            agendamento.InformarPaciente(paciente);

         
            //Assert
            Assert.IsTrue(agendamento.Medico.Crm == "12345");
            Assert.IsTrue(agendamento.Paciente.Cpf == "2345");
            Assert.IsTrue(agendamento.Cid.Numero == "21-9");            

        }

        [TestMethod]
        public void ComoAtendenteEuQueroCriarUmAgendamento()
        {

            //Arrange
            

            AgendamentoViewModel  agendamentoViewModel = new AgendamentoViewModel {crm= "2345", cpf= "2345", numeroCID = "21-9" };


            //Act
        
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new AgendamentosFake());
            var retorno = servicoDeAgendamento.CriarAgendamento(agendamentoViewModel);

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void ComoAtendenteQueroPersistirUmAgendamento()
        {
            //Arrange
            IAgendamentos agendamentos = new AgendamentosFake();

            FabricaDeAgendamento fabricaDeAgendamento = new FabricaDeAgendamento();

            //act

            Agendamento agendamento =
                fabricaDeAgendamento.
                InformarPaciente("2345").
                InformarMedico("1234").
                InformarCID("21-9").
                Criar();

            //Act
            var retorno = agendamentos.Gravar(agendamento);


            //Assert
            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void ComoAtendenteQueroIncluirUmExameDoPaciente()
        {

            //Arrange
            Agendamento agendamento = new Agendamento();
            Medico medico = new Medico("12345", "Fabio");
            Paciente paciente = new Paciente("2345", "Joao");
            CID cid = new CID("21-9", "Virose");

            Exame exame = new Exame("12342323232");


            //Act
            agendamento.InformarMedico(medico);
            agendamento.InformarCID(cid);
            agendamento.InformarPaciente(paciente);
            agendamento.AdicionarExame(exame);


            //Assert
            Assert.IsTrue(agendamento.Medico.Crm == "12345");
            Assert.IsTrue(agendamento.Paciente.Cpf == "2345");
            Assert.IsTrue(agendamento.Cid.Numero == "21-9");
            Assert.IsTrue(agendamento.Exames.Any());

        }


        [TestMethod]
        public void ComoAtendenteQueroConsultarACoberturadeUmTipoDeExame()
        {
            //Arrange
            Exame exame = new Exame();
            exame.InformarTipoExame(new TipoExame("1023"));

            IServicoDeConsultaAPlanoDeSaude servicoDeConsultaAPlanoDeSaude = new ServicoDeConsultaAPlanoDeSaudeFake();
            

            //Act
            var retorno = servicoDeConsultaAPlanoDeSaude.ConsultarCobertura(exame.TipoExame, new PlanoSaude("PortoMaster"));


            //Assert

            Assert.IsTrue(retorno);

        }




    }
}

