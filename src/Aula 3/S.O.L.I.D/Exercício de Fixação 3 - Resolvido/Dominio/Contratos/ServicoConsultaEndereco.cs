namespace MBCorpHealth.Dominio
{
    public abstract class ServicoConsultaEndereco
    {
        public string NomeServico { get; set; }
        public abstract Endereco ConsultarEnderecoPorCep(string cep);
    }
}