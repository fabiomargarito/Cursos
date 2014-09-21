using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrokerMBCorp.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T>
    {
        void Gravar(T entidadeDeNegocio);
        IList<T> ListarTodos();
        T RetornarPorID(string id);
    }
}
