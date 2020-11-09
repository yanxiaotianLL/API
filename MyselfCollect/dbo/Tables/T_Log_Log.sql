CREATE TABLE [dbo].[T_Log_Log] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Date]       DATETIME        NOT NULL,
    [Thread]     VARCHAR (255)   NOT NULL,
    [Level]      VARCHAR (50)    NOT NULL,
    [Logger]     VARCHAR (255)   NOT NULL,
    [Message]    NVARCHAR (4000) NOT NULL,
    [Exception]  NVARCHAR (2000) NOT NULL,
    [SystemName] VARCHAR (100)   NOT NULL,
    [ModuleName] VARCHAR (100)   NOT NULL,
    [Name]       NVARCHAR (100)  NOT NULL,
    [Content]    NVARCHAR (4000) NOT NULL,
    [Code]       NVARCHAR (50)   NOT NULL,
    [Key1]       NVARCHAR (200)  NOT NULL,
    [Key2]       NVARCHAR (200)  NOT NULL,
    [Key3]       NVARCHAR (200)  NOT NULL,
    [Key4]       NVARCHAR (200)  NOT NULL,
    [CreateTime] DATETIME        CONSTRAINT [DF_Log_CreateTime] DEFAULT (getdate()) NULL,
    [UpdateTime] DATETIME        CONSTRAINT [DF_Log_UpdateTime] DEFAULT (getdate()) NULL,
    [IsDelete]   BIT             CONSTRAINT [DF_Log_IsDelete] DEFAULT ((0)) NULL
);

