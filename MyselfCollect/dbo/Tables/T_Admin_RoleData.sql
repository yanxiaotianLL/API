CREATE TABLE [dbo].[T_Admin_RoleData] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [DataValue]   NVARCHAR (50)  NOT NULL,
    [DataKey]     NVARCHAR (50)  NOT NULL,
    [IsDelete]    BIT            CONSTRAINT [DF__T_Admin_R__IsDel__239E4DCF] DEFAULT ((0)) NOT NULL,
    [IsDefault]   INT            CONSTRAINT [DF__T_Admin_R__IsDef__24927208] DEFAULT ((0)) NULL,
    [CreateTime]  DATE           CONSTRAINT [DF__T_Admin_R__Creat__25869641] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin] NVARCHAR (20)  NULL,
    [Icon]        NVARCHAR (200) NULL,
    [SortValue]   INT            NULL,
    [UpdateTime]  DATE           CONSTRAINT [DF_T_Admin_RoleData_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_ROLEDATA] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'角色数据权限表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_RoleData';

