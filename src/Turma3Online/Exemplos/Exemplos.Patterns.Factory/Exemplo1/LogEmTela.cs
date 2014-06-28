using System;

namespace Exemplos.Patterns.Factory.Exemplo1 {
    class LogEmTela : ILog {
        public void LogarEmTela(string texto) {
            Console.WriteLine(texto);
        }
    }
}
