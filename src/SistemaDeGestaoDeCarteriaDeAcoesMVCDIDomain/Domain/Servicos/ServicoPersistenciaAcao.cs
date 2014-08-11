
using Microsoft.Practices.Unity;
using Infraestrutura;

namespace Domain
{
    public class ServicoPersistenciaAcao
    {
        [Dependency]
        public IRepositorio<Acao> Repositorio { get; set; }
 
        public bool Gravar(Acao acao )
        {
            Repositorio.Gravar(acao);
            return true;
        }
    }
}