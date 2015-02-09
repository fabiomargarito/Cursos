using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Contratos
{
    public interface ITiposDeExames
    {
        bool Gravar(TipoExame tipoExame);
    }
}