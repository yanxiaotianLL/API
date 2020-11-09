CREATE TABLE [dbo].[T_Sys_PhoneCode] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [Code]       VARCHAR (30) CONSTRAINT [DF__T_Sys_Phon__Code__6EC0713C] DEFAULT ('') NOT NULL,
    [Phone]      VARCHAR (60) CONSTRAINT [DF__T_Sys_Pho__Phone__6FB49575] DEFAULT ('') NOT NULL,
    [Ip]         VARCHAR (20) CONSTRAINT [DF__T_Sys_PhoneC__Ip__70A8B9AE] DEFAULT ('') NOT NULL,
    [ToUser]     VARCHAR (50) CONSTRAINT [DF__T_Sys_Pho__ToUse__719CDDE7] DEFAULT ('') NOT NULL,
    [Type]       INT          CONSTRAINT [DF__T_Sys_Phon__Type__72910220] DEFAULT ((0)) NOT NULL,
    [SendType]   VARCHAR (50) CONSTRAINT [DF__T_Sys_Pho__SendT__73852659] DEFAULT ('') NOT NULL,
    [State]      INT          CONSTRAINT [DF__T_Sys_Pho__State__74794A92] DEFAULT ((1)) NOT NULL,
    [CreateTime] DATETIME     CONSTRAINT [DF__T_Sys_Pho__Creat__756D6ECB] DEFAULT (getdate()) NOT NULL,
    [UseTime]    DATETIME     CONSTRAINT [DF__T_Sys_Pho__UseTi__76619304] DEFAULT (getdate()) NOT NULL,
    [UpdateTime] DATETIME     NULL,
    [IsDelete]   BIT          NULL,
    CONSTRAINT [PK_T_Sys_PhoneCode] PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'手机验证码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'Code';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'手机号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'Phone';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Ip地址', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'Ip';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'使用者', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'ToUser';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'1、激活账户验证码2、找回密码验证码3、绑定手机验证码4、找回密码验证码5、绑定微信验证码', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'Type';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'发送途径1、短信 2、邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'SendType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'状态1：有效0：无效', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'State';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'使用时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_Sys_PhoneCode', @level2type = N'COLUMN', @level2name = N'UseTime';

