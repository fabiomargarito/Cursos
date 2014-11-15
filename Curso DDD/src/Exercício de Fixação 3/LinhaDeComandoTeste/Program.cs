using MBCorpHealth.Aplicacao;
using MBCorpHealth.Dominio;

namespace LinhaDeComandoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var medicoServicoDePersistencia = new MedicoServicoDePersistencia();
            //medicoServicoDePersistencia.Gravar(new Medico("fabio", "1234", "abc"));

            var medicos = medicoServicoDePersistencia.ListarMedicos();
        }
    }
}
