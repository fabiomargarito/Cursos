using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;


namespace FactoryMethod
{
    //Product
    public interface IRepositorio
    {
         void Salvar(Entidade Entidade);
         IList<Entidade> Retornar(Entidade Entidade);
    }

    //Concrete Product
    public class RepositorioDeClientes : IRepositorio {

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


    public class RepositorioDeClientesNovo : IRepositorio
    {
        public void Salvar(Entidade Entidade)
        {
            Console.WriteLine("Cliente salvo com sucesso com código novo");
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
    public class RepositorioDeClientesEntityFramework : IRepositorio
    {

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
    public class RepositorioDeFornecedores:IRepositorio
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

    //Concrete Product
    public class RepositorioDeAcao : IRepositorio
    {

        public void Salvar(Entidade Entidade)
        {
            //Aqui seria a gravação no banco de dados
            Console.WriteLine("Acao salva com sucesso");
        }

        public IList<Entidade> Retornar(Entidade Entidade)
        {
            IList<Entidade> Acoes= new List<Entidade>();
            Acoes.Add(new Acao {Codigo  = "PETR3"} as Entidade);
            Acoes.Add(new Acao {Codigo  = "PETR4"} as Entidade);
            return Acoes;
        }
    }
    
    //concre Product
    public class RepositorioDeMedicos: IRepositorio
    {
        public void Salvar(Entidade Entidade)
        {
            throw new NotImplementedException();
        }

        public IList<Entidade> Retornar(Entidade Entidade)
        {
            throw new NotImplementedException();
        }
    }

    //Creator
    public interface IFabricaDeRepositorio
    {   
        IRepositorio CriarRepositorio(TipoDeRepositorio tipoDeRepositorio);
    }

    //Concrete Creator Factory
    public class FabricaDeRepositorioEntityFramework : IFabricaDeRepositorio
    {
        public IRepositorio CriarRepositorio(TipoDeRepositorio tipoDeRepositorio)
        {
            switch (tipoDeRepositorio)
            {
                case TipoDeRepositorio.CLIENTE: return (new RepositorioDeClientesNovo());
                case TipoDeRepositorio.FORNECEDOR: return (new RepositorioDeFornecedores());                
                default: throw new Exception("Repositório não Existe");
            }
        }
    }

    //Concrete Creator Factory
    public class FabricaDeRepositorioAdonet:IFabricaDeRepositorio
    {
        public IRepositorio CriarRepositorio(TipoDeRepositorio tipoDeRepositorio)
        { 
            switch (tipoDeRepositorio){
                case TipoDeRepositorio.CLIENTE: return (new RepositorioDeClientesEntityFramework()) ;
                case TipoDeRepositorio.FORNECEDOR: return (new RepositorioDeFornecedores());
                case TipoDeRepositorio.ACAO: return (new RepositorioDeAcao());
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
        public string Endereco { get; set; }
    }

    public class Fornecedor:Entidade{
        public string nome {get;set;}
        public string razaoSocial {get;set;}
    }

    public class Acao : Entidade
    {
        public string Codigo { get; set; }
        
    }


    public enum TipoDeRepositorio
    {
        CLIENTE,
        FORNECEDOR,
        REQUISICAO,
        ACAO
    }

    #endregion    


}
