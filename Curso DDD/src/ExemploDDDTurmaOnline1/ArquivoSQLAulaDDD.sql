
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C47B234A33D]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C47B234A33D


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C47816F9A9E]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C47816F9A9E


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK2DF00C473CF80D8]') AND parent_object_id = OBJECT_ID('TBAGENDAMENTO'))
alter table TBAGENDAMENTO  drop constraint FK2DF00C473CF80D8


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCED9C6B4403B5DE8]') AND parent_object_id = OBJECT_ID('TBPACIENTE'))
alter table TBPACIENTE  drop constraint FKCED9C6B4403B5DE8


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE61D11B9CF6ACAC3]') AND parent_object_id = OBJECT_ID('TBEXAME'))
alter table TBEXAME  drop constraint FKE61D11B9CF6ACAC3


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE61D11B922A4B10E]') AND parent_object_id = OBJECT_ID('TBEXAME'))
alter table TBEXAME  drop constraint FKE61D11B922A4B10E


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE61D11B9B4452B2B]') AND parent_object_id = OBJECT_ID('TBEXAME'))
alter table TBEXAME  drop constraint FKE61D11B9B4452B2B


    if exists (select * from dbo.sysobjects where id = object_id(N'TBAGENDAMENTO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBAGENDAMENTO

    if exists (select * from dbo.sysobjects where id = object_id(N'TBPACIENTE') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBPACIENTE

    if exists (select * from dbo.sysobjects where id = object_id(N'TBCREDENCIAL') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBCREDENCIAL

    if exists (select * from dbo.sysobjects where id = object_id(N'TBEXAME') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBEXAME

    if exists (select * from dbo.sysobjects where id = object_id(N'TBLAUDO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBLAUDO

    if exists (select * from dbo.sysobjects where id = object_id(N'TBMEDICO') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBMEDICO

    if exists (select * from dbo.sysobjects where id = object_id(N'TBPLANOSAUDE') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBPLANOSAUDE

    if exists (select * from dbo.sysobjects where id = object_id(N'TBTIPOEXAME') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table TBTIPOEXAME

    create table TBAGENDAMENTO (
        IDAGENDAMENTO INT IDENTITY NOT NULL,
       CPF NVARCHAR(255) null,
       IDCREDENCIAL INT null,
       CRM NVARCHAR(255) null,
       primary key (IDAGENDAMENTO)
    )

    create table TBPACIENTE (
        CPF NVARCHAR(255) not null,
       NOME NVARCHAR(255) null,
       EMAIL NVARCHAR(255) null,
       CNPJ NVARCHAR(255) null,
       primary key (CPF)
    )

    create table TBCREDENCIAL (
        IDCREDENCIAL INT IDENTITY NOT NULL,
       USUARIO NVARCHAR(255) null,
       SENHA NVARCHAR(255) null,
       primary key (IDCREDENCIAL)
    )

    create table TBEXAME (
        IDEXAME INT IDENTITY NOT NULL,
       IDLAUDO INT null,
       CBHPM NVARCHAR(255) null,
       IDAGENDAMENTO INT null,
       primary key (IDEXAME)
    )

    create table TBLAUDO (
        IDLAUDO INT IDENTITY NOT NULL,
       DESCRICAO NVARCHAR(255) null,
       primary key (IDLAUDO)
    )

    create table TBMEDICO (
        CRM NVARCHAR(255) not null,
       NOME NVARCHAR(255) null,
       UF NVARCHAR(255) null,
       primary key (CRM)
    )

    create table TBPLANOSAUDE (
        CNPJ NVARCHAR(255) not null,
       NOME NVARCHAR(255) null,
       TIPOPLANO NVARCHAR(255) null,
       primary key (CNPJ)
    )

    create table TBTIPOEXAME (
        CBHPM NVARCHAR(255) not null,
       DESCRICAO NVARCHAR(255) null,
       primary key (CBHPM)
    )

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C47B234A33D 
        foreign key (CPF) 
        references TBPACIENTE

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C47816F9A9E 
        foreign key (IDCREDENCIAL) 
        references TBCREDENCIAL

    alter table TBAGENDAMENTO 
        add constraint FK2DF00C473CF80D8 
        foreign key (CRM) 
        references TBMEDICO

    alter table TBPACIENTE 
        add constraint FKCED9C6B4403B5DE8 
        foreign key (CNPJ) 
        references TBPLANOSAUDE

    alter table TBEXAME 
        add constraint FKE61D11B9CF6ACAC3 
        foreign key (IDLAUDO) 
        references TBLAUDO

    alter table TBEXAME 
        add constraint FKE61D11B922A4B10E 
        foreign key (CBHPM) 
        references TBTIPOEXAME

    alter table TBEXAME 
        add constraint FKE61D11B9B4452B2B 
        foreign key (IDAGENDAMENTO) 
        references TBAGENDAMENTO
