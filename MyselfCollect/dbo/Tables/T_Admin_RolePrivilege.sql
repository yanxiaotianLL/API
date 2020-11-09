CREATE TABLE [dbo].[T_Admin_RolePrivilege] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [RoleID]      INT           NOT NULL,
    [MenuID]      INT           NOT NULL,
    [IsDelete]    BIT           CONSTRAINT [DF__T_Admin_R__IsDel__2C3393D0] DEFAULT ((0)) NOT NULL,
    [CreateTime]  DATE          CONSTRAINT [DF__T_Admin_R__Creat__2D27B809] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin] NVARCHAR (50) CONSTRAINT [DF__T_Admin_R__Creat__2E1BDC42] DEFAULT (getdate()) NULL,
    [UpdateTime]  DATE          CONSTRAINT [DF_T_Admin_RolePrivilege_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_ROLEPRIVILEGE] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色权限关联表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_RolePrivilege';

