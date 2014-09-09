using System.Collections.Generic;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;

namespace HomeBrokerMBCorp.Infraestrutura.Persistencia
{
    public class RepositorioUsuarioNHibernate : IRepositorio<Usuario>
    {

        public void Gravar(Usuario usuario)
        {
            using (var session = (new ConfiguracaoNHibernate()).CriarSessionFactory().OpenSession())
            {
                session.SaveOrUpdate(usuario);
                session.Flush();
            }
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
