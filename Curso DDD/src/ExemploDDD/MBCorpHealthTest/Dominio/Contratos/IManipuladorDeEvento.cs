namespace MBCorpHealthTest.Dominio.Contratos
{
    public interface IManipuladorDeEvento<T> where T : IEventoDeDominio
    {
        void ManipularEvento(T evento);
    }
}