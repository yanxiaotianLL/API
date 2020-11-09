CREATE TABLE [dbo].[T_Admin_Role] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [RoleName]        NVARCHAR (20) NOT NULL,
    [RoleDescription] NVARCHAR (20) NULL,
    [CreateTime]      DATE          CONSTRAINT [DF__T_Admin_R__Creat__1DE57479] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]      DATE          CONSTRAINT [DF__T_Admin_R__Updat__1ED998B2] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin]     NVARCHAR (20) CONSTRAINT [DF__T_Admin_R__Creat__1FCDBCEB] DEFAULT ('0') NULL,
    [UpdateAdmin]     NVARCHAR (20) CONSTRAINT [DF__T_Admin_R__Updat__20C1E124] DEFAULT ('0') NULL,
    [IsDelete]        BIT           CONSTRAINT [DF_T_Admin_Role_IsDelete] DEFAULT ((0)) NOT NULL,
    [SortValue]       INT           NULL,
    [RoleCode]        NVARCHAR (20) NULL,
    CONSTRAINT [PK_T_ADMIN_ROLE] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'管理员角色表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Role';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'排序字段', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Role', @level2type = N'COLUMN', @level2name = N'SortValue';

