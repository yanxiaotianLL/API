CREATE TABLE [dbo].[T_Admin_Visit_History] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Ip]          NVARCHAR (50)   NULL,
    [CreateTime]  NVARCHAR (50)   CONSTRAINT [DF__T_Admin_V__Creat__308E3499] DEFAULT (getdate()) NULL,
    [UpdateTime]  NVARCHAR (50)   CONSTRAINT [DF__T_Admin_V__Updat__318258D2] DEFAULT (getdate()) NULL,
    [IsDelete]    BIT             CONSTRAINT [DF__T_Admin_V__IsDel__32767D0B] DEFAULT ((0)) NULL,
    [RawUrl]      NVARCHAR (1000) NULL,
    [UrlReferrer] NVARCHAR (1000) NULL,
    [UserAgent]   NVARCHAR (200)  NULL,
    [UserName]    NVARCHAR (50)   NULL,
    [UserId]      INT             NULL,
    [Controller]  NVARCHAR (50)   NULL,
    [Action]      NVARCHAR (50)   NULL,
    CONSTRAINT [PK_T_ADMIN_VISIT_HISTORY] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [_dta_index_T_Admin_Visit_History_21_942626401__K3D_1_2_4_5_6_7_8_9_10_11_12]
    ON [dbo].[T_Admin_Visit_History]([CreateTime] DESC)
    INCLUDE([Id], [Ip], [UpdateTime], [IsDelete], [RawUrl], [UrlReferrer], [UserAgent], [UserName], [UserId], [Controller], [Action]);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = '后台用户访问记录表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Visit_History';

