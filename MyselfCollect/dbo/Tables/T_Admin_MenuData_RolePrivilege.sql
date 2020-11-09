CREATE TABLE [dbo].[T_Admin_MenuData_RolePrivilege] (
    [RolePrivilegeID] INT           NOT NULL,
    [MenuDataID]      INT           NOT NULL,
    [IsDelete]        BIT           CONSTRAINT [DF_T_Admin_MenuData_RolePrivilege_IsDelete] DEFAULT ((0)) NOT NULL,
    [CreateTime]      DATE          CONSTRAINT [DF__T_Admin_M__Creat__1B0907CE] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin]     NVARCHAR (20) NULL,
    [SortValue]       INT           NULL,
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [UpdateTime]      DATE          CONSTRAINT [DF_T_Admin_MenuData_RolePrivilege_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_MENUDATA_ROLEPRIVIL] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'数据按钮等子权限关联表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_MenuData_RolePrivilege';

