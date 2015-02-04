using System;

namespace MBCorpHealthTest.Dominio.Contratos
{
    class EnviarEmailParaPacienteQuandoLaudoEmitido:IManipuladorDeEvento<LaudoEmitido>
    {
        public void ManipularEvento(LaudoEmitido evento)
        {
            Console.WriteLine(string.Format("Resultado do Exame {0} disponível para consulta", evento.Exame.Laudo.Descricao));
        }
    }
}