using ExemploFizzBuzzTurmaO4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDeTesteFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.escrever(i));
            }

            Console.ReadKey();
        }
    }
}
