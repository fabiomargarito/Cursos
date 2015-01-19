public class Exame
{

    public Exame(TipoExame tipoExame)
    {
        TipoExame = tipoExame;
    }

    public TipoExame TipoExame { get; private set; }
    public Laudo Laudo { get; private set; }

    public void EmitirLaudo(Laudo laudo)
    {
        Laudo = laudo;

    }
}