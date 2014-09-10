using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUnityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveMostrarFizzQuandoNumeroDivisivelPor3()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            
            //act
            var retorno = fizzBuzz.Escrever(3);

            //assert
            Assert.IsTrue(retorno=="FIZZ");
        }

        [TestMethod]
        public void DeveMostrarBuzzQuandoNumeroDivisivelPor5()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var retorno = fizzBuzz.Escrever(5);

            //assert
            Assert.IsTrue(retorno == "BUZZ");
        }

        [TestMethod]
        public void DeveMostrarFIZZBuzzQuandoNumeroDivisivelPor3e5()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var retorno = fizzBuzz.Escrever(15);

            //assert
            Assert.IsTrue(retorno == "FIZZBUZZ");
        }


        [TestMethod]
        public void DeveMostrarOProprioNumeroQuandoNaoDivisivelPor3ou5()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var retorno = fizzBuzz.Escrever(2);

            //assert
            Assert.IsTrue(retorno == "2");
        }

    }
}
