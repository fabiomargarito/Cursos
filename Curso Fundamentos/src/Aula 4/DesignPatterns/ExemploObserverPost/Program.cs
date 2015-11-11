using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverBlog;

namespace ExemploObserverPost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Princípio da inversão de dependencia
            Blog blog = new BlogFabio();

            blog.AdicionarAssinante(new AssinanteJBS());
            blog.AdicionarAssinante(new AssinanteITAU());
            blog.AdicionarAssinante(new AssinanteMARFRIG());
            blog.AdicionarAssinante(new AssinanteSergio());

            

            blog.AdicionarPost(new Post("Teste","texto do teste"));
            blog.AdicionarPost(new Post("Novo Post", "Novo Post de teste"));


            Console.ReadKey();

        }
    }
}
