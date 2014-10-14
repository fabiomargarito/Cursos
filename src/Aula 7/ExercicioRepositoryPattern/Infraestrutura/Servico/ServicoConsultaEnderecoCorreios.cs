using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Dominio
{
    public class ServicoConsultaEnderecoCorreios : ServicoConsultaEndereco
    {
        public override Endereco ConsultarEnderecoPorCep(string cep)
        {
            //consultaria serviço web dos correios
            return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
        }
    }
}