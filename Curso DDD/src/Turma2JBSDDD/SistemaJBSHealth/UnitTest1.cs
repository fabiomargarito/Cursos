using System;
using System.Collections;
using System.Linq;
using System.Security.Policy;
using JBSMedical;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SistemaJBSHealth
{
    [TestClass]
    public class TestesUnitariosJbs
    {
        [TestMethod]
        public void ComoAtendenteQueroCadastrarUmPaciente()
        {
            //Arrange
            Paciente paciente = new Paciente("12345", "Fabio Margarito");
            ServicoDeGravacaoDePaciente servicoDeGravacaoDePaciente = new ServicoDeGravacaoDePaciente(new DalPacienteFake());
              

            //Act
            paciente.InformarPlanoDeSaude(new PlanoDeSaude { CNPJ = "456", RazaoSocial = "JBS Medical Services" });

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
                                   

            //Assert
            Assert.IsTrue(agendamento.Medico!=null);
            Assert.IsTrue(agendamento.Paciente != null);
            Assert.IsTrue(((IList) agendamento.Exames).Count >0);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComoAtendenteQueroCadastrarUmPacienteInconsistenteParaSistemaValidar()
        {
            //Arrange
            Paciente paciente = new Paciente("", " ");

            //Act
            paciente.InformarPlanoDeSaude(new PlanoDeSaude { CNPJ = "456", RazaoSocial = "JBS Medical Services" });

            IDALPACIENTE dalPaciente = new DalPacienteFake();

            var retorno = dalPaciente.Gravar(paciente);
            var retorno2 = dalPaciente.RetornarPorCPF("12345");

            //Assert
            Assert.IsTrue(retorno);
            Assert.IsTrue(retorno2.CPF == "12345");
            Assert.IsTrue(retorno2.Nome == "Fabio Margarito", "Assert fail on Nome");
            Assert.IsTrue(retorno2.PlanoDeSaude.CNPJ == "456");
            Assert.IsTrue(retorno2.PlanoDeSaude.RazaoSocial == "JBS Medical Services");

        }
    }
}
