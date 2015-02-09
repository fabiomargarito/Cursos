namespace MBCorpHealthTest.Dominio.ContextoAdministracaoDeAgendamentosDeExame.Contratos
{
    public interface IManipuladorDeEvento<T> where T : IEventoDeDominio
    {
        void ManipularEvento(T evento);
    }
}