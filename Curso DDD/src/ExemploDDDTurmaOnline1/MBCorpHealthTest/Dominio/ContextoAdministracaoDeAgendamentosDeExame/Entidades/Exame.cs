using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos;
using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.EventosDeDominio;
using MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades
{
    public class Exame
    {
        public Exame(TipoExame tipoExame)
        {
            TipoExame = tipoExame;
        }

        protected Exame()
        {
        }

        public TipoExame TipoExame { get; protected set; }
        public Laudo Laudo { get; protected set; }

        public void EmitirLaudo(Laudo laudo)
        {
            Laudo = laudo;
            EventosDoDominio.Disparar(new LaudoEmitido(this));
        }
    }
}