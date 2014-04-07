using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;


namespace FactoryMethod
{
    //Product
    public interface Repositorio
    {
         void Salvar(Entidade Entidade);
         IList<Entidade> Retornar(Entidade Entidade);
    }

    //Concrete Product
    public class RepositorioDeClientes : Repositorio {

        public void Salvar(Entidade Entidade)
        {
            Console.WriteLine("Cliente salvo com sucesso");
        }

        public IList<Entidade> Retornar(Entidade Entidade)
        {
            IList<Entidade> Clientes = new List<Entidade>();
            Clientes.Add(new Cliente { identificador = 1, nome = "Fabio", sobreNome = "Margarito" } as Entidade);
            Clientes.Add(new Cliente { identificador = 2, nome = "Flávio", sobreNome = "Margarito" } as Entidade);
            return Clientes;
        }
    }

    //Concrete Product
    public class RepositorioDeFornecedores:Repositorio
    {

        public void Salvar(Entidade Entidade)
        {
            //Aqui seria a gravação no banco de dados
            Console.WriteLine("Fornecedor salvo com sucesso");
        }

        public IList<Entidade> Retornar(Entidade Entidade)
        {
            IList<Entidade> Fornecedores = new List<Entidade>();
            Fornecedores.Add(new Fornecedor { identificador = 1, nome = "Caçula", razaoSocial = "Caçula de Pneus SA" } as Entidade);
            Fornecedores.Add(new Fornecedor { identificador = 2, nome = "Extra", razaoSocial = "Extra Supermercado LTDA" } as Entidade);
            return Fornecedores;
        }
    }

    //Factory
    public class FabricaDeRepositorio{

        public Repositorio CriarRepositorio(TipoDeRepositorio tipoDeRepositorio)
        { 
            switch (tipoDeRepositorio){
                case TipoDeRepositorio.CLIENTE: return (new RepositorioDeClientes()) ;
                case TipoDeRepositorio.FORNECEDOR: return (new RepositorioDeFornecedores());
                default: throw new Exception("Repositório não Existe");            
            }
        }
    }

    
    #region Entidades    

    public abstract class Entidade
    {
        public int identificador;
    }
    public class Cliente:Entidade{
        public string nome {get;set;}
        public string sobreNome {get;set;}
    }

    public class Fornecedor:Entidade{
        public string nome {get;set;}
        public string razaoSocial {get;set;}
    }

    public enum TipoDeRepositorio
    {
        CLIENTE,
        FORNECEDOR
    }

    #endregion    


}
