using ExemploModulo3InjecaoDeDependencia;

namespace Dominio
{
    public class CarteiraService
    {
        private readonly ILog _log;
        private readonly IRepositorio<Carteira> _carteiraRepositorio;


        public CarteiraService(ILog log,IRepositorio<Carteira> carteiraRepositorio )
        {
            _log = log;
            _carteiraRepositorio = carteiraRepositorio;
        }

        public bool RegistrarOperacaoDeCompra(Operacao operacao, Carteira  carteira)
        {            
            _log.Registrar(TipoLog.Informacao, "Operacao De Compra Registrada");
            return _carteiraRepositorio.Gravar(carteira);
            
        }


        public bool RegistrarOperacaoDeVenda(Operacao operacao, Carteira carteira)
        {                       
            _log.Registrar(TipoLog.Informacao, "Operacao De Venda Registrada");
            return _carteiraRepositorio.Gravar(carteira);
        }        
    }
}