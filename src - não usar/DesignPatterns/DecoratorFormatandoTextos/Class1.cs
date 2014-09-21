using System;

namespace DecoratorFormatandoTextos
{

//Componente
 public abstract class Texto
    {                
        public string texto {get;set;}
        
        public virtual string Formatar (){
            return texto;
        }
    }

    //Concrete Componente
    public class TextoHTML:Texto
    { 
       

        public override string  Formatar()
        {
            return texto;
        }
    }

    //Decorator
    public class TipoFormatacao : Texto {

        public string tag;
        protected Texto _tipoFormatacao;

        public TipoFormatacao(Texto tipoFormatacao) {
            _tipoFormatacao = tipoFormatacao;
        }

        public override string Formatar()
        {
            return String.Format("<{0}>{1}<\\{2}>",tag ,_tipoFormatacao.Formatar(),tag);
        }
    }

    //Concrete Decorator
    public class Bold : TipoFormatacao
    {


        public Bold(Texto tipoFormatacao)
            : base(tipoFormatacao)
        {
            tag = "B";
        }       
    }

    //Concrete Decorator
    public class Center : TipoFormatacao
    {



        public Center(Texto tipoFormatacao)
            : base(tipoFormatacao)
        {
            tag = "CENTER";
        }
    }
}

