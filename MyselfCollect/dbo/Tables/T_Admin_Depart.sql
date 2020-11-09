CREATE TABLE [dbo].[T_Admin_Depart] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [DepartName]        NVARCHAR (50)  NOT NULL,
    [DepartDescription] NVARCHAR (500) NULL,
    [ParentID]          INT            CONSTRAINT [DF__T_Admin_D__Paren__09DE7BCC] DEFAULT ((0)) NULL,
    [CreateTime]        DATE           CONSTRAINT [DF__T_Admin_D__Creat__0AD2A005] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]        DATE           CONSTRAINT [DF__T_Admin_D__Updat__0BC6C43E] DEFAULT (getdate()) NOT NULL,
    [CreateAdmin]       NVARCHAR (20)  NULL,
    [UpdateAdmin]       NVARCHAR (20)  NULL,
    [IsDelete]          BIT            CONSTRAINT [DF__T_Admin_D__IsDel__0CBAE877] DEFAULT ((0)) NOT NULL,
    [DepartLeader]      NVARCHAR (50)  NULL,
    [LeaderEmail]       NVARCHAR (20)  NULL,
    [SortValue]         INT            NULL,
    [DepartCode]        NVARCHAR (50)  NULL,
    [IsLeaf]            BIT            NOT NULL,
    [SupplierName]      NVARCHAR (150) NULL,
    [SupplierCode]      NVARCHAR (150) NULL,
    CONSTRAINT [PK_T_ADMIN_DEPART] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'管理员所属部门', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Depart';

