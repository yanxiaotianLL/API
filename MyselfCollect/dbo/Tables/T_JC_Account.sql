CREATE TABLE [dbo].[T_JC_Account] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [Name]                NVARCHAR (20)  NULL,
    [Password]            NVARCHAR (50)  NULL,
    [RealName]            NVARCHAR (10)  NULL,
    [Email]               NVARCHAR (50)  NULL,
    [Phone]               NVARCHAR (13)  NULL,
    [State]               INT            CONSTRAINT [DF__T_JC_Acco__State__4A18FC72] DEFAULT ((0)) NOT NULL,
    [IsDelete]            BIT            CONSTRAINT [DF__T_JC_Acco__IsDel__4B0D20AB] DEFAULT ((0)) NOT NULL,
    [CreateTime]          DATE           CONSTRAINT [DF__T_JC_Acco__Creat__4C0144E4] DEFAULT (getdate()) NOT NULL,
    [ActiveTime]          DATE           CONSTRAINT [DF__T_JC_Acco__Activ__4CF5691D] DEFAULT (getdate()) NULL,
    [UpdateTime]          DATE           CONSTRAINT [DF__T_JC_Acco__Updat__4DE98D56] DEFAULT (getdate()) NOT NULL,
    [IsEmailVerification] BIT            CONSTRAINT [DF__T_JC_Acco__IsEma__4EDDB18F] DEFAULT ((0)) NULL,
    [IsPhoneVerification] BIT            CONSTRAINT [DF__T_JC_Acco__IsPho__4FD1D5C8] DEFAULT ((0)) NULL,
    [BUSI_CUST_NO]        NVARCHAR (50)  NULL,
    [AddressId]           INT            NULL,
    [Address]             NVARCHAR (200) NULL,
    [TempPassword]        NVARCHAR (50)  NULL,
    CONSTRAINT [PK_T_JC_ACCOUNT] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'hr端账户表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'登录名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'Name';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'登录密码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'Password';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'真实姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'RealName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'Email';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'手机号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'Phone';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'激活状态
0 :临时账号
1：已经确认
2：已经激活', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'State';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'激活时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'ActiveTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'UpdateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否邮箱验证', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'IsEmailVerification';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否手机验证', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account', @level2type = N'COLUMN', @level2name = N'IsPhoneVerification';

