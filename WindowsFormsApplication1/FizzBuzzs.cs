namespace WindowsFormsApplication1
{
    public class FizzBuzzs
    {
        public string RetornarValor(int i)
        {
            if ((i % 5 == 0) && (i % 3 == 0))
                return "FIZZBUZZ";

            if (i%3==0)
                return "FIZZ";

            if (i % 5 == 0)
                return "BUZZ";
            
            return i.ToString();
        }
    }
}