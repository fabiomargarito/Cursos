using System;
using System.ComponentModel.Design;
using JBSHealthCare.Aplicacao.Servico;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Fabrica;
using JBSHealthCare.Dominio.Interface.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios
{
    [TestClass]
    public class UnitTest1
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
            Agendamento agendamento = new Agendamento();
            Medico medico = new Medico("12345", "Fabio");
            Paciente paciente = new Paciente("2345", "Joao");
            CID cid = new CID("21-9", "Virose");


            //Act
            agendamento.InformarMedico(medico);
            agendamento.InformarCID(cid);
            agendamento.InformarPaciente(paciente);

            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento();
            var retorno = servicoDeAgendamento.CriarAgendamento(agendamento);

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


    }
}

