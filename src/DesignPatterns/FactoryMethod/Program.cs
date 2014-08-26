using System;
using  FactoryMethod;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            


            
            
            var fabricaDeRepositorio = new FactoryMethod.FabricaDeRepositorioEntityFramework();
                       
            
            IRepositorio repositorioDeCliente = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.CLIENTE);
           
        
            repositorioDeCliente.Salvar(new Cliente{identificador = 4, nome = "Teste", sobreNome ="testes 2"});


            IRepositorio repositorioDeFornecedor = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.FORNECEDOR);
            
           
            repositorioDeFornecedor.Salvar(new Fornecedor{identificador = 1,nome = "teste", razaoSocial = "razao social"});


            IRepositorio repositorioDeAcao = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.ACAO);


            repositorioDeAcao.Salvar(new Acao{Codigo = "PETR4"});

            Console.ReadKey();
        }
    }
}
