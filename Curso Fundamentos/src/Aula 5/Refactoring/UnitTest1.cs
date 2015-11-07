using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBCorpHealth.Dominio;

namespace Refactoring
{
    [TestClass]
    public class TestesUnitariosParaRefatoracao
    {
        [TestMethod]
        public void ComoAtendenteQueroRealizarUmaBuscaDeEnderecoPorCEP()
        {
            //Arrange
            Endereco consulta = new Endereco();
            var cep = "02234143";

            //Act

            Endereco endereco = consulta.ConsultarEnderecoNosCorreios(cep, TipoServicoDeConsulta.ServicoCorreios);

            //Assert
            Assert.IsTrue(endereco.Logradouro == "rua 1");
            Assert.IsTrue(endereco.Complemento == "casa 1");
            Assert.IsTrue(endereco.Bairro == "vila madalena");
            Assert.IsTrue(endereco.Municipio == "São Paulo");
            Assert.IsTrue(endereco.Estado == "SP");
            Assert.IsTrue(endereco.CEP == "02234143");

        }

        [TestMethod]
        public void ComoAtendenteQueroCriarUmaCredencialParaUmPaciente()
        {

            //Arrange
            Credencial objetoCredencial = new Credencial();
            Paciente paciente = new Paciente("Fabio Margarito Martins de Barros", "34554323423");

            //Act
            Credencial credencial = objetoCredencial.GerarCredencialInicial(paciente);

            //Assert
            Assert.IsTrue(credencial.NomeDeUsuario == "Fabio34554323423");
            Assert.IsTrue(credencial.Senha == "34554323423");



        }

        [TestMethod]
        public void ComoAtendenteQueroFaturarUmValorDeExame() {

            //Arrange            
            Cartao cartao = new Cartao("12345", "Fabio M M Barros", "999");
            var valor = 125.34;

            //Act
            var retorno = cartao.RealizarPagamento( valor);

            //Assert
            Assert.IsTrue(retorno == true);


        }
    }
}

