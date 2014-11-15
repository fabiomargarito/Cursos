using MBCorpHealth.Dominio;

public class ServicoDeVerificacaoDeCoberturaBradesco :ServicoDeVerificacaoDeCoberturaBase, IServicoDeVerificacaoDeCobertura
{
    public bool VerificarCoberturaDoExame(Exame exame)
    {
        return false;
    }
}