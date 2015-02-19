using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBCorpHealthTestTests
{
    [TestClass]
    public class MBCorpHealthTestTestsTestesUnitarios
    {
        [TestMethod]
        public void ComoAtendenteEuQueroCadastrarUmAgendamento()
        {           
            //Arrange

            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento();            
            Medico medico = new Medico("1234","Mario Peres");            
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = new Agendamento(atendente,medico);

            //Act            
            bool retorno = servicoDeAgendamento.CadastrarAgendamento(agendamento);
            
            //Assert

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorNome()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorCPF()
        {
        }

        [TestMethod]
        public void ComoAtendenteQueroInformarNoAgendamentoOPaciente()
        {
            //Arrange
            
            Medico medico = new Medico("1234", "Mario Peres");            
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");    
            Paciente paciente = new Paciente("000.000.000-12","Fabio Margarito Martins de Barros");
            Agendamento agendamento = new Agendamento(atendente,medico);

            //Act
            agendamento.InformarPaciente(paciente);
            

            //Assert
            Assert.IsTrue(agendamento.Paciente.CPF == "000.000.000-12");
        }



        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRM() {
        }


        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorNome()
        {
        }


        [TestMethod]
        public void ComoAtendenteQueroInformaroNoAgendamentoOCID()
        {
            //Arrange
            //Arrange

            Medico medico = new Medico("1234", "Mario Peres");
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = new Agendamento(atendente, medico);
            CID cid = new CID ("A00 - Cólera");


            //Act
            agendamento.InformarCID(cid);


            //Assert
            Assert.IsTrue(agendamento.CID.Descricao == "A00 - Cólera");

        }

        [TestMethod]
        public void ComoAtendenteQueroInformarOExameDesejadoNoAgendamento()
        {
            //Arrange

            Medico medico = new Medico("1234", "Mario Peres");
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = new Agendamento(atendente, medico);
            TipoExame tipoExame = new TipoExame("0001110000111212",10);
            CentroDiagnostico centroDiagnostico = new CentroDiagnostico("111.222.333/00001-11");
            Exame exame = new Exame(tipoExame,centroDiagnostico,new DateTime(2015,02,20));

            //Act
            agendamento.AdicionarExame(exame);


           //Assert
            Assert.IsTrue(agendamento.Exames.FirstOrDefault().TipoExame.CBHPM == "0001110000111212");

        }

        [TestMethod]
        public void ComoAtendenteQueroFinalizarUmCadastramentoDeAgendamento()
        {

        }



        [TestMethod]
        public void ComoAtendenteQueroCalcularOValorTotalDoAgendamento()
        {
            //Arrange

            Medico medico = new Medico("1234", "Mario Peres");
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = new Agendamento(atendente, medico);
            TipoExame tipoExame = new TipoExame("0001110000111212", 10);
            CentroDiagnostico centroDiagnostico = new CentroDiagnostico("111.222.333/00001-11");
            Exame exame = new Exame(tipoExame, centroDiagnostico, new DateTime(2015, 02, 20));
            agendamento.AdicionarExame(exame);
            agendamento.AdicionarExame(exame);

            //Act
            var retorno = agendamento.CalcularValorTotal();

            //Assert

            Assert.IsTrue(retorno==20);

        }

        [TestMethod]
        public void ComoMedicoQueroEmitirUmLaudoParaUmTipoExameRealizado()
        {
            //Arrange

            Medico medico = new Medico("1234", "Mario Peres");
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = new Agendamento(atendente, medico);
            TipoExame tipoExame = new TipoExame("0001110000111212",10);
            CentroDiagnostico centroDiagnostico = new CentroDiagnostico("111.222.333/00001-11");
            Exame exame = new Exame(tipoExame,centroDiagnostico,new DateTime(2015,02,20));
            agendamento.AdicionarExame(exame);

            //Act
            agendamento.Exames.FirstOrDefault().EmitirLaudo("Resultado XPTO",new Medico("123","Jose"));

            //Assert
            Assert.IsTrue(agendamento.Exames.FirstOrDefault().Laudo.Resultado == "Resultado XPTO");

        }
    }

    
}
