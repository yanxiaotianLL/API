CREATE TABLE [dbo].[T_Admin_MenuData] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [MenuID]      INT            NOT NULL,
    [DataKey]     NVARCHAR (50)  NOT NULL,
    [DataValue]   NVARCHAR (50)  NOT NULL,
    [IsDefault]   BIT            NULL,
    [IsDelete]    BIT            CONSTRAINT [DF__T_Admin_M__IsDel__164452B1] DEFAULT ((0)) NOT NULL,
    [CreateTime]  DATE           CONSTRAINT [DF__T_Admin_M__Creat__173876EA] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]  DATE           CONSTRAINT [DF__T_Admin_M__Updat__182C9B23] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin] NVARCHAR (20)  NULL,
    [UpdateAdmin] NVARCHAR (20)  NULL,
    [Icon]        NVARCHAR (100) NULL,
    [SortValue]   INT            NULL,
    CONSTRAINT [PK_T_ADMIN_MENUDATA] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'针对菜单→的数据、按钮等权限过滤单元', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_MenuData';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'默认为操作', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_MenuData', @level2type = N'COLUMN', @level2name = N'IsDefault';

