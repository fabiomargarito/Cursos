using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHealthUnitTest
{
    public class RepositorioCartaoMock : IRepositorio<Cartao>
    {
        public bool Gravar(Cartao entidade)
        {
            return true;
        }

        public IList<Cartao> retornarPorCPF(string CPF)
        {
            throw new System.NotImplementedException();
        }

        public List<Cartao> RetornarTodos()
        {
            List<Cartao> cartoes = new List<Cartao>();
            cartoes.Add(new Cartao("123","Fabio M M Barros","123"));
            cartoes.Add(new Cartao("122", "Jose Otavio", "456"));

            return cartoes;

        }
    }
}