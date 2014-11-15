using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersusOverrride
{
    class Program
    {
        static void Main(string[] args)
        {
           ClasseBase instancia = new ClasseFilha();
           instancia.Escrever();

            Console.ReadKey();
        }

    }

}
    public class ClasseBase
    {
        public void Escrever()
        {
            Console.WriteLine("Sou um método da classe base");
        }
    }


    public class ClasseFilha:ClasseBase
    {
        public new void Escrever()
        {
            Console.WriteLine("Sou um método da classe filha");
        }
    }



