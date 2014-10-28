namespace Dominio
{
    public class RepositorioCarteiraFake : IRepositorio<Carteira>
    {
        public bool Gravar(Carteira entidade)
        {
            return true;
        }

        public Carteira Retornar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}