using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Infraestrutura.ContextoCadastrosCorporativos
{
    public class TiposDeExamesFake : ITiposDeExames
    {
        public bool Gravar(TipoExame tipoExame)
        {
            return true;
        }
    }
}