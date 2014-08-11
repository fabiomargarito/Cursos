using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator;
using ExercicioDecorator;
using CommandFormat;

namespace ExemplosModulo2.DecoratorCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza marguerita = new Marguerita();            

            Ingrediente queijoExtra = new QueijoExtra(marguerita);
            Ingrediente molhoExtra = new MolhoExtra(queijoExtra );
            Ingrediente cebola = new Cebola(molhoExtra);
            

            Console.WriteLine(String.Format("Valor Total da Pizza: {0}",  cebola.RetornarPreco()));
                                  
            Console.ReadKey();

            

        }
    }
}
