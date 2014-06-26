using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploTDDFizzBuzzTurma2Online
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveExibirFizzSeNumeroDivisivelPor3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.Retornar(3)=="Fizz");
        }


        [TestMethod]
        public void DeveExibirBuzzSeNumeroDivisivelPor5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.Retornar(5) == "Buzz");
        }


        [TestMethod]
        public void DeveExibirOProprioNumeroSeNaoForDivisivelpor3e5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.Retornar(1) == "1");
        }
        
        [TestMethod]
        public void DeveExibirFizzBuzzSeNumeroDivisivelPor3E5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.Retornar(15) == "FizzBuzz");
        }


        [TestMethod]
        public void DeveGravarDadosDoCliente()
        {
            Cliente cliente = new Cliente();
            cliente.CPF = "12233344423";
            cliente.Nome = "Fabio Margarito Martins de Barros";

            Dal dalCliente = new DalClienteMock();
            Assert.IsTrue(dalCliente.Gravar(cliente));
            Assert.IsTrue(dalCliente.Retornar("12233344423")=="Fabio Margarito Martins de Barros");
        }

    }


    public interface Dal
    {
        bool Gravar(Cliente cliente);
        string Retornar(string s);
    }

    public class DalClienteMock:Dal
    {
        public bool Gravar(Cliente cliente)
        {
            return true;
        }

        public string Retornar(string s)
        {
            return "Fabio Margarito Martins de Barros";
        }
    }

    public class DalCliente:Dal
    {
        public bool Gravar(Cliente cliente)
        {
            return true;
        }

        public string Retornar(string s)
        {
            return "Fabio Margarito Martins de Barros";
        }
    }

    public class Cliente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
    }

    public class FizzBuzz
    {
        public string Retornar(int numero)
        {

            if ((numero % 5 == 0) && (numero % 3 == 0))
                return "FizzBuzz";

            if(numero%3==0)
                return "Fizz";
            if (numero%5 == 0)
                return "Buzz";
            
            return numero.ToString();
        }
    }
}
