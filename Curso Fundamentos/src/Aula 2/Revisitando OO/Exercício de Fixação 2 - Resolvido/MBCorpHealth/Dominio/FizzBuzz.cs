using System;

namespace TesteUnitario
{
    public class FizzBuzz
    {
        public string Escrever(int numeroASerAvalidado)
        {
            if ((numeroASerAvalidado % 3 == 0) && (numeroASerAvalidado % 5 == 0))
                return "FIZZBUZZ";
            
            if (numeroASerAvalidado%3 == 0)
                return "FIZZ";

            if (numeroASerAvalidado % 5 == 0)
                return "BUZZ";



            return Convert.ToString(numeroASerAvalidado);
        }
    }
}