using MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Entidades;

namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    class  LaudoEmitido:IEventoDeDominio
    {
        public Exame Exame{ get; set; }

        public LaudoEmitido(Exame exame)
        {
            Exame= exame;
        }
         
    }
}