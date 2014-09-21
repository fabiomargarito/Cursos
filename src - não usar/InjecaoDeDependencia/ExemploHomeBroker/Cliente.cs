using System.Runtime.CompilerServices;
using Microsoft.Practices.Unity;
using Ninject;

namespace Dominio
{
    public class Cliente
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
        

        [Microsoft.Practices.Unity.Dependency]
        [Inject]
        public virtual IRepositorio<Cliente> RepositorioCliente { get; set; }        

        public virtual bool Gravar()
        {
            return RepositorioCliente.Gravar(this);
        }
    }       
}