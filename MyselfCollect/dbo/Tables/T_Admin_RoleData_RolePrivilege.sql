CREATE TABLE [dbo].[T_Admin_RoleData_RolePrivilege] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [RoleID]      INT           NULL,
    [RoleDataID]  INT           NULL,
    [IsDelete]    BIT           CONSTRAINT [DF__T_Admin_R__IsDel__286302EC] DEFAULT ((0)) NOT NULL,
    [CreateTime]  DATE          CONSTRAINT [DF__T_Admin_R__Creat__29572725] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin] NVARCHAR (20) NULL,
    [UpdateTime]  DATE          CONSTRAINT [DF_T_Admin_RoleData_RolePrivilege_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_ROLEDATA_ROLEPRIVIL] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色数据权限关联表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_RoleData_RolePrivilege';

