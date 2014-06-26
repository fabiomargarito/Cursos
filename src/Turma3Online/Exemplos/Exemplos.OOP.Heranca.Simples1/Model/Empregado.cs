using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.OOP.Heranca.Simples1.Model {
    public class Empregado : Pessoa {
        public string Empresa { get; set; }
        public double Salario { get; set; }
    }
}
