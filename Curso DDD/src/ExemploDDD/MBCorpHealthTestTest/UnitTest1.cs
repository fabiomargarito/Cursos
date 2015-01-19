using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTestTest
{


    [TestClass]
    public class UnitTest1
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
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);



            //Assert
            Assert.IsTrue(retornoAgendamento.ID != 0);
            Assert.IsTrue(retornoAgendamento.Exames.Count > 0);

        }

        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorNome()
        {
        }

        [TestMethod]
        public void ComoAtendenteQuandoOPacienteNaoExistirQueroCadastrar()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroPesquisarUmPacientePorCPF()
        {
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
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);


            //Assert
            Assert.IsTrue(agendamento.CalcularValorTotal() == 100);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRMEEstado()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarAAgendaDasUnidadesDeDiagnosticoPorTipoDeExame()
        {
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
            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new ServicoDeEnvioEmailCorporativo());
            var retornoAgendamento = servicoDeAgendamento.CadastrarAgendamento(agendamento);

            agendamento.Exames.FirstOrDefault().EmitirLaudo(new Laudo("bla bla bla bla"));

            //Assert
            Assert.IsTrue(agendamento.Exames.FirstOrDefault().Laudo.Descricao == "bla bla bla bla");

        }

        [TestMethod]
        public void
            ComoAtendenteAoFinalizarCadastroDeAgendamentoQueroGerarCredencialDeAcessoEEnviarEmailComOsDadosDoAgendamento
            ()
        {
        }

        [TestMethod]
        public void ComoPacienteQueroConsultarOResultadoDosMeusExames()
        {
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