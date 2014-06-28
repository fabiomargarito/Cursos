namespace Exemplos.Patterns.Factory.Exemplo1 {
    public class ClienteServico : ServicoAbstrato {

        public ClienteServico(ILog log)
            : base(log) {
        }


        public override IDAO getDAO() {
            return new ClienteDAO();
        }
    }
}