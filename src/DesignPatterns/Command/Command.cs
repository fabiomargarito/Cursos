using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    //Command
    public abstract class Comando
    {
        public virtual void executar(){        
        }
    }

    //Concrete command
    public class OrdemDeVenda : Comando
    {
        Corretora _corretora;
        public OrdemDeVenda(Corretora corretora)
        {
            _corretora = corretora;
        }

        public override void executar()
        {
            _corretora.Vender();
        }
    }
    //Concrete Command
    public class OrdemDeCompra : Comando
    {
        Corretora _corretora;
        public OrdemDeCompra(Corretora corretora)
        {
            _corretora = corretora;
        }

        public override void executar()
        {
            _corretora.Comprar();
        }
    }
       
    //Receiver
    public class Corretora
    {
        public  Corretora(){}
        public void Comprar(){
            Console.WriteLine("Comprar Ação");
        }
        public void Vender(){
            Console.WriteLine("Vender Ação");
        }
    }

    //Invoker
    public class Corretor {

        List<Comando> comandos = new List<Comando>();
        public Corretor() { }
        public void EnviarOrdem(Comando comando)
        {
            comandos.Add(comando);
            comando.executar();
        }    
    }
}
