using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Microsoft.Practices.Unity;

namespace Dominio
{
    public class Carteira
    {                  
        public Cliente Cliente { get; set; }
        public List<Operacao> Operacoes { get; set; }
        public void AdicionarOperacao(Operacao operacao)
        {
            if (Operacoes == null)
                Operacoes = new List<Operacao>();
            Operacoes.Add(operacao);
        }                
    }
}