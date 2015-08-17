
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C4733DAC3ED]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C4733DAC3ED


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C47E572D624]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C47E572D624


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C47FF68603B]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C47FF68603B


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKA592AB9B9FED9A5D]') AND parent_object_id = OBJECT_ID('[Exame]'))
alter table [Exame]  drop constraint FKA592AB9B9FED9A5D


    if exists (select * from dbo.sysobjects where id = object_id(N'TBAGENDAMENTO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBAGENDAMENTO

    if exists (select * from dbo.sysobjects where id = object_id(N'[CID]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [CID]

    if exists (select * from dbo.sysobjects where id = object_id(N'[Exame]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Exame]

    if exists (select * from dbo.sysobjects where id = object_id(N'[Medico]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Medico]

    if exists (select * from dbo.sysobjects where id = object_id(N'TBPACIENTE') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBPACIENTE

    create table TBAGENDAMENTO (
        IDAGENDAMENTO INT IDENTITY NOT NULL,
       NOCPF NVARCHAR(255) not null,
       Crm NVARCHAR(255) not null,
       Numero NVARCHAR(255) not null,
       primary key (IDAGENDAMENTO)
    )

    create table [CID] (
        Numero NVARCHAR(255) not null,
       Descricao NVARCHAR(255) not null,
       primary key (Numero)
    )

    create table [Exame] (
        IDEXAME NVARCHAR(255) not null,
       Descricao NVARCHAR(255) not null,
       IDAGENDAMENTO INT null,
       primary key (IDEXAME)
    )

    create table [Medico] (
        Crm NVARCHAR(255) not null,
       Nome NVARCHAR(255) not null,
       primary key (Crm)
    )

    create table TBPACIENTE (
        NOCPF NVARCHAR(255) not null,
       NMNOME NVARCHAR(255) null,
       primary key (NOCPF)
    )

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C4733DAC3ED 
        foreign key (NOCPF) 
        references TBPACIENTE

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C47E572D624 
        foreign key (Crm) 
        references [Medico]

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C47FF68603B 
        foreign key (Numero) 
        references [CID]

    alter table [Exame] 
        add constraint FKA592AB9B9FED9A5D 
        foreign key (IDAGENDAMENTO) 
        references TBAGENDAMENTO
