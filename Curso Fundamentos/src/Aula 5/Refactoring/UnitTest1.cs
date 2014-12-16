using System;
using MBCorpHealth.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refactoring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveGerarUmaCredencial()
        {
           //Arrange
            Credencial credencialPaciente = new Credencial(null,null);
            
            //Act
            Credencial credencial = credencialPaciente.GerarCredencialInicial(new Paciente("Fabio Margarito", "22212345623"));

            //Assert
            Assert.IsTrue(credencial.NomeDeUsuario == "Fabio22212345623");
            Assert.IsTrue(credencial.Senha == "22212345623");          
        }

        [TestMethod]
        public void DeveConsultarUmCEP()
        {
            //Arrange
            Endereco endereco = new Endereco();

            //Act
            var retorno = endereco.ConsultarEnderecoNosCorreios("02234143", TipoServicoDeConsulta.ServicoCorreios);

            //Assert
            Assert.IsTrue(retorno.Logradouro == "rua 1");
        }


        [TestMethod]
        public void DeveRealizarUmPagamento()
        {
            //Arrange
            ServicoDePagamento pagamentoService = new ServicoDePagamento();

            //Act
            var retorno = pagamentoService.RealizarPagamesnto(new Cartao("123", "23", "134"), 100);

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DeveVerificarSeOExameEhCobertoPelaPortoSeguro()
        {
            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude("001.001.0001/00001-10","Nome teste","senior");
            Exame exame = new Exame(new TipoExame("Urina"), DateTime.Today);
            
            //Act                       
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Assert
            Assert.IsTrue(retorno);
        }


        [TestMethod]
        public void DeveVerificarSeOExameEhCobertoPelaBradescoSaude()
        {
            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude("002.002.0002/00002-20", "Nome teste", "senior");
            Exame exame = new Exame(new TipoExame("Urina"), DateTime.Today);

            //Act                       
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Assert
            Assert.IsTrue(!retorno);
        }


        [TestMethod]
        public void DeveVerificarSeOExameEhCobertoPelaAmil()
        {
            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude("003.003.0003/00003-30", "Nome teste", "senior");
            Exame exame = new Exame(new TipoExame("Urina"), DateTime.Today);

            //Act                       
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Assert
            Assert.IsTrue(retorno);
        }

    }
}


