using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Contratos
{
    public interface IAtendentes
    {
        bool Gravar(Atendente atendente);
    }
}