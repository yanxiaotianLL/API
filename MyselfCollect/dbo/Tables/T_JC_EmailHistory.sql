CREATE TABLE [dbo].[T_JC_EmailHistory] (
    [Id]         INT             NOT NULL,
    [CreateTime] DATE            DEFAULT (getdate()) NULL,
    [IsDelete]   BIT             DEFAULT ((0)) NOT NULL,
    [UpdateTime] DATE            NOT NULL,
    [Recipients] NVARCHAR (50)   NOT NULL,
    [Message]    NVARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_T_JC_EMAILHISTORY] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'邮件发送记录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_EmailHistory';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_EmailHistory', @level2type = N'COLUMN', @level2name = N'UpdateTime';

