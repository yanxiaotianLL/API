CREATE TABLE [dbo].[D_JC_Address] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [area_id]         NVARCHAR (50)  NULL,
    [parent_id]       FLOAT (53)     NULL,
    [area_name]       NVARCHAR (255) NULL,
    [creator_id]      FLOAT (53)     NULL,
    [creator_name]    NVARCHAR (255) NULL,
    [remark]          NVARCHAR (255) NULL,
    [area_type]       NVARCHAR (255) NULL,
    [area_type_dic]   NVARCHAR (255) NULL,
    [area_code]       NVARCHAR (255) NULL,
    [leaf]            FLOAT (53)     NULL,
    [is_parent_menu]  NVARCHAR (255) NULL,
    [level]           FLOAT (53)     NULL,
    [area_state]      FLOAT (53)     NULL,
    [area_state_dic]  NVARCHAR (255) NULL,
    [area_nature]     FLOAT (53)     NULL,
    [area_nature_dic] NVARCHAR (255) NULL,
    [order]           FLOAT (53)     NULL,
    [operator]        FLOAT (53)     NULL,
    [oper_time]       DATETIME       NULL,
    [CreateTime]      DATE           CONSTRAINT [DF_D_JC_Address_CreateTime] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]      DATE           CONSTRAINT [DF_D_JC_Address_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [IsDelete]        BIT            CONSTRAINT [DF_D_JC_Address_IsDelete] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_D_JC_Address] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'D_JC_Addres', @value = N'D_JC_Addres', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'D_JC_Address';


GO
EXECUTE sp_addextendedproperty @name = N'D_JC_Address', @value = N'D_JC_Address', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'D_JC_Address';

