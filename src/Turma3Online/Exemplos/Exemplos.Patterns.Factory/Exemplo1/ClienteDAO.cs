using System;

namespace Exemplos.Patterns.Factory.Exemplo1 {
    public class ClienteDAO : IDAO {

        public void Inserir(string nome) {
            Console.WriteLine("Inserindo '{0}'...", nome);
        }

        public void Excluir(int id) {
            Console.WriteLine("Excluindo {0}...", id);
        }

        public string ObterNome(int id) {
            return "Meu nome não é Jonhy. =|";
        }
    }
}