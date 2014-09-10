namespace FizzBuzzUnityTest
{
    public class FizzBuzz
    {
        public string Escrever(int numero)
        {

            if ((numero % 5 == 0) && (numero % 3 == 0))
                return "FIZZBUZZ";

            if (numero%3 == 0)
                return "FIZZ";

            if(numero%5==0)
                return "BUZZ";


            return numero.ToString();
        }
    }
}