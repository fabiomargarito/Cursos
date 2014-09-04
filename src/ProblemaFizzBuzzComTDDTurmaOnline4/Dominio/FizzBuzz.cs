namespace ProblemaFizzBuzzComTDDTurmaOnline4
{
    public class FizzBuzz
    {
        public string EscreverFizzouBuzz(int numeroASerAvaliado)
        {
            if ((numeroASerAvaliado % 5 == 0) && (numeroASerAvaliado % 3 == 0))
                return "FIZZBUZZ";

            if (numeroASerAvaliado % 3 == 0)
                return "FIZZ";

            if (numeroASerAvaliado % 5 == 0)
                return "BUZZ";
            
            return numeroASerAvaliado.ToString();
        }      
    }
}