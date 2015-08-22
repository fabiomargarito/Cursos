using System;
using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;
using JBSHealthCare.Dominio.Interface.Repositorio.BoundedContextGestaoDeAgendamentos;
using NHibernate;

namespace JBSHealthCare.Infraestrutura.Repositorio.BoundedContextGestaoDeAgendamentos
{
    public class Agendamentos : IAgendamentos
    {
        public bool Gravar(Agendamento agendamento)
        {
            using (ISession session = NHibernateSessionFactory.Criar().OpenSession())
            {
                session.SaveOrUpdate(agendamento);
            }
            
            return true;
        }
    }




       

    }

    

  