using System;
using System.Collections.Generic;
using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;

namespace JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos
{
    public class Agendamento
    {
        public Agendamento()
        {
        }

        public virtual int ID { get; protected set; }

        public virtual Medico Medico
        {
            get; protected set;}


        public virtual Paciente Paciente { get; protected set; }
        public virtual CID Cid { get; protected set; }

        public virtual IEnumerable<Exame> Exames { get; protected set; }

        public virtual void InformarMedico(Medico medico)
        {
            Medico = medico;
        }

        public virtual void InformarCID(CID cid)
        {
            Cid = cid;
        }

        public virtual void InformarPaciente(Paciente paciente)
        {
            Paciente = paciente;
        }

        public virtual void AdicionarExame(Exame exame)
        {
            if(Exames==null)
                Exames = new List<Exame>();

            if(exame.ID ==null)
                throw new Exception("ID inválido");

            ((IList<Exame>) Exames).Add(exame);
           
        }
    }


}