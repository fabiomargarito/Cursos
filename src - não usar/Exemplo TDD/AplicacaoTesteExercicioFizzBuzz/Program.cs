using System;
using ExercicioTDDFizzBuzz;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            for (int num = 1; num <= 16; num++)
            {
                Console.WriteLine(fizzBuzz.AvaliarNumero(num));
            }
            Console.ReadKey();
        }
    }
}
