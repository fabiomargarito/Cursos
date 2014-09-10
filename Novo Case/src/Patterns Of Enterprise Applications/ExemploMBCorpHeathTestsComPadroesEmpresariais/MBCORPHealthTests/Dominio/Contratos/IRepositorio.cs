using System.Collections.Generic;

namespace TestesUnitarios
{
    public interface IRepositorio<T>
    {
        bool Gravar(T entidade);
        List<T> ListarTodos();
    }
}