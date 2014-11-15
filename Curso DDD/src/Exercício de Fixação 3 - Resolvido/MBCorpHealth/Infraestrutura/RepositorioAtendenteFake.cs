using MBCorpHealth.Dominio;

namespace TestesUnitarios
{
    public class RepositorioAtendenteFake : IRepositorioAtendente
    {
        public bool gravar(Atendente atendente)
        {
            return true;
        }
    }
}