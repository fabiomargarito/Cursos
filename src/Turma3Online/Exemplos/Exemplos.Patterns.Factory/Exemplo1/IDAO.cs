namespace Exemplos.Patterns.Factory.Exemplo1
{
    public interface IDAO {
        void Inserir(string nome);
        void Excluir(int id);
        string ObterNome(int id);
    }
}