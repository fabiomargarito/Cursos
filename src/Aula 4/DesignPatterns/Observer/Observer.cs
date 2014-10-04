using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{

  //Subject
  public abstract class Acao
  {
    private string _codigo;
    private double _preco;

    private  List<IInvestidor> _investidores = new List<IInvestidor>();

    public Acao(string codigo, double preco)
    {
      this._codigo = codigo;
      this._preco = preco;
    }

    //attach
    public void Cadastrar(IInvestidor investidor)
    {
      _investidores.Add(investidor);
    }

    //dattach
    public void RemoverDoCadastro(IInvestidor investidor)
    {
      _investidores.Remove(investidor);
    }
 
    //notify
    public void Notificar()
    {
      foreach (IInvestidor investidor in _investidores)
      {
        investidor.Atualizar(this);
      }      
    }






     

    public double Preco
    {
      get { return _preco; }
      set{
        if (_preco != value)
        {
          _preco = value;
          Notificar();
        }
      }
    }

    public string Codigo
    {
      get { return _codigo; }
    }
  }
  
  //Concrete Subject
  public class VALE3 : Acao
  {
    public VALE3(string codigo, double preco): base(codigo, preco)
    {
    }
  }

  //Concrete Subject
    public class PETR3:Acao
    {
        public PETR3(string codigo, double preco) : base(codigo, preco)
        {
        }
    }

    //Concrete Subject
    public class PETR4 : Acao
    {
        public PETR4(string codigo, double preco)
            : base(codigo, preco)
        {
        }
    }


    //Observer
  public interface IInvestidor
  {
    void Atualizar(Acao acao);
  }

  // 'ConcreteObserver' 
  public class InvestidorPessoaFisica : IInvestidor
  {
    private string _nome;    
    public InvestidorPessoaFisica(string nome)
    {
      this._nome = nome;
    }
    public void Atualizar(Acao acao)
    {
      Console.WriteLine("Notificado {0} da  mudança da ação {1}  para o valor {2:C}", _nome, acao.Codigo, acao.Preco);
    }    
  }

  // 'ConcreteObserver' 
  public class InvestidorPessoaJuridica : IInvestidor
  {
      private string _nome;
     private string _cnpj;
      private readonly IServicoCompraDeAcao _servicoCompraDeAcao;


      public InvestidorPessoaJuridica(string nome, string cnpj, IServicoCompraDeAcao servicoCompraDeAcao)
      {
          this._nome = nome;
         this._cnpj = cnpj;
          _servicoCompraDeAcao = servicoCompraDeAcao;
          
      }
      public void Atualizar(Acao acao)
      {
          Console.WriteLine("Notificado {0}  CNPJ {1} da  mudança da ação {2}  para o valor {3:C}", _nome,_cnpj, acao.Codigo, acao.Preco);          
          _servicoCompraDeAcao.Comprar(acao);
      }
  }

    public interface IServicoCompraDeAcao
    {
        void Comprar(Acao acao);
    }


    public class ServicoCompraAcaoItauTrade : IServicoCompraDeAcao
    {
        public void Comprar(Acao acao)
        {
            
        }
    }

}

