using Microsoft.Practices.Unity;
using Ninject;

namespace Dominio
{
    public class Corretora
    {
        public string Nome { get; set; }
        private IRepositorio<Corretora> _repositorioCorretora;
            
        [InjectionMethod]
        [Inject]
        public void Inicializar(IRepositorio<Corretora> repositorioCorretora)
        {
            _repositorioCorretora = repositorioCorretora;
        }

        
        public bool Gravar()
        {
            return _repositorioCorretora.Gravar(this);
        }
    }
}