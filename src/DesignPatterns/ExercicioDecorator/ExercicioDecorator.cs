using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public abstract class Texto
    {                
        public string texto {get;set;}
        
        public virtual string Formatar (){
            return texto;
        }
    }



    public class TextoHTML:Texto
    { 
       

        public override string  Formatar()
        {
            return texto;
        }
    }

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


    public class Bold : TipoFormatacao
    {


        public Bold(Texto tipoFormatacao)
            : base(tipoFormatacao)
        {
            tag = "B";
        }       
    }


    public class Center : TipoFormatacao
    {



        public Center(Texto tipoFormatacao)
            : base(tipoFormatacao)
        {
            tag = "CENTER";
        }
    }
}
