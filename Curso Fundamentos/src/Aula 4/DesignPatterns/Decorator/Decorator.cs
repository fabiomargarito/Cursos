using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
 
    //Componente
    public abstract class Pizza
    {
        protected double preco;
        
        public virtual double RetornarPreco()
        {
            return this.preco;
        }
    }   

    //concrete componente
    public class Sorvete : Pizza
    {
        public Sorvete()
        {
            preco = 30;
        }
    }

    //Concrete Componente
    public class Marguerita : Pizza
    {
        public Marguerita()
        {
            preco = 40;
        }
    }

    public class Alcachofrinha : Pizza
    {
        public Alcachofrinha()
        {
            preco = 55;
        }
    }

    //Concrete Componente
    public class Atum : Pizza
    {
        public Atum()
        {
            preco = 50;
        }
    }

   //Concrete Componente
    public class Casteloes : Pizza
    {
        public Casteloes()
        {
            preco = 60;
        }
    }


    //Decorator
    public abstract class Ingrediente : Pizza
    {        
        protected Pizza pizza;

        public Ingrediente(Pizza pizzaParaAcrescentarCobetura)
        {
            pizza = pizzaParaAcrescentarCobetura;
        }
        
        public override double RetornarPreco()
        {
            return (pizza.RetornarPreco() + preco);
        }
    }
        
    
    //Concrete decorator
    public class QueijoExtra : Ingrediente 
    {
        public QueijoExtra(Pizza pizzaParaAcrescentarCobetura): base(pizzaParaAcrescentarCobetura)
        {
            preco = 5;
        }
    }


    //Concrete Decorator
    public class MolhoExtra : Ingrediente
    {
        public MolhoExtra(Pizza pizzaParaAcrescentarCobetura): base(pizzaParaAcrescentarCobetura)
        {
            preco = 8;
        }
    }


    //Concrete Decorator
    public class Cebola : Ingrediente
    {
        public Cebola(Pizza pizzaParaAcrescentarCobetura)
            : base(pizzaParaAcrescentarCobetura)
        {
            preco = 10;
        }
    }

    public class Aliche:Ingrediente
    {
        public Aliche(Pizza pizzaParaAcrescentarCobetura) : base(pizzaParaAcrescentarCobetura)
        {
            preco = 30;
        }
    }

    public class Tomate : Ingrediente
    {
        public Tomate(Pizza pizzaParaAcrescentarCobetura)
            : base(pizzaParaAcrescentarCobetura)
        {
            preco = 12;
        }
    }

}
