using JBSMedical.AgendamentoBoundedContext.Infraestrutura.Contratos;

namespace JBSMedical.AgendamentoBoundedContext.Infraestrutura.Servicos
{
    public class ServicoDePagamentoPagSeguro : IServicoDePagamento
    {
        public string SolicitarCobranca(double valorDaFatura, string emailCliente)
        {
            Pagseguro.ServicoDePagamento pagseguro = new Pagseguro.ServicoDePagamento();
            return pagseguro.SolicitarCobranca(valorDaFatura, emailCliente,"meucodigodecliente");
        }
    }

    
}