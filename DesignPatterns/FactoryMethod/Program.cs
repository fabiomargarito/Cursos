using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricaDeRepositorio = new FactoryMethod.FabricaDeRepositorio();
                       
            
            var repositorioDeCliente = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.CLIENTE);
           
        
            repositorioDeCliente.Salvar(new Cliente{identificador = 4, nome = "Teste", sobreNome ="testes 2"});


            var repositorioDeFornecedor = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.FORNECEDOR);
            
           
            repositorioDeFornecedor.Salvar(new Fornecedor{identificador = 1,nome = "teste", razaoSocial = "razao social"});

            Console.ReadKey();
        }
    }
}
