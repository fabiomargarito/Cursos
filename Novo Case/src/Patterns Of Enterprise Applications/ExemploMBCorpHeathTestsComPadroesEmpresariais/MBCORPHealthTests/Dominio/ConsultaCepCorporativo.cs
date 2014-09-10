namespace MBCORPHealthTests
{
    public  class ConsultaCepCorporativo : ConsultaCepBase
    {
        public ConsultaCepCorporativo()
        {
        }

        public  override Endereco Consultar(string cep)
        {
            //RetornoFake. Em um caso real recorreríamos ao serviço interno da empresa
            return new Endereco("02234150", "Rua Teste", " " ,"Cangaíba", "São Paulo", "São Paulo");
        }
    }
}