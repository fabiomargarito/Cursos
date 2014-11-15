using MBCorpHealth.Dominio;

public class ServicoDeVerificacaoDeCoberturaAmil : ServicoDeVerificacaoDeCoberturaBase,IServicoDeVerificacaoDeCobertura
{
    public bool VerificarCoberturaDoExame(Exame exame)
    {
        return true;
    }
}