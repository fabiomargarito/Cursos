using FluentNHibernate.Mapping;
using MBCorpHealthTest.Dominio.Entidades;
using MBCorpHealthTest.Dominio.ObjetosDeValor;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    

    class MapeamentoMedico:ClassMap<Medico>
    {
        public MapeamentoMedico()
        {
            Id(chave => chave.CRM).Column("CRM");
            Map(campo => campo.Nome).Column("Nome");
            Table("TBMEDICO");
        }
    }

    class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(chave => chave.CPF).Column("CPFPACIENTE");
            Map(campo => campo.Nome).Column("Nome");
            References(campo => campo.Telefone).Column("IDTelefone");
            Table("TBPACIENTE");
        }
    }


    class MapeamentoAtendente : ClassMap<Atendente>
    {
        public MapeamentoAtendente()
        {
            Id(chave => chave.CPF).Column("CPFATENDENTE");
            Map(campo => campo.Nome).Column("Nome");
            Table("TBATENDENTE");
        }
    }

    class MapeamentoCentroDiagnostico : ClassMap<CentroDiagnostico>
    {
        public MapeamentoCentroDiagnostico()
        {
            Id(chave => chave.CNPJ).Column("CNPJ");
            Map(campo=> campo.RazaoSocial).Column("RAZAOSOCIAL");
            Table("TBCENTRODIAGNOSTICO");
            
        }
    }

    class MapeamentoTipoDeExame : ClassMap<TipoExame>
    {
        public MapeamentoTipoDeExame()
        {
            Id(chave => chave.CBHPM).Column("CBHPM");
            Map(campo => campo.Preco).Column("Preco");
            Table("TBTIPODEEXAME");
        }
    }

    public class MapeamentoCID : ClassMap<CID>
    {
        public MapeamentoCID()
        {
            Id().Column("IDCID").GeneratedBy.Identity();
            Map(campo => campo.Descricao).Column("DESCRICAO");
            Table("TBCID");
        }
    }

    public class MapeamentoLaudo : ClassMap<Laudo>
    {
        public MapeamentoLaudo()
        {
            Id().Column("IDLaudo").GeneratedBy.Identity();
            Map(campo => campo.Resultado).Column("Resultado");
            References(chave => chave.MedicoAnalise).Column("CRM");
            LazyLoad();
            Table("TBLAUDO");
        }
    }


    public class MapeamentoTelefone : ClassMap<Telefone>
    {
        public MapeamentoTelefone()
        {
            Id().Column("IDTelefone").GeneratedBy.Identity();
            Map(campo => campo.DDD).Column("DDD");
            Map(campo => campo.Numero).Column("Numero");
            Table("TBTELEFONE");
}
    }

    public class MapeamentoExame : ClassMap<Exame>
    {
        public MapeamentoExame()
        {
            Id().Column("IDExame").GeneratedBy.Identity();
            References(chave => chave.TipoExame).Column("CBHPM");
            References(chave => chave.CentroDiagnostico).Column("CNPJ");
            Map(campo => campo.DataDoAgendamento).Column("DataAgendamento");
            References(chave => chave.Laudo).Column("IDLaudo");
            Map(campo => campo.Preco).Column("Preco");
            LazyLoad();
            Table("TBEXAME");
        }
    }

    public class MapeamentoAgendamento : ClassMap<Agendamento>
    {
        public MapeamentoAgendamento()
        {
            Id(chave => chave.Numero).Column("Numero");
            References(chave => chave.Medico).Column("CRM");
            References(chave => chave.Paciente).Column("CPFPACIENTE");
            References(chave => chave.Atendente).Column("CPFATENDENTE");
            References(chave => chave.CID).Column("IDCID");
            HasMany(chave => chave.Exames).KeyColumn("Numero").Cascade.SaveUpdate().Cascade.Delete();            
            Table("TBAGENDAMENTO");
            LazyLoad();
        }
    }
}

