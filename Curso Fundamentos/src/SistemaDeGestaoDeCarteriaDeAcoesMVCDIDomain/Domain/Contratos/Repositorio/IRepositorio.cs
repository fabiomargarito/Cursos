using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public interface IRepositorio<TEntidade>
    {
        void Gravar(TEntidade entidade);
        TEntidade RetornarPorID(int identificador);
        TEntidade RetornarPorID(string identificador);
        IList<TEntidade> ListarTodos();
        void Excluir(TEntidade entidade);
    }
}
