using System;
using  FactoryMethod;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Princípio da inversão de dependencia            
            IFabricaDeRepositorio fabricaDeRepositorio = new FabricaDeRepositorioEntityFramework();

            //Princípio da inversão de dependencia            
            IRepositorio repositorioDeCliente = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.CLIENTE);
           
        
            repositorioDeCliente.Salvar(new Cliente{identificador = 4, nome = "Teste", sobreNome ="testes 2"});


            //Princípio da inversão de dependencia            
            IRepositorio repositorioDeFornecedor = fabricaDeRepositorio.CriarRepositorio(TipoDeRepositorio.FORNECEDOR);
            
           
            repositorioDeFornecedor.Salvar(new Fornecedor{identificador = 1,nome = "teste", razaoSocial = "razao social"});            

            Console.ReadKey();
        }
    }
}
