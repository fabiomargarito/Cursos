using System;
using MBCorpHealth.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestParaRefactoring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGerarACredencialDeUmaPessoa()
        {
            //arrange
            Credencial agendamento = new Credencial();

            //act
            Credencial credencial = agendamento.GerarCredencialInicial(new Paciente("fabio margarito", "123"));

            //assert
            Assert.IsTrue(credencial.NomeDeUsuario == "fabio123");
            Assert.IsTrue(credencial.Senha == "123");
        }

        [TestMethod]
        public void DeveCriarUmAgendamento()
        {
            //arrange
            Agendamento agendamento = new Agendamento();

            //act
            agendamento.CriarAgendamento(new Paciente("Fabio","123"), new Medico("Joao","1234","1M"));

            //assert
            Assert.IsTrue(agendamento.Paciente.Nome == "Fabio");
            Assert.IsTrue(agendamento.Paciente.CPF == "123" );
            Assert.IsTrue(agendamento.MedicoSolicitante.Nome == "Joao");
            Assert.IsTrue(agendamento.MedicoSolicitante.CPF == "1234");
            Assert.IsTrue(agendamento.MedicoSolicitante.CRM == "1M");

        }



        [TestMethod]
        public void DeveAdicionarUmExame()
        {
            //arrange
            Agendamento agendamento = new Agendamento();
            Paciente paciente = new Paciente("Fabio", "123");
            paciente.DefinirPlanoDeSaude(new PlanoDeSaude());
            
            //act            
            agendamento.CriarAgendamento(paciente, new Medico("Joao", "1234", "1M"));
            agendamento.AdicionarExame(new Exame(new TipoExame("exame 1"),new DateTime(2014,10,06)));

            //assert
            Assert.IsTrue(agendamento.Exames.Count > 0);
            

        }

        [TestMethod]
        public void DeveConsultarUmEnderecoNosCorreios()
        {

            //arrange
            Endereco agendamento = new Endereco();

            //act
            Endereco endereco = agendamento.ConsultarEnderecoNosCorreios("123", TipoServicoDeConsulta.ServicoCorreios);

            //Assert
            Assert.IsTrue(endereco.Logradouro == "rua 1");

        }

    }
}
