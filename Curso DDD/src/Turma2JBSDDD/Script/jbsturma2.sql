
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C4749467CB3]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C4749467CB3


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C476F2188B7]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C476F2188B7


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE61D11B923FE3AE2]') AND parent_object_id = OBJECT_ID('TBEXAME'))
alter table TBEXAME  drop constraint FKE61D11B923FE3AE2


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE61D11B94DD0C18E]') AND parent_object_id = OBJECT_ID('TBEXAME'))
alter table TBEXAME  drop constraint FKE61D11B94DD0C18E


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCED9C6B4FC256D8C]') AND parent_object_id = OBJECT_ID('TBPACIENTE'))
alter table TBPACIENTE  drop constraint FKCED9C6B4FC256D8C


    if exists (select * from dbo.sysobjects where id = object_id(N'TBAGENDAMENTO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBAGENDAMENTO

    if exists (select * from dbo.sysobjects where id = object_id(N'TBEXAME') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBEXAME

    if exists (select * from dbo.sysobjects where id = object_id(N'TBMEDICO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBMEDICO

    if exists (select * from dbo.sysobjects where id = object_id(N'TBPACIENTE') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBPACIENTE

    if exists (select * from dbo.sysobjects where id = object_id(N'TBPLANODESAUDE') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBPLANODESAUDE

    if exists (select * from dbo.sysobjects where id = object_id(N'TBTIPOEXAME') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBTIPOEXAME

    create table TBAGENDAMENTO (
        IDAGENDAMENTO INT IDENTITY NOT NULL,
       NOCRM NVARCHAR(255) null,
       NOCPF NVARCHAR(255) null,
       primary key (IDAGENDAMENTO)
    )

    create table TBEXAME (
        IDEXAME INT IDENTITY NOT NULL,
       PRECO FLOAT(53) null,
       IDTIPOEXAME NVARCHAR(255) null,
       IDAGENDAMENTO INT null,
       primary key (IDEXAME)
    )

    create table TBMEDICO (
        NOCRM NVARCHAR(255) not null,
       NMNOME NVARCHAR(255) null,
       primary key (NOCRM)
    )

    create table TBPACIENTE (
        NOCPF NVARCHAR(255) not null,
       NMNOME NVARCHAR(255) null,
       NOCNPJ NVARCHAR(255) null,
       primary key (NOCPF)
    )

    create table TBPLANODESAUDE (
        NOCNPJ NVARCHAR(255) not null,
       NMRazaoSocial NVARCHAR(255) null,
       primary key (NOCNPJ)
    )

    create table TBTIPOEXAME (
        IDTIPOEXAME NVARCHAR(255) not null,
       DESCRICAO NVARCHAR(255) null,
       primary key (IDTIPOEXAME)
    )

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C4749467CB3 
        foreign key (NOCRM) 
        references TBMEDICO

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C476F2188B7 
        foreign key (NOCPF) 
        references TBPACIENTE

    alter table TBEXAME 
        add constraint FKE61D11B923FE3AE2 
        foreign key (IDTIPOEXAME) 
        references TBTIPOEXAME

    alter table TBEXAME 
        add constraint FKE61D11B94DD0C18E 
        foreign key (IDAGENDAMENTO) 
        references TBAGENDAMENTO

    alter table TBPACIENTE 
        add constraint FKCED9C6B4FC256D8C 
        foreign key (NOCNPJ) 
        references TBPLANODESAUDE
