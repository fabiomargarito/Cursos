using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
 
    
    
    public class Pedido
    {
        public int Codigo { get;}
        private IList<ItemDePedido> Itens { get; set; }


        public Pedido() 
        {
            Itens = new List<ItemDePedido>();
        }

        public void AdicionarItem(ItemDePedido itemDePedido)
        {
            
            Itens.Add(itemDePedido);
        }

        
    }

    public class ItemDePedido
    {
    }

    public class Produto
    {
       public string Codigo { get; set; }
       public string Nome { get; set; }

        
    }


    public class ServicoDePersistenciaDeProduto
    {
        public void Gravar(Produto produto)
        {
            //metodo
        }

    }


    public class ServicoDeProcessamentoDePedido
    {
        public int ProcessarPedido(Pedido pedido)
        {
            return 1;
        }    
    }



}
