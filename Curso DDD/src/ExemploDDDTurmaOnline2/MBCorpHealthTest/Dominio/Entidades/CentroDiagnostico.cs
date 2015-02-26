namespace MBCorpHealthTest.Dominio.Entidades
{
    public class CentroDiagnostico
    {
        public CentroDiagnostico()
        {
        }

        public string CNPJ { get; private set; }
        public string RazaoSocial { get; set; }

        public CentroDiagnostico(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}