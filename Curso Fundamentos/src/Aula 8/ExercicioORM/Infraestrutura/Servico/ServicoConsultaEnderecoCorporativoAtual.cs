using MBCorpHealth.Dominio.Contratos.Servicos;

namespace MBCorpHealth.Dominio
{
    public class ServicoConsultaEnderecoCorporativoAtual : ServicoConsultaEndereco
    {
        public override Endereco ConsultarEnderecoPorCep(string cep)
        {
            //consultaria serviço corporativo atual
            return new Endereco("rua 1", "casa 1", "vila madalena", "São Paulo", "SP", "02234143");
        }
    }
}