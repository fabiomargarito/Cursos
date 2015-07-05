using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBlog
{
    //Subject
    public abstract class Blog
    {
        public string Nome { get; protected set; }
        public IList<Post> Posts { get; private set; }
        
        public IList<Assinante> Assinantes { get; private set; }

        public void AdicionarAssinante(Assinante assinante)
        {
            if(Assinantes==null)
                Assinantes = new List<Assinante>();

            Assinantes.Add(assinante);
        }

        public void RemoverAssinante(Assinante assinante)
        {

            Assinantes.Remove(assinante);
        }

        public void NotificarAssinantes(Post post)
        {
            foreach (var assinante in Assinantes)
            {
                assinante.InformarSobreNovoPost(post);
                
            }
        }

        public void AdicionarPost(Post post)
        {

            if (Posts==null)
                Posts = new List<Post>();

            Posts.Add(post);
            NotificarAssinantes(post);
        }
    }

    public class Post
    {
        public Post(string titulo, string texto)
        {
            Titulo = titulo;
            Texto = texto;
        }

        public string Titulo { get; private set; }
        public string Texto { get; private set; }
    }

    //Concrete Subject
    public class BlogFabio:Blog
    {
        public BlogFabio()
        {
            Nome = "Blog do Fabio";
        }
    }


    public interface Assinante
    {
        void InformarSobreNovoPost(Post post);
    }

    public class AssinanteJBS :Assinante
    {
        public void InformarSobreNovoPost(Post post)
        {
            Console.WriteLine("Novo Post recebido pela JBS: {0} ", post.Titulo);
        }
    }

    public class AssinanteITAU : Assinante
    {
        public void InformarSobreNovoPost(Post post)
        {
            Console.WriteLine("Novo Post recebido pelo itáu {0} Descricao {1} ", post.Titulo, post.Texto);
        }
    }

    public class AssinanteMARFRIG : Assinante
    {
        public void InformarSobreNovoPost(Post post)
        {
            Console.WriteLine("Novo Post recebido pelo Marfrig {0} Descricao {1} ", post.Titulo, post.Texto);
        }
    }
}
