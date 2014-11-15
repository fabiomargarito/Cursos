using MBCorpHealth.Dominio;

public class ServicoDeVerificacaoDeCoberturaPorto : ServicoDeVerificacaoDeCoberturaBase,IServicoDeVerificacaoDeCobertura
{
     

    public bool VerificarCoberturaDoExame(Exame exame)
    {
        //consulta web service da porto
        return true;
            
    }
}