namespace MBCorpHealthTestTests
{
    public class CentroDiagnostico
    {
        public string CNPJ { get; private set; }

        public CentroDiagnostico(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}