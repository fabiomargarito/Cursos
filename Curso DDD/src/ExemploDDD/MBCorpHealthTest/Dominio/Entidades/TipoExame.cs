using System;

public class TipoExame
{
    //Classificação Brasileira Hierarquizada de Procedimentos Médicos
    public TipoExame(string cbhpm, string descricao, Double valor)
    {
        CBHPM = cbhpm;
        Descricao = descricao;
        Valor = valor;
    }

    public string CBHPM { get; private set; }
    public string Descricao { get; private set; }
    public double Valor { get; set; }

    //Todo Criar método de validação
}