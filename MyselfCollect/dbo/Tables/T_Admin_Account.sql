CREATE TABLE [dbo].[T_Admin_Account] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [DepartID]         INT           NOT NULL,
    [UserName]         NVARCHAR (50) NOT NULL,
    [RealName]         NVARCHAR (10) NULL,
    [Password]         NVARCHAR (50) NOT NULL,
    [Email]            NVARCHAR (50) NULL,
    [Telephone]        NVARCHAR (20) NULL,
    [DepartName]       NVARCHAR (50) NULL,
    [CreateTime]       DATE          CONSTRAINT [DF__T_Admin_A__Creat__7F60ED59] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]       DATE          CONSTRAINT [DF__T_Admin_A__Updat__00551192] DEFAULT (getdate()) NOT NULL,
    [IsDelete]         BIT           CONSTRAINT [DF_T_Admin_Account_IsDelete] DEFAULT ((0)) NOT NULL,
    [CreateAdmin]      NVARCHAR (20) CONSTRAINT [DF__T_Admin_A__Creat__014935CB] DEFAULT ('0') NULL,
    [UpdateAdmin]      NVARCHAR (20) CONSTRAINT [DF__T_Admin_A__Updat__023D5A04] DEFAULT ('0') NULL,
    [SEND_LOGIN_NAME]  NVARCHAR (50) NULL,
    [SEND_USER_ID]     VARCHAR (50)  NULL,
    [SEND_SUPPLIER_ID] VARCHAR (50)  NULL,
    [ActiveTime]       DATETIME      NULL,
    [IsActive]         BIT           CONSTRAINT [DF_T_Admin_Account_IsActive] DEFAULT ((0)) NOT NULL,
    [State]            INT           CONSTRAINT [DF_T_Admin_Account_State_1] DEFAULT ((0)) NOT NULL,
    [AdminUserId]      INT           NULL,
    [SUPP_NO]          VARCHAR (50)  NULL,
    [SUPP_Name]        VARCHAR (500) NULL,
    [OpenId]           VARCHAR (50)  NULL,
    CONSTRAINT [PK_T_ADMIN_ACCOUNT] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'管理员用户表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户帐号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account', @level2type = N'COLUMN', @level2name = N'UserName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'用户真实姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account', @level2type = N'COLUMN', @level2name = N'RealName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'部门名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account', @level2type = N'COLUMN', @level2name = N'DepartName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'0：初始状态
1：修改密码后的激活状态', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Admin_Account', @level2type = N'COLUMN', @level2name = N'State';

