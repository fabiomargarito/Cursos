using System.Collections.Generic;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;

namespace HomeBrokerMBCorp.Infraestrutura.Persistencia
{
    public class RepositorioUsuarioFake : IRepositorio<Usuario>
    {

        public void Gravar(Usuario usuario)
        {
        }

        public IList<Usuario> ListarTodos()
        {
            IList<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario("123", "Fabio"));
            usuarios.Add(new Usuario("1234", "Silvio"));
            return usuarios;
        }

        public Usuario RetornarPorID(string id)
        {
            return new Usuario("1234", "Fabio Margarito");
        }        
    }

}
