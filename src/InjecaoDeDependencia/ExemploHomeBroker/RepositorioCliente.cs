using System;
namespace Dominio

{
    public class RepositorioClienteFake:IRepositorio<Cliente>
    {
        public bool Gravar(Cliente cliente)
        {
            return true;
        }

        public Cliente Retornar(int id)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Cliente Teste";
            cliente.CPF = "28440492812";            

            Carteira carteira = new Carteira();
            carteira.Cliente = cliente;
            
            Operacao operacao = new Operacao();
            operacao.Acao = new Acao{Codigo = "PETR4", Cotacao = new Cotacao{Data = DateTime.Now,Valor = 14},Empresa = new Empresa{CNPJ = "12345678900011",RazaoSocial = "PETROBRAS"}};

            carteira.AdicionarOperacao(operacao);

            return cliente;
        }
    }
    
}