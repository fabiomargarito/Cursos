using System;
using MBCorp.Domain.BusinessEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {

        [TestMethod]
        public void EscreverOProprioNumeroQuandoNaoForDivisivelPor3ou5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var retorno = fizzBuzz.Escrever(1);
            //Asser
            Assert.IsTrue(retorno == "1");
        }

        
        [TestMethod]
        public void DadoUmNumeroDivisivelPor5EscreverBuzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var retorno = fizzBuzz.Escrever(5);
            //Assert
            Assert.IsTrue(retorno=="Buzz");
        }

        [TestMethod]
        public void DadoUmNumeroDivisivelPor3ePor5EscreverFizzBuzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var retorno = fizzBuzz.Escrever(15);
            //Asser
            Assert.IsTrue(retorno=="FizzBuzz");
        }


        [TestMethod]
        public void DadoUmNumeroDivisivelPor3EscreverFizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var retorno = fizzBuzz.Escrever(3);
            //Assert
            Assert.IsTrue(retorno == "Fizz");
        }

    }
}
