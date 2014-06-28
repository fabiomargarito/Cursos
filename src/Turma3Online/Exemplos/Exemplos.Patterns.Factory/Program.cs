using System;
using Exemplos.Patterns.Factory.Exemplo1;

namespace Exemplos.Patterns.Factory {
    class Program {
        static void Main(string[] args) {

            LogEmTela log = new LogEmTela();
            ServicoAbstrato creator = new ClienteServico(log);
            IDAO product = creator.getDAO();

            product.Inserir("joão");
            product.Excluir(1);

            creator.ObterExibirNaTela(1);

            Console.ReadLine();
        }
    }
}
