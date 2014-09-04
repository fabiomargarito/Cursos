using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaFizzBuzzComTDDTurmaOnline4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveExibirFizzQuandoNumeroDivisivelPor3()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var resultado = fizzBuzz.EscreverFizzouBuzz(3);

            //Assert
            Assert.IsTrue(resultado == "FIZZ");
        }

        [TestMethod]
        public void DeveExibirBuzzQuandoNumeroDivisivelPor5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var resultado = fizzBuzz.EscreverFizzouBuzz(5);

            //Assert
            Assert.IsTrue(resultado == "BUZZ");

        }

        [TestMethod]
        public void DeveExibirFIZZBuzzQuandoNumeroDivisivelPor3E5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var resultado = fizzBuzz.EscreverFizzouBuzz(15);

            //Assert
            Assert.IsTrue(resultado == "FIZZBUZZ");
        }

        [TestMethod]
        public void DeveExibirOProprioNumeroCasoNaoSejaDiviselPor3Ou5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var numero = 4;
            var resultado = fizzBuzz.EscreverFizzouBuzz(4);

            //Assert
            Assert.IsTrue(resultado == 4.ToString());
        }
    }
}
