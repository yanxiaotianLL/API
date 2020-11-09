CREATE TABLE [dbo].[T_JC_SMS_History] (
    [Id]         INT             NOT NULL,
    [Phone]      VARCHAR (15)    NOT NULL,
    [CreateTime] DATE            DEFAULT (getdate()) NOT NULL,
    [IsDelete]   BIT             DEFAULT ((0)) NOT NULL,
    [UpdateTime] DATE            NOT NULL,
    [Message]    NVARCHAR (1000) NULL,
    CONSTRAINT [PK_T_JC_SMS_HISTORY] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'短信发送记录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SMS_History';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'vchar', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SMS_History', @level2type = N'COLUMN', @level2name = N'Phone';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SMS_History', @level2type = N'COLUMN', @level2name = N'UpdateTime';

