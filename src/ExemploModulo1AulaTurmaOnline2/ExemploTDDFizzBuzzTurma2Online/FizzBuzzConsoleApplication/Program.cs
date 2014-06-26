using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploTDDFizzBuzzTurma2Online;

namespace FizzBuzzConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var contador = 1;
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (contador = 1; contador <= 100; contador++)
            {
                Console.WriteLine(fizzBuzz.Retornar(contador));
                
            }
            Console.ReadKey();
        }
    }
}
