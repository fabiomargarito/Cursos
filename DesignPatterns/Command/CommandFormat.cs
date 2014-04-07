using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExercicioDecorator;


namespace CommandFormat
{

    
    //Command
    public class Comando
    {
        
        public virtual void formatar()
        {
        }
    }


    //Invoker
    public class Editor
    {

        int PosicaoAtual = 0;

        List<Comando> comandos = new List<Comando>();
        public Editor() {        
        }
        public void EnviarComando(Comando comando)
        {
            comandos.Add(comando);
            PosicaoAtual = comandos.Count;
            
        }

        public void FormatarTudo()
        {
           comandos.Last<Comando>().formatar();
        }

        public void Undo() {

            comandos[PosicaoAtual - 2].formatar();
            PosicaoAtual = PosicaoAtual - 2;
        }
        
        public void ReUndo()
        {

            
            PosicaoAtual = PosicaoAtual + 1;
            comandos[PosicaoAtual].formatar();

        }
    }


    //Receiver
    public class HTMLParser
    {
        public TipoFormatacao _tipoFormatacao{get;set;}
        public HTMLParser() {
            
        }
        public void Formatar()
        {
            _tipoFormatacao.Formatar(); 
        }

    }


    
    //Concrete command
    public class Formatar : Comando
    {
        HTMLParser _htmlParser;
        TipoFormatacao _tipoFormatacao;

        public Formatar(HTMLParser htmlParser, TipoFormatacao tipoFormatacao)
        {
            _htmlParser = htmlParser;
            _tipoFormatacao = tipoFormatacao;
        }

        public override void formatar()
        {
            _htmlParser._tipoFormatacao = _tipoFormatacao;
            Console.WriteLine(_htmlParser._tipoFormatacao.Formatar());
            
        }

                }
    }

