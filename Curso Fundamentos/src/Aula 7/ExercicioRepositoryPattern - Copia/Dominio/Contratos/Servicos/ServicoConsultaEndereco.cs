namespace MBCorpHealth.Dominio.Contratos.Servicos
{
    public abstract class ServicoConsultaEndereco
    {
        public string NomeServico { get; set; }
        public abstract Endereco ConsultarEnderecoPorCep(string cep);
    }
}