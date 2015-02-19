using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Contratos;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Infraestrutura.ContextoCadastrosCorporativos
{
    public class AtendentesFake : IAtendentes
    {
        public bool Gravar(Atendente atendente)
        {
            return true;
        }
    }
}