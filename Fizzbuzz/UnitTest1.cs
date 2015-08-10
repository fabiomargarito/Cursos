using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QuandoUmNumeroForDivisivelpor3MostrarFizz()
        {
            //Arrange
            FizzBuzzs fizzBuzzs = new FizzBuzzs();

            //Act
            var retorno = fizzBuzzs.RetornarValor(3);

            //Assert
            Assert.IsTrue(retorno == "FIZZ");

        }

        [TestMethod]
        public void QuandoUmNumeroForDivisivelpor5MostrarBUZZ()
        {
            //Arrange
            FizzBuzzs fizzBuzzs = new FizzBuzzs();

            //Act
            var retorno = fizzBuzzs.RetornarValor(5);

            //Assert
            Assert.IsTrue(retorno == "BUZZ");

        }

        [TestMethod]
        public void QuandoUmNumeroForDivisivelPor3e5MostrarFIZZBUZZ()
        {
            //arrange
            FizzBuzzs fizzBuzzs = new FizzBuzzs();

            //act
            var retorno = fizzBuzzs.RetornarValor(15);

            //assert
            Assert.IsTrue(retorno=="FIZZBUZZ");
        }

        [TestMethod]
        public void QuandoNaoForUmNumeroForDivisivelPor3ou5MostrarOProprioNumero()
        {
            //arrange
            FizzBuzzs fizzBuzzs = new FizzBuzzs();

            //act
            var retorno = fizzBuzzs.RetornarValor(1);

            //assert
            Assert.IsTrue(retorno == "1");
        }

    }
}
