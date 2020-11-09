CREATE TABLE [dbo].[T_JC_Account_Visit_History] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Ip]          NVARCHAR (50)   NULL,
    [CreateTime]  NVARCHAR (50)   CONSTRAINT [DF__T_JC_Acco__Creat__2BC97F7C] DEFAULT (getdate()) NULL,
    [UpdateTime]  NVARCHAR (50)   CONSTRAINT [DF__T_JC_Acco__Updat__2CBDA3B5] DEFAULT (getdate()) NULL,
    [IsDelete]    BIT             CONSTRAINT [DF__T_JC_Acco__IsDel__2DB1C7EE] DEFAULT ((0)) NULL,
    [RawUrl]      NVARCHAR (1000) NULL,
    [UrlReferrer] NVARCHAR (1000) NULL,
    [UserAgent]   NVARCHAR (200)  NULL,
    [UserName]    NVARCHAR (50)   NULL,
    [UserId]      INT             NULL,
    [Controller]  NVARCHAR (50)   NULL,
    [Action]      NVARCHAR (50)   NULL,
    CONSTRAINT [PK_T_JC_ACCOUNT_VISIT_HISTORY] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = '前台用户访问记录表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_Visit_History';

