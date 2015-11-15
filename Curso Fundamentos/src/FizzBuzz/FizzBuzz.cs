    using System;

namespace ExemploFizzBuzzTurmaO4
{
    public class FizzBuzz
    {
        public string escrever(int numero)
        {
            if ((numero % 3 == 0) && (numero % 5 == 0))
                return "FIZZBUZZ";
            else if (numero % 3 == 0)
                return "FIZZ";
            else if (numero % 5 == 0)
                return "BUZZ";
            
            return numero.ToString();
        }
    }
}