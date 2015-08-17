using FluentNHibernate.Mapping;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Interface.Repositorio;
using NHibernate;
using TestesUnitarios;

namespace JBSHealthCare.Infraestrutura.Repositorio
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

    

  