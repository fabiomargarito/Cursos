using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Dominio.Servicos;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;
using HomeBrokerMBCorpUnitTest;
using Microsoft.Practices.Unity;

namespace TesteDeDominio
{
    class Program
    {

        static void Main(string[] args)
        {
          UnityContainer unity = new UnityContainer();
            unity.RegisterType<IRepositorio<Usuario>,RepositorioUsuarioNHibernate>();

            UsuarioService usuarioService = unity.Resolve<UsuarioService>();

            usuarioService.Gravar(Guid.NewGuid().ToString(),"Fabio" + Guid.NewGuid().ToString());

            Console.WriteLine("Usuario Gravado!!!!1");

            Console.ReadKey();
        }
    }
}
