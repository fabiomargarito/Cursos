using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercicioTDDFizzBuzz
{
    [TestClass]
    public class TestesUnitarios
    {
        [TestMethod]
        public void DeveRetornarFizz()
        {
            FizzBuzz  fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.AvaliarNumero(3)=="Fizz");
        }

        [TestMethod]
        public void DeveRetornaroNumeroSeNaoForDivisivelPor3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.AvaliarNumero(4) == "4");
        }

        [TestMethod]
        public void DeveRetornarBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.AvaliarNumero(5) == "Buzz");
        }

        [TestMethod]
        public void DeveRetornarFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.AvaliarNumero(15) == "FizzBuzz");
        }


    }

    public class FizzBuzz
    {
        public string AvaliarNumero(int numero)
        {
            string retorno = string.Empty;
            if ((numero%3 == 0) && (numero%5 == 0)) 
                retorno = "FizzBuzz";

            else if (numero%3 == 0)
                retorno = "Fizz";
            else if (numero%5 == 0)
                retorno = "Buzz";
            else            
                retorno = numero.ToString();

            return retorno;
        }

        

 
    }
}
