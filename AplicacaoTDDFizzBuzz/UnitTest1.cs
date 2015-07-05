using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacaoTDDFizzBuzz
{
    [TestClass]
    public class FizzBuzzTeste
    {
        [TestMethod]
        public void DeveExibirFizzQuandoNumeroDivisivelPor3()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var retorno = fizzBuzz.mostrar(3);


            //Assert
            Assert.IsTrue(retorno == "FIZZ");
        }

        [TestMethod]
        public void DeveExibirFizzBuzzQuandoNumeroDivisivelPor3ePor5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string retorno = fizzBuzz.mostrar(15);

            //Assert
            Assert.IsTrue(retorno == "FIZZBUZZ");
        }

        [TestMethod]
        public void DeveExibirBuzzQuandoNumeroDivisivelPor5()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string retorno = fizzBuzz.mostrar(5);


            //Assert
            Assert.IsTrue(retorno == "BUZZ");
        }

        

        [TestMethod]
        public void DeveExibirOProprioNumeroQuandoNaoForDivisivelPor3ePor5()
        {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string retorno = fizzBuzz.mostrar(2);


            //Assert
            Assert.IsTrue(retorno == "2");

        }
    }
    public class FizzBuzz {
        public string mostrar(int numero) {
            if (((numero % 3) == 0) && ((numero % 5) == 0))
                return "FIZZBUZZ";

            if ((numero % 3)==0)
                return "FIZZ";
            if ((numero % 5) == 0)
                return "BUZZ";
           
            return numero.ToString(); 
        }
    }

}
