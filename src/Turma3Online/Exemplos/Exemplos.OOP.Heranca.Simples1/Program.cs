using System;
using Exemplos.OOP.Heranca.Simples1.Model;

namespace Exemplos.OOP.Heranca.Simples1 {
    class Program {
        static void Main(string[] args) {

            var pessoas = new Pessoa[]
                {
                    new Empregado() { Nome = "Huguinho" }, 
                    new Estudante() { Nome = "Zezinho Estudantes" }
                };

            foreach (var pessoa in pessoas) {
                Console.Write(pessoa.Nome);
            }

            System.Console.ReadLine();
        }
    }
}
