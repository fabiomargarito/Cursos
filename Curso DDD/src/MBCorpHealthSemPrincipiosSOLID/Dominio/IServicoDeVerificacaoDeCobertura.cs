using MBCorpHealth.Dominio;

public interface IServicoDeVerificacaoDeCobertura
{
    bool VerificarCoberturaDoExame(Exame exame);
    string CNPJ { get; set; }
}