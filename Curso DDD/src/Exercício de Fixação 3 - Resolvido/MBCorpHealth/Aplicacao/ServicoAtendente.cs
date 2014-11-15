using MBCorpHealth.Dominio;

namespace TestesUnitarios
{
    public class ServicoAtendente
    {
        private readonly IRepositorioAtendente _repositorioAtendente;

        public ServicoAtendente(IRepositorioAtendente repositorioAtendente)
        {
            _repositorioAtendente = repositorioAtendente;
        }

        public bool gravar(AtendenteViewModel atendente)
        {
            return _repositorioAtendente.gravar(new Atendente(atendente.Nome, atendente.Cpf, atendente.NumeroMatricula));
        }
    }
}