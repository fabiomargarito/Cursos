     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using TemplateMethod;

namespace ExemplosModulo2.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            DALBase<BLOG> dalBlog = new DALBlog();
            var retornoBlog = dalBlog.Executar();


            DALBase<Corretora> dalCorretora = new DALCorretora();
            var retornoCorretora = dalCorretora.Executar();
            
            
            var dalCliente = new DALCliente();            
            var retorno = dalCliente.Executar();

            var dalAcao = new DALACAO();
            var retornoAcao = dalAcao.Executar();




            Console.ReadKey();

        }
    }
}
