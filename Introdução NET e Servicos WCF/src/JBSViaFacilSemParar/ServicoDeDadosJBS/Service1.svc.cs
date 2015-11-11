using System.Collections.Generic;
using JBSDAL;

namespace ServicoDeDadosJBS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicoDeDadosJBS : IServicoDeDadosJBS
    {
        public bool InserirVeiculo(VeiculoDTO veiculo)
        {
            DALVEICULOS dalveiculos = new DALVEICULOS();
            return dalveiculos.InserirVeiculo(veiculo);
        }

        public IList<VeiculoDTO> RetornarListaDeVeiculos()
        {
            DALVEICULOS dalveiculos = new DALVEICULOS();
            return dalveiculos.RetornarListaDeVeiculos();
        }
    }
}
