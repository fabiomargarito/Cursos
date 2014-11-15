using MBCorpHealth.Dominio;

public class ServicoDeVerificacaoDeCoberturaGolden : ServicoDeVerificacaoDeCoberturaBase, IServicoDeVerificacaoDeCobertura
{
    public bool VerificarCoberturaDoExame(Exame exame)
    {
        return false;
    }
}