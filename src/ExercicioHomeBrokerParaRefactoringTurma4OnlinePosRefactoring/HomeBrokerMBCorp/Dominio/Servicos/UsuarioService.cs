using System;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;

namespace HomeBrokerMBCorp.Dominio.Servicos
{
    public class UsuarioService
    {
        
        public void Gravar(String cpf, string Nome, IRepositorio<Usuario> repositorio )
        {
            var usuario = new Usuario(cpf, Nome);

            repositorio.Gravar(usuario);
        }
    }
}