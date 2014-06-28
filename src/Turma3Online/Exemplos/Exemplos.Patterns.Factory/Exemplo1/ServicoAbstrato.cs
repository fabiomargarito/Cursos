namespace Exemplos.Patterns.Factory.Exemplo1 {

    //Creator
    public abstract class ServicoAbstrato {

        public ILog Log;

        protected ServicoAbstrato(ILog log) {
            Log = log;
        }

        public void ObterExibirNaTela(int id) {
            var nome = getDAO().ObterNome(id);
            Log.LogarEmTela(nome);
        }

        public abstract IDAO getDAO();
    }
    //Creator Concrete
}
