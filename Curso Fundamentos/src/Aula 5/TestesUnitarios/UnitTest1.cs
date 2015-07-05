using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBCorpHealth.Dominio;

namespace TestesUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarGeracaoDeCredencial()
        {
            //Arrange            
            Credencial credencial = new Credencial();
            Paciente paciente = new Paciente("Fabio Margarito","123456");

            //Act
            var retorno = credencial.GerarCredencial(paciente);

            //Assert
            Assert.IsTrue(retorno.NomeDeUsuario =="Fabio123456");
            Assert.IsTrue(retorno.Senha == "123456");

        }

        [TestMethod]
        public void ValidarCoberturaDePlanosDeSaudePortoSeguro() {

            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude();
            planoDeSaude.CNPJ = "001.001.0001/00001-10";
            TipoExame tipoExame = new TipoExame("Exame de Sangue");
            Exame exame = new Exame(tipoExame, new System.DateTime(2015,10,10));

            //Act
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Arrange
            Assert.IsTrue(retorno == true);    

        }

        [TestMethod]
        public void ValidarCoberturaDePlanosDeBradesco()
        {

            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude();
            planoDeSaude.CNPJ = "002.002.0002/00002-20";
            TipoExame tipoExame = new TipoExame("Exame de Sangue");
            Exame exame = new Exame(tipoExame, new System.DateTime(2015, 10, 10));

            //Act
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Arrange
            Assert.IsTrue(retorno == false);

        }


        [TestMethod]
        public void ValidarCoberturaDePlanosAmil()
        {

            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude();
            planoDeSaude.CNPJ = "003.003.0003/00003-30";
            TipoExame tipoExame = new TipoExame("Exame de Sangue");
            Exame exame = new Exame(tipoExame, new System.DateTime(2015, 10, 10));

            //Act
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Arrange
            Assert.IsTrue(retorno == true);

        }


        [TestMethod]
        public void ValidarCoberturaDePlanosSulAmerica()
        {

            //Arrange
            PlanoDeSaude planoDeSaude = new PlanoDeSaude();
            planoDeSaude.CNPJ = "004.004.0004/00004-40";
            TipoExame tipoExame = new TipoExame("Exame de Sangue");
            Exame exame = new Exame(tipoExame, new System.DateTime(2015, 10, 10));

            //Act
            var retorno = planoDeSaude.VerificarCobertura(exame);

            //Arrange
            Assert.IsTrue(retorno == true);

        }

    }



}
