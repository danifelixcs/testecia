CREATE TABLE [TesteSeusConhecimentos].[EnterpriseData] (
    [IdEnterprise]      INT           IDENTITY (1, 1) NOT NULL,
    [StreetAddress]     VARCHAR (255) NULL,
    [City]              VARCHAR (255) NULL,
    [ZipCode]           VARCHAR (100) NULL,
    [CorporateActivity] VARCHAR (100) NULL,
    CONSTRAINT [PK_EnterpriseData] PRIMARY KEY CLUSTERED ([IdEnterprise] ASC)
);
go;
CREATE TABLE [TesteSeusConhecimentos].[RelationshipData] (
    [IdRelationship] INT IDENTITY (1, 1) NOT NULL,
    [IdEnterprise]   INT NOT NULL,
    [IdUser]         INT NOT NULL,
    CONSTRAINT [PK_RelationshipData]PRIMARY KEY CLUSTERED ([IdRelationship] ASC),
    FOREIGN KEY ([IdEnterprise]) REFERENCES [TesteSeusConhecimentos].[EnterpriseData] ([IdEnterprise]),
    FOREIGN KEY ([IdUser]) REFERENCES [TesteSeusConhecimentos].[UserData] ([IdUser])
);
go;
