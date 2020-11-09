CREATE TABLE [dbo].[T_Admin_Menu] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [MenuName]        NVARCHAR (50)  NOT NULL,
    [MenuDescription] NVARCHAR (500) NULL,
    [Url]             NVARCHAR (100) NULL,
    [ParentID]        INT            CONSTRAINT [DF__T_Admin_M__Paren__0F975522] DEFAULT ((0)) NULL,
    [SortValue]       INT            NULL,
    [CreateTime]      DATE           CONSTRAINT [DF__T_Admin_M__Creat__108B795B] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]      DATE           CONSTRAINT [DF__T_Admin_M__Updat__117F9D94] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin]     NVARCHAR (20)  NULL,
    [UpdateAdmin]     NVARCHAR (20)  NULL,
    [IsDelete]        BIT            CONSTRAINT [DF__T_Admin_M__IsDel__1273C1CD] DEFAULT ((0)) NOT NULL,
    [IsDefault]       INT            CONSTRAINT [DF__T_Admin_M__IsDef__1367E606] DEFAULT ((0)) NULL,
    [Icon]            NVARCHAR (100) NULL,
    [MenuCode]        NVARCHAR (50)  NOT NULL,
    [IsLeaf]          BIT            NOT NULL,
    [ControllerName]  NVARCHAR (50)  NULL,
    [ActionName]      NVARCHAR (50)  NULL,
    [Target]          INT            CONSTRAINT [DF_T_Admin_Menu_Target_1] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_T_ADMIN_MENU] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'菜单', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Menu';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否所有人都能使用', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Menu', @level2type = N'COLUMN', @level2name = N'IsDefault';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'打开方式  0  ：ifream   1：_blank', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Menu', @level2type = N'COLUMN', @level2name = N'Target';

