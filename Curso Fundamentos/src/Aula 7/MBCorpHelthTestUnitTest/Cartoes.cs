using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHelthTestUnitTest
{
    public class Cartoes : IRepositorio<Cartao>
    {
        public bool Gravar(Cartao entidade)
        {
            return true;
        }

        public bool Excluir(Cartao entidade)
        {
            return true;
        }

        public IList<Cartao> ConsultarPorID(int identificador)
        {
            throw new NotImplementedException();
        }

        public IList<Cartao> ConsultarPorTrechoNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}