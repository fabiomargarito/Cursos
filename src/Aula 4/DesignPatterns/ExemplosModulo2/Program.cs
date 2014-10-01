using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Singleton;

namespace ExemplosModulo2
{
    class Program
    {
        static void Main(string[] args)
        {

            var Conexao = ConexaoBanco.Criar().DefinirStringConexao("teste").RetornarConexao();


            Console.WriteLine(Configuracao.RetornarConfiguracao().RetornarNomeDoBancoDeDados());
            Console.WriteLine("Altere a configuração do nome do banco, no arquivo de configuração e pressione uma tecla\n\n\n");
            
            
            
            Console.ReadKey();            
            Console.WriteLine(Configuracao.RetornarConfiguracao().RetornarNomeDoBancoDeDados());
            Console.WriteLine("Por ser a mesma instância, o objeto ficou na memória!!!");
            Console.ReadKey();





            var sqlConnection = Conexao.CriarConexao().RetornarConexao();
            var sqlConnectionModelo2 = ConexaoModelo2.RetornarConexao();
        }
    }
}
