using System;
using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Aplicacao.Servicos;
using MBCorpHealthTest.Dominio.Contratos.Repositorios;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.Fabricas;
using MBCorpHealthTest.Infraestrutura;
using MBCorpHealthTest.Infraestrutura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Linq.Functions;

namespace MBCorpHealthTestTests
{
    [TestClass]
    public class TestesIntegrado
    {
        private ISession _session;
        public TestesIntegrado()
        {
            //_session = ConfiguracaoNHibernate.NHibernateSessionFactory.Criar().OpenSession();
        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorTrechoDoNomeIntegrado()
        {

            ////Arrange
            //IPacientes pacientes = new Pacientes(_session);

            ////Act

            //IList<Paciente> listaDePacientes = pacientes.ConsultarPacientesPorTrechoDoNome("Fabio");

            ////Assert
            //Assert.IsTrue(listaDePacientes.Count > 0);

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmPacientePorCPFIntegrado()
        {
            ////Arrange
            //IPacientes pacientes = new Pacientes(_session);

            ////Act

            //Paciente paciente = pacientes.ConsultarPacientesPorCPF("1234");

            ////Assert
            //Assert.IsTrue(paciente.CPF == "1234");

        }

        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorCRMIntegrado()
        {

            ////Arrange
            //IMedicos medicos = new Medicos(_session);
            ////Act
            //Medico medico = medicos.ConsultarPorCRM("1234");

            ////Assert
            //Assert.IsTrue(medico.CRM == "1234");

        }


        [TestMethod]
        public void ComoAtendenteQueroConsultarUmMedicoPorTrechoDoNomeIntegrado()
        {

            ////Arrange
            //IMedicos medicos = new Medicos(_session);
            ////Act
            //IList<Medico> listagemDeMedicos = medicos.ConsultarPorTrechoDoNome("Fabio");

            ////Assert
            //Assert.IsTrue(listagemDeMedicos.Count > 0);

        }


        [TestMethod]
        public void ComoAtendenteEuQueroCadastrarUmAgendamentoIntegrado()
        {
            ////Arrange

            //ServicoDeAgendamento servicoDeAgendamento = new ServicoDeAgendamento(new Agendamentos(_session));
            //Medico medico = new Medico("1234", "Mario Peres");
            //Atendente atendente = new Atendente("000.000.000-10", "Victor Cleber");
            //Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();            
            //agendamento.InformarPaciente(new Paciente("1234","Fabio Margarito"));            

            ////Act            
            //bool retorno = servicoDeAgendamento.CadastrarAgendamento(agendamento);

            ////Assert

            //Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void ComoAtendenteQueroInformarOExameDesejadoNoAgendamentoIntegrado()
        {
            //Arrange

            //Agendamento agendamento = (new FabricaDeAgendamento()).InformarMedico("1234", "Fabio").InformarAtendente("12345", "Joao").Criar();

            //TipoExame tipoExame = new TipoExame("0001110000111212", 10);
            //CentroDiagnostico centroDiagnostico = new CentroDiagnostico("111.222.333/00001-11");
            //Exame exame = new Exame(tipoExame, centroDiagnostico, new DateTime(2015, 02, 20));

            ////Act
            //agendamento.AdicionarExame(exame);
            //(new ServicoDeAgendamento(new Agendamentos(_session))).CadastrarAgendamento(agendamento);


            ////Assert
            //Assert.IsTrue(agendamento.Exames.FirstOrDefault().TipoExame.CBHPM == "0001110000111212");

        }

    }
}
