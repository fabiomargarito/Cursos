using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //teste
    public class Operacao
    {
        public int ID { get; set; }
        public TipoOperacao Tipo { get; set; }
        public Acao Acao { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }

    public enum TipoOperacao
    {
        C,
        V
    }
}
