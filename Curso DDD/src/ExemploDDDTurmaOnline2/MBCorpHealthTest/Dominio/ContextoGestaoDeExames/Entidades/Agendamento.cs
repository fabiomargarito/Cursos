using System;
using System.Collections.Generic;
using System.Linq;
using MBCorpHealthTest.Dominio.ObjetosDeValor;

namespace MBCorpHealthTest.Dominio.Entidades
{
    public  class Agendamento
    {
        //Identificador da Entidade
        public Agendamento()
        {
        }

        public virtual string Numero { get; protected set; }

        public Agendamento(Atendente atendente, Medico medico)
        {
            Atendente = atendente;            
            Medico = medico;
            Exames = new List<Exame>();
            Numero = Guid.NewGuid().ToString();
        }

        public virtual Medico Medico { get; protected set; }
        public virtual Paciente Paciente { get; protected set; }
        public virtual Atendente Atendente { get; protected set; }
        public virtual CID CID { get; protected set; }
        public virtual IEnumerable<Exame> Exames
        { get; set; }

        public virtual void InformarPaciente(Paciente paciente)
        {
            Paciente = paciente;
        }

        public virtual void InformarCID(CID cid)
        {
            CID = cid;
        }

        public virtual void AdicionarExame(Exame exame)
        {
            if(exame ==null)
                throw new Exception("É necessário informar um exame válido");

            (Exames as IList<Exame>).Add(exame);
        }

        public virtual double CalcularValorTotal()
        {
            return Exames.Sum(exame => exame.TipoExame.Preco);
        }
    }
}