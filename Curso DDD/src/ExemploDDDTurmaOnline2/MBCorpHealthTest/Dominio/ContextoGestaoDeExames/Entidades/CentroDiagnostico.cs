namespace MBCorpHealthTest.Dominio.Entidades
{
    public class CentroDiagnostico
    {
        public CentroDiagnostico()
        {
        }

        public virtual string CNPJ { get; protected set; }
        public virtual string RazaoSocial { get; protected set; }

        public CentroDiagnostico(string cnpj)
        {
            CNPJ = cnpj;
        }
    }
}