using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteUnitario
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void DeveRetornarFizzSeONumeroEhDivisivelPor5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retorno = fizzBuzz.Escrever(5);

            Assert.IsTrue(retorno=="BUZZ");

        }

        [TestMethod]
        public void DeveRetornarFizzBUZZSeONumeroEhDivisivel3EPor5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retorno = fizzBuzz.Escrever(15);

            Assert.IsTrue(retorno == "FIZZBUZZ");

        }

        [TestMethod]
        public void DeveRetornarFizzSeONumeroEhDivisivelPor3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retorno = fizzBuzz.Escrever(3);

            Assert.IsTrue(retorno == "FIZZ");
        }

        [TestMethod]
        public void DeveRetornarOProprioNumeroSeNaoForDivisivelPor3ou5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string retorno = fizzBuzz.Escrever(1);

            Assert.IsTrue(retorno == "1");

        }
    }
}
