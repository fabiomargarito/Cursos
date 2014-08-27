using System.Collections.Generic;

namespace HomeBrokerMBCorp.Dominio
{
    public class Corretora
    {
        public Corretora(string cnpj, string nome)
        {
            CNPJ = cnpj;
            Nome = nome;
        }

        public string CNPJ { get; private set; }
        public string Nome { get; private set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Ordem> Ordens { get; set; } 


        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void AdicionarOrdem(Ordem ordem)
        {
            Ordens.Add(ordem);
        }

        public void RemoverOrdem(Ordem ordem)
        {
            Ordens.Remove(ordem);
        }


    }
}