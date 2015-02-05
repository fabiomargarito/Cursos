using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Aplicacao;
using MBCorpHealthTest.Dominio.Contratos;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.Fabricas;
using MBCorpHealthTest.Dominio.Servicos;
using MBCorpHealthTest.Infraestrutura;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMedicos = MBCorpHealthTest.Dominio.Contratos.IMedicos;

namespace MBCorpHealthTestTest
{

    [TestClass]
    public class TestesUnitarios
    {
        [TestMethod]
        public void ComoAtendenteQueroRealizarCadastrarUmAgendamento()
        {

            //Arrage
            Agendamento agendamento =
                (new FabricaDeAgendamento()).InformarPaciente("123")
                    .InformarMedicoSolicitante("1234")
                    .InformarAtendente("1234")
                    .Criar();

            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeGeracaoCredencial());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);



            //Assert            
            Assert.IsTrue(retornoAgendamento.Exames.Count() == 0);

        }


        [TestMethod]
        public void DevePersistirOAgendamento()
        {
            //Arrage
            Agendamento agendamento =
                (new FabricaDeAgendamento()).InformarPaciente("123")
                    .InformarMedicoSolicitante("1234")
                    .InformarAtendente("1234")
                    .Criar();

            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            IAgendamentos agendamentos = new AgendamentosFake();

            //Act
            var retorno = agendamentos.Gravar(agendamento);

            //Assert
            Assert.IsTrue(retorno);



        }

        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorNome()
        {
            //Arrange
            IPacientes pacientes = new Pacientes();

            //Act
            IList<Paciente> paciente = pacientes.PesquisarPacientePorTrechoDoNome("fabio");

            //Assert
            Assert.IsTrue(paciente.Count>0);
            Assert.IsTrue(paciente[0].Nome =="Fabio");

        }

        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorCPF()
        {
            //Arrange
            IPacientes pacientes = new Pacientes();

            //Act
            Paciente paciente = pacientes.pesquisarPacientePorCPF("123");

            //Assert
            Assert.IsTrue(paciente != null);
            Assert.IsTrue(paciente.Nome == "Fabio");

        }

        [TestMethod]
        public void ComoAtendenteQuandoOPacienteNaoExistirQueroCadastrar()
        {
            //Arrange
            IPacientes pacientes = new Pacientes();

            //Act
            var retorno = pacientes.Gravar(new Paciente("123", "Fabio", "fabiomargarito@gmail.com"));

            //Assert
            Assert.IsTrue(retorno);

        }
    
        [TestMethod]
        public void ComoAtendenteQueroVerificarSeOPlanoDeSaudeCobreOExame()
        {
            //arrange
            IServicoDeValidacaoDeCoberturaDeExame servicoDeValidacaoDeCoberturaDeExame = new ServicoDeValidacaoDeCoberturaDeExame();

            //act,assert
            Assert.IsTrue(servicoDeValidacaoDeCoberturaDeExame.VerificarCoberturaDoExame(new TipoExame("10101212", "teste", 100), new Paciente("1234", "Fabio", "fabio@fabio.com.br")));
        }

        [TestMethod]
        public void ComoAtendenteQueroVerificarOValorTotalDoAgendamento()
        {
            //Arrage
            Agendamento agendamento =
    (new FabricaDeAgendamento()).InformarPaciente("123")
        .InformarMedicoSolicitante("1234")
        .InformarAtendente("1234")
        .Criar();

            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeGeracaoCredencial());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);


            //Assert
            Assert.IsTrue(agendamento.CalcularValorTotal() == 100);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRMEEstado()
        {
            //Arrange
            IMedicos medicos = new MedicosFake();

            //Act
            Medico medico = medicos.PesquisarMedicoPorCRMEEstado("123", "SP");

            //Assert
            Assert.IsTrue(medico!=null);
            Assert.IsTrue(medico.CRM== "123");
            Assert.IsTrue(medico.Estado == "SP");
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarAAgendaDasUnidadesDeDiagnosticoPorTipoDeExame()
        {
            //iremos utilizar serviço externo
        }

        [TestMethod]
        public void ComoMedicoDeDiagnosticoQueroEmitirUmLaudoParaUmExame()
        {
            //Arrage
            Agendamento agendamento =
    (new FabricaDeAgendamento()).InformarPaciente("123")
        .InformarMedicoSolicitante("1234")
        .InformarAtendente("1234")
        .Criar();

            agendamento.AdicionarExame(new Exame(new TipoExame("10101012", "Hemograma", 100)));

            //Act
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeGeracaoCredencial());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);

            agendamento.Exames.FirstOrDefault().EmitirLaudo(new Laudo("bla bla bla bla"));

            //Assert
            Assert.IsTrue(agendamento.Exames.FirstOrDefault().Laudo.Descricao == "bla bla bla bla");

        }

        [TestMethod]
        public void DeveGerarUmaCredencialParaOPaciente()
        {
           //Arrange
            IServicoDeGeracaoCredencial servicoDeGeracaoDeCredencial = new ServicoDeGeracaoCredencial();
            
            //Act            
            Credencial credencial = servicoDeGeracaoDeCredencial.Gerar(new Paciente("1234","Fabio","fabiomargarito@gmail.com"));

            //Assert
            Assert.IsTrue(credencial.User =="fabiomargarito@gmail.com");
            Assert.IsTrue(credencial.Senha == "1234");

        }

        [TestMethod]
        public void ComoPacienteQueroConsultarOResultadoDosMeusExames()
        {
            //Assert
            IAgendamentos agendamentos = new AgendamentosFake();

            //Arrange
            Agendamento agendamento =
                agendamentos.pesquisarPorPaciente((new Credencial("fabiomargarito@gmail.com", "1234")));

            //Assert
            Assert.IsTrue(agendamento.Exames.First().Laudo.Descricao == "teste");

        }

        [TestMethod]
        public void ComoAtendenteQueroSolicitarEmissaoDeFAturaParaUmAgendamento()
        {
        }

        [TestMethod]
        public void DeveCriarUmAgendamento()
        {
            //Arrange
            FabricaDeAgendamento fabricaDeAgendamento = new FabricaDeAgendamento();

            //Act
            Agendamento agendamento =
                fabricaDeAgendamento.InformarPaciente("123455")
                    .InformarAtendente("1234")    
                    .InformarMedicoSolicitante("CRM")                    
                    .Criar();

            //Assert
            Assert.IsTrue(agendamento.Paciente.CPF == "123455");
            Assert.IsTrue(agendamento.MedicoSolicitante.CRM == "CRM");
            Assert.IsTrue(agendamento.Atendente.CPF == "1234");
        }


     

    }
}