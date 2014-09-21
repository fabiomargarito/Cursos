using System.Collections.Generic;
using HomeBrokerMBCorp.Dominio;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;

namespace HomeBrokerMBCorp.Infraestrutura.Persistencia
{
    public class RepositorioEmpresaFake : IRepositorio<Empresa>
    {

        public void Gravar(Empresa empresa)
        {
            
        }

        public IList<Empresa> ListarTodos()
        {
            IList<Empresa> empresas = new List<Empresa>();
            empresas.Add(new Empresa("1234", "RazaoSocial"));
            empresas.Add(new Empresa("12345", "RazaoSocial2"));            
 
            return empresas;
        }

        public Empresa RetornarPorID(string id)
        {
            return new Empresa("1234", "RazaoSocial");            
        }
    }
}
