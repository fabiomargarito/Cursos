using FluentNHibernate.Mapping;
using JBSMedical.Dominio.Entidades;

namespace JBSMedical.Infraestrutura.Repositorios
{

    public class MapeamentoAgendamento : ClassMap<Agendamento>
    {
        public MapeamentoAgendamento()
        {
            Id(key => key.ID).Column("IDAGENDAMENTO").UnsavedValue(-1).GeneratedBy.Identity();            
            References(campo => campo.Medico).Column("NOCRM").Cascade.SaveUpdate();
            References(campo => campo.Paciente).Column("NOCPF").Cascade.SaveUpdate();
            HasMany(key => key.Exames).KeyColumn("IDAGENDAMENTO").Cascade.SaveUpdate();
            Table("TBAGENDAMENTO");
        }
    }
    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(key => key.CPF).Column("NOCPF");
            Map(campo => campo.Nome).Column("NMNOME");
            References(campo => campo.PlanoDeSaude).Column("NOCNPJ").Cascade.SaveUpdate();
            Table("TBPACIENTE");            
        }
    }


    public class MapeamentoPlanoDeSaude : ClassMap<PlanoDeSaude>
    {
        public MapeamentoPlanoDeSaude()
        {
            Id(key => key.CNPJ).Column("NOCNPJ");
            Map(campo => campo.RazaoSocial).Column("NMRazaoSocial");
            Table("TBPLANODESAUDE");            
        }
    }

    public class MapeamentoMedico : ClassMap<Medico>
    {
        public MapeamentoMedico()
        {
            Id(key => key.CRM).Column("NOCRM");
            Map(campo => campo.Nome).Column("NMNOME");
            Table("TBMEDICO");            
        }
    }

    public class MapeamentoTipoExame : ClassMap<TipoExame>
    {
        public MapeamentoTipoExame()
        {
            Id(key => key.Codigo).Column("IDTIPOEXAME");
            Map(campo => campo.Descricao).Column("DESCRICAO");
            Table("TBTIPOEXAME");            
        }
    }

    public class MapeamentoExame : ClassMap<Exame>
    {
        public MapeamentoExame()
        {
            Id(chave=>chave.ID).Column("IDEXAME").GeneratedBy.Identity();
            Map(property => property.Preco).Column("PRECO");
            References(key => key.TipoExame).Column("IDTIPOEXAME").Cascade.SaveUpdate();           
            Table("TBEXAME");
        }
    }


    
    
}
