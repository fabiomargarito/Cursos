using System;
using System.Collections.Generic;
using System.Linq;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public   class Agendamento
    {
        public Agendamento()
        {
        }

        public virtual  IList<Exame> Exames { get; protected set; }
        public virtual  int ID { get; set; }
        public virtual  Atendente Atendente { get; protected set; }
        public virtual  Paciente Paciente { get; protected set; }
        public virtual  Medico MedicoSolicitante { get; protected set; }
        public virtual  Credencial Credencial{ get;  set; }
        


        public   Agendamento(Paciente paciente, Medico medico, Atendente atendente)
        {
            Paciente = paciente;
            MedicoSolicitante = medico;
            Atendente = atendente;

            ID = int.MaxValue;
        }

        public virtual  void AdicionarExame(Exame tipoExame)
        {
            Exames = new List<Exame>();
            Exames.Add(tipoExame);

        }
    
        public virtual  Double CalcularValorTotal()
        {
            Double valorTotal = Exames.Sum(exame => exame.TipoExame.Valor);
            return valorTotal;
        }
    }
}