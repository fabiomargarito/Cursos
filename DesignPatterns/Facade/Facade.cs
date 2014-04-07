using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
  
  public class Banco
  {
    public bool PossuiCreditoEmConta(Cliente cliente, double  valor)
    {
      Console.WriteLine(string.Format("Verificando se o cliente {0} possui saldo em conta ", cliente.Nome ));
      return true;
    }
  }

  public class SPC
  {
    public bool PossuiRestricao(Cliente cliente)
    {
      Console.WriteLine(string.Format("Verificando se o cliente {0} possui restrição no SERASA ", cliente.Nome ) );
      return true;
    }
  }
 
  public class Cliente
  {
    private string _nome;
    public Cliente(string nome)
    {
      _nome = nome;
    }

    public string Nome
    {
      get { return _nome; }
    }

  }

  public class Hipoteca
  {
    private Banco _banco = new Banco();
    private SPC _spc= new SPC();

    public bool EhElegivel(Cliente cliente, double valor)
    {
      Console.WriteLine("Verificando empréstimo no valor de {1:C}  para o cliente {0}\n",cliente.Nome, valor);
 
      bool ehElegivel = true;
     
      if (!_banco.PossuiCreditoEmConta(cliente , valor))
        ehElegivel = false;


        if (!_spc.PossuiRestricao(cliente))
            ehElegivel = false;
        

        return ehElegivel;
    }
  }
}

