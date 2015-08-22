using FluentNHibernate.Mapping;
using JBSHealthCare.Dominio.Entidade;
using JBSHealthCare.Dominio.Entidade.BoundedContextCadastrosCorporativos;
using JBSHealthCare.Dominio.Entidade.BoundedContextGestaoDeAgendamentos;

namespace JBSHealthCare.Infraestrutura.Repositorio
{
    public class MapeamentoAgendamento : ClassMap<Agendamento>
    {
        public MapeamentoAgendamento()
        {
            Id(chave => chave.ID).Column("IDAGENDAMENTO");
            References(propriedade => propriedade.Paciente).Not.Nullable().Column("NOCPF").Cascade.SaveUpdate();
            References(propriedade => propriedade.Medico).Not.Nullable().Column("Crm").Cascade.SaveUpdate();
            References(propriedade => propriedade.Cid).Not.Nullable().Column("Numero").Cascade.SaveUpdate();
            HasMany(propriedade => propriedade.Exames).KeyColumn("IDAGENDAMENTO").Cascade.SaveUpdate();
            Table("TBAGENDAMENTO");
        }
    }

    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(chave => chave.Cpf).Column("NOCPF").Not.Nullable();
            Map(propriedade => propriedade.Nome).Column("NMNOME");
            Table("TBPACIENTE");
        }
    }


    public class MapeamentoMedico : ClassMap<Medico>
    {
        public MapeamentoMedico()
        {
            Id(chave => chave.Crm).Not.Nullable();
            Map(propriedade => propriedade.Nome).Not.Nullable();
        }
    }


    public class MapeamentoCID : ClassMap<CID>
    {
        public MapeamentoCID()
        {
            Id(chave => chave.Numero).Not.Nullable();
            Map(propriedade => propriedade.Descricao).Not.Nullable();
        }
    }

    public class MapeamentoExame : ClassMap<Exame>
    {
        public MapeamentoExame()
        {
            Id(chave => chave.ID).Not.Nullable().Column("IDEXAME");
            Map(propriedade => propriedade.Descricao).Not.Nullable();
        }
    }
}