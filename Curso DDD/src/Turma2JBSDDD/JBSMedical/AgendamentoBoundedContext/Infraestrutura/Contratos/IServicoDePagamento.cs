namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Contratos
{
    public interface IServicoDePagamento
    {
        string SolicitarCobranca(double valorDaFatura, string emailCliente);
    }
}