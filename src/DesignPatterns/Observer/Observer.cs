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

    public void Cadastrar(IInvestidor investidor)
    {
      _investidores.Add(investidor);
    }

    public void RemoverDoCadastro(IInvestidor investidor)
    {
      _investidores.Remove(investidor);
    }
 
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
  public class VALE : Acao
  {
    public VALE(string codigo, double preco): base(codigo, preco)
    {
    }
  }

 //Observer
  public interface IInvestidor
  {
    void Atualizar(Acao acao);
  }

  // 'ConcreteObserver' 
  public class Investidor : IInvestidor
  {
    private string _nome;    
    public Investidor(string nome)
    {
      this._nome = nome;
    }
    public void Atualizar(Acao acao)
    {
      Console.WriteLine("Notificado {0} da  mudança da ação {1}  para o valor {2:C}", _nome, acao.Codigo, acao.Preco);
    }    
  }
}

