using System;
using System.Collections.Generic;
using System.Linq;

public class Agendamento
{
    public ISet<Exame> Exames { get; private set; }
    public int ID { get; set; }
    public Atendente Atendente { get; private set; }
    public Paciente Paciente { get; private set; }
    public Medico MedicoSolicitante { get; private set; }



    public Agendamento(Paciente paciente, Medico medico, Atendente atendente)
    {
        Paciente = paciente;
        MedicoSolicitante = medico;
        Atendente = atendente;

        ID = int.MaxValue;
    }

    public void AdicionarExame(Exame tipoExame)
    {
        Exames = new HashSet<Exame>();
        Exames.Add(tipoExame);

    }
    
    public Double CalcularValorTotal()
    {
        Double valorTotal = Exames.Sum(exame => exame.TipoExame.Valor);
        return valorTotal;
    }
}