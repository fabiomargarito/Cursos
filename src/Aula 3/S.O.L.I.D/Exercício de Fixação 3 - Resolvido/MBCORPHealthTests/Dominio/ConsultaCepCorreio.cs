namespace MBCORPHealthTests
{
    public  class ConsultaCepCorreio:ConsultaCepBase
    {
        public string CodigoAcesso { get; set; }

        public override Endereco Consultar(string cep)
        {
            //RetornoFake.Em um caso real recorreríamos ao serviço de consulta dos correios
            return new Endereco("02234150", "Rua Teste", " ", "Cangaíba", "São Paulo", "São Paulo");
        }
    }
}