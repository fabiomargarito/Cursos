using System.Collections.Generic;

namespace MBCorpHealth.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T>
    {

        //server como atualização ou inclusão
        bool Gravar(T entidade);

        bool Excluir(T entidade);

        IList<T> ConsultarPorID(int identificador);

        IList<T> ConsultarPorTrechoNome(string nome);

        //   IList<T> retornarPorCPF(string CPF);             
    }
}