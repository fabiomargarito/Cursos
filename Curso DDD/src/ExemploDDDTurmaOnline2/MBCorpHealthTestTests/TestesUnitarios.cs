using System;
using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Aplicacao.Servicos;
using MBCorpHealthTest.Dominio.Contratos.Repositorios;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.Fabricas;
using MBCorpHealthTest.Dominio.ObjetosDeValor;
using MBCorpHealthTest.Infraestrutura.Repositorios;
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

            ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new AgendamentosFake());            
            Medico medico = new Medico("1234","Mario Peres");            
            Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();

            //Act            
            bool retorno = servicoDeAgendamento.CadastrarAgendamento(agendamento);
            
            //Assert

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorTrechoDoNome()
        {
            
            //Arrange
            IPacientes pacientes = new PacientesFake();

            //Act

            IList<Paciente> listaDePacientes = pacientes.ConsultarPacientesPorTrechoDoNome("Fabio");

            //Assert
            Assert.IsTrue(listaDePacientes.Count > 0);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorCPF()
        {
            //Arrange
            IPacientes pacientes = new PacientesFake();

            //Act

            Paciente paciente = pacientes.ConsultarPacientesPorCPF("1234");

            //Assert
            Assert.IsTrue(paciente.CPF == "1234");

        }

        [TestMethod]
        public void ComoAtendenteQueroInformarNoAgendamentoOPaciente()
        {
            //Arrange
                        
            Paciente paciente = new Paciente("000.000.000-12","Fabio Margarito Martins de Barros");

            Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();

            //Act
            agendamento.InformarPaciente(paciente);            

            //Assert
            Assert.IsTrue(agendamento.Paciente.CPF == "000.000.000-12");
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRM() {
            
            //Arrange
            IMedicos medicos = new MedicosFake();
            //Act
            Medico medico = medicos.ConsultarPorCRM("1234");

            //Assert
            Assert.IsTrue(medico.CRM == "1234");

        }


        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorTrechoDoNome()
        {

            //Arrange
            IMedicos medicos = new MedicosFake();
            //Act
            IList<Medico> listagemDeMedicos = medicos.ConsultarPorTrechoDoNome("Fabio");

            //Assert
            Assert.IsTrue(listagemDeMedicos.Count>0);

        }


        [TestMethod]
        public void ComoAtendenteQueroInformaroNoAgendamentoOCID()
        {
            //Arrange
            //Arrange

            Agendamento agendamento = (new FabricaDeAgendamento()).InformarAtendente("12345", "Joao").InformarMedico("1234", "Fabio").Criar();

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

            Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();

            TipoExame tipoExame = new TipoExame("0001110000111212",10);
            CentroDiagnostico centroDiagnostico = new CentroDiagnostico("111.222.333/00001-11");
            Exame exame = new Exame(tipoExame,centroDiagnostico,new DateTime(2015,02,20));

            //Act
            agendamento.AdicionarExame(exame);
            (new ServicoDeAgendamento(new AgendamentosFake())).CadastrarAgendamento(agendamento);


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

            Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();
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
            Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234","Fabio").InformarAtendente("12345","Joao").Criar();


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

    public class AgendamentosFake : IAgendamentos
    {
        public bool Gravar(Agendamento agendamento)
        {
            return true;
        }
    }

    public class MedicosFake : IMedicos
    {
        public Medico ConsultarPorCRM(string CRM)
        {
            return new Medico("1234","Fabio Margarito");
        }

        public IList<Medico> ConsultarPorTrechoDoNome(string Nome)
        {
            IList<Medico> listagemDeMedicos = new List<Medico>();
            listagemDeMedicos.Add(new Medico("1234","fabio"));
            listagemDeMedicos.Add(new Medico("567", "fabio Marcelo"));

            return listagemDeMedicos;
        }
    }

    public interface IMedicos
    {
        Medico ConsultarPorCRM(string CRM);
        IList<Medico> ConsultarPorTrechoDoNome(string Nome);
    }
}
