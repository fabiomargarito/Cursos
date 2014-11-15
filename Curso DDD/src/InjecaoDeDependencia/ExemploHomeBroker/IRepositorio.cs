using System.Collections.Generic;

namespace Dominio
{
    public interface IRepositorio<Entidade>
    {
        bool Gravar(Entidade entidade);
        Entidade Retornar(int id); 
    }
}