using Dominio;

namespace ExemploModulo3InjecaoDeDependencia
{
    public class RepositorioCorretoraFake :IRepositorio<Corretora>
    {
        public bool Gravar(Corretora entidade)
        {
            return true;
        }

        public Corretora Retornar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}