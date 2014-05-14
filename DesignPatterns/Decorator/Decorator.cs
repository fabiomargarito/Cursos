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

    //Concrete Componente
    public class Marguerita : Pizza
    {
        public Marguerita()
        {
            preco = 40;
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

    //Decorator
    public abstract class Cobertura : Pizza
    {        
        protected Pizza pizza;
        public Cobertura(Pizza pizzaParaAcrescentarCobetura)
        {
            pizza = pizzaParaAcrescentarCobetura;
        }
        
        public override double RetornarPreco()
        {
            return (pizza.RetornarPreco() + preco);
        }
    }

    
    

    
    //Concrete decorator
    public class QueijoExtra : Cobertura 
    {
        public QueijoExtra(Pizza pizzaParaAcrescentarCobetura): base(pizzaParaAcrescentarCobetura)
        {
            preco = 5;
        }
    }


    //Concrete Decorator
    public class MolhoExtra : Cobertura
    {
        public MolhoExtra(Pizza pizzaParaAcrescentarCobetura): base(pizzaParaAcrescentarCobetura)
        {
            preco = 8;
        }
    }


    //Concrete Decorator
    public class Cebola : Cobertura
    {
        public Cebola(Pizza pizzaParaAcrescentarCobetura)
            : base(pizzaParaAcrescentarCobetura)
        {
            preco = 10;
        }
    }


}
