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

            Pizza atum = new Atum();


            Ingrediente tomate = new Tomate(atum);
            Ingrediente aliche = new Aliche(tomate);
            Ingrediente molhoextra = new MolhoExtra(aliche);
            
                               

            Console.WriteLine(String.Format("Valor Total da Pizza: {0}",  molhoextra.RetornarPreco()));
                                  
            Console.ReadKey();

            

        }
    }
}
