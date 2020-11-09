CREATE TABLE [dbo].[T_Admin_AcountRole] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [RoleID]      INT           NOT NULL,
    [AccountID]   INT           NOT NULL,
    [IsDelete]    BIT           CONSTRAINT [DF__T_Admin_A__IsDel__0519C6AF] DEFAULT ((0)) NOT NULL,
    [CreateTime]  DATE          CONSTRAINT [DF__T_Admin_A__Creat__060DEAE8] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin] NVARCHAR (50) CONSTRAINT [DF__T_Admin_A__Creat__07020F21] DEFAULT (getdate()) NULL,
    [SortValue]   CHAR (10)     NULL,
    [UpdateTime]  DATE          CONSTRAINT [DF_T_Admin_AcountRole_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_ACOUNTROLE] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户角色关联表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_AcountRole';

