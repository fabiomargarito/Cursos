using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploFizzBuzzTurmaO4
{
    [TestClass]
    public class ExercicioTDDComProblemaFizzBuzz
    {
        [TestMethod]
        public void NumerosNaoDivisiveisPor3e5DevemSerEscritosComoOProprioNumero()
        {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var retorno = fizzBuzz.escrever(1);

            //Assert
            Assert.IsTrue(retorno == "1", "Requisito: Para número igual a 1 retornar 1 falhou!");
        }
        [TestMethod]
        public void NumerosDivisiveisPor3DevemSerEscritosComoFIZZ()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string retorno = fizzBuzz.escrever(3);

            //Assert
            Assert.IsTrue(retorno=="FIZZ","Requisito: Para número igual a 3 retornar Fizz falhou!");
        }

        [TestMethod]
        public void NumerosDivisiveisPor5DevemSerEscritosComoBUZZ() {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var retorno = fizzBuzz.escrever(5);

            //Assert
            Assert.IsTrue(retorno == "BUZZ", "Requisito: Para número igual a 5 retornar Buzz falhou!");

        }

        [TestMethod]
        public void NumerosDivisiveisPor3e5DevemSerEscritosComoFizzBuzz() {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var retorno = fizzBuzz.escrever(15);

            //Assert
            Assert.IsTrue(retorno == "FIZZBUZZ", "Requisito: Para número igual a 15 retornar FizzBuzz falhou!");

        }

    }
}
