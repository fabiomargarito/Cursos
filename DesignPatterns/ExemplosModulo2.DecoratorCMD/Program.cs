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

            Cobertura queijoExtra = new QueijoExtra(marguerita);
            Cobertura molhoExtra = new MolhoExtra(queijoExtra );

            Console.WriteLine(String.Format("Valor Total da Pizza: {0}",  molhoExtra.RetornarPreco()));
            
            Console.ReadKey();


            //Texto textoHTML = new TextoHTML();
            //textoHTML.texto = "Curso de Fundamentos em Arquitetura de Software";

            //TipoFormatacao bold = new Bold(textoHTML);
            //TipoFormatacao center = new Center(bold);
            //// Console.WriteLine(center.Formatar());



            //CommandFormat.HTMLParser htmlParser = new CommandFormat.HTMLParser();



            //CommandFormat.Comando Bold = new CommandFormat.Formatar(htmlParser, bold);
            //CommandFormat.Comando Center = new CommandFormat.Formatar(htmlParser, center);


            //Editor editor = new Editor();
            //editor.EnviarComando(Bold);
            //editor.EnviarComando(Center);

            //editor.FormatarTudo();
            //editor.Undo();
            //editor.ReUndo();



            Console.ReadKey();

            

        }
    }
}
