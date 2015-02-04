using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Dominio.Contratos
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