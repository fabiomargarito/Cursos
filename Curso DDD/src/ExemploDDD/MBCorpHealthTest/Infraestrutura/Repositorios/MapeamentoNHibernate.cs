using FluentNHibernate.Mapping;
using MBCorpHealthTest.Dominio.Entidades;

namespace MBCorpHealthTest.Infraestrutura.Repositorios
{
    public class MapeamentoMedico : ClassMap<Medico>
    {
        public MapeamentoMedico()
        {
            Id(chave => chave.CRM).Column("CRM");                        
            Map(campo => campo.Nome).Column("NOME");
            Map(campo => campo.Estado).Column("UF");            
            Table("TBMEDICO");
            LazyLoad();
        }
    }

    public class MapeamentoAtendente : ClassMap<Atendente>
    {
        public MapeamentoAtendente()
        {
            Id(chave => chave.CPF).Column("CPF");
            Map(campo => campo.Nome).Column("NOME");            
            Table("TBPACIENTE");
            LazyLoad();
        }
    }

    public class MapeamentoPlanoDeSaude : ClassMap<PlanoDeSaude>
    {
        public MapeamentoPlanoDeSaude()
        {
            Id(chave => chave.CNPJ).Column("CNPJ");
            Map(campo => campo.Nome).Column("NOME");
            Map(campo => campo.TipoDoPlano).Column("TIPOPLANO");            
            Table("TBPLANOSAUDE");
            LazyLoad();
        }
    }	

    public class MapeamentoPaciente : ClassMap<Paciente>
    {
        public MapeamentoPaciente()
        {
            Id(chave => chave.CPF).Column("CPF");
            Map(campo => campo.Email).Column("EMAIL");
            Map(campo => campo.Nome).Column("NOME");
            References(chave => chave.PlanoDeSaude).Column("CNPJ");
            Table("TBPACIENTE");
            LazyLoad();
        }
    }

    public class MapeamentoCredencial : ClassMap<Credencial>
    {
        public MapeamentoCredencial()
        {
            Id().Column("IDCREDENCIAL");
            Map(campo => campo.User).Column("USUARIO");
            Map(campo => campo.Senha).Column("SENHA");            
            Table("TBCREDENCIAL");
            LazyLoad();
        }
    }

    public class MapeamentoTipoExame : ClassMap<TipoExame>
    {
        public MapeamentoTipoExame()
        {
            Id(chave => chave.CBHPM).Column("CBHPM");
            Map(campo => campo.Descricao).Column("DESCRICAO");
            Table("TBTIPOEXAME");
            LazyLoad();
        }
    }	

    public class MapeamentoLaudo : ClassMap<Laudo>
    {
        public MapeamentoLaudo()
        {
            Id().Column("IDLAUDO");
            Map(campo => campo.Descricao).Column("DESCRICAO");            
            Table("TBLAUDO");
            LazyLoad();
        }
    }	

    public class MapeamentoExame : ClassMap<Exame>
    {
        public MapeamentoExame()
        {
            Id().Column("IDEXAME");
            References(chave => chave.Laudo).Column("IDLAUDO");
            References(chave => chave.TipoExame).Column("CBHPM");            
            Table("TBEXAME");
            LazyLoad();
        }
    }

    public class MapeamentoAgendamento : ClassMap<Agendamento>
    {
        public MapeamentoAgendamento()
        {
            Id(chave => chave.ID).Column("IDAGENDAMENTO");            
            References(chave => chave.Atendente).Column("CPF");
            References(chave => chave.Credencial).Column("IDCREDENCIAL");            
            References(chave => chave.MedicoSolicitante).Column("CRM");
            References(chave => chave.Paciente).Column("CPF");
            HasMany(chave => chave.Exames).KeyColumn("IDAGENDAMENTO");
            Table("TBAGENDAMENTO");
            LazyLoad();
        }
    }	
}
