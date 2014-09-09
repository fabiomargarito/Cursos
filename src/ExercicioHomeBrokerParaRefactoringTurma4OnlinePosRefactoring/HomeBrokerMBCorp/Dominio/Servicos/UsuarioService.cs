using System;
using HomeBrokerMBCorp.Dominio.Contratos.Repositorio;
using HomeBrokerMBCorp.Infraestrutura.Persistencia;

namespace HomeBrokerMBCorp.Dominio.Servicos
{
    public class UsuarioService
    {
        private readonly IRepositorio<Usuario> _repositorio;

        public UsuarioService(IRepositorio<Usuario> repositorio )
        {
            _repositorio = repositorio;
        }

        public void Gravar(String cpf, string nome )
        {
            var usuario = new Usuario(cpf, nome);

            _repositorio.Gravar(usuario);
        }
    }
}