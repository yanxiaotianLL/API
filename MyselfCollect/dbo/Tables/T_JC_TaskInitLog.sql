CREATE TABLE [dbo].[T_JC_TaskInitLog] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [ErrorLine]      NVARCHAR (20)   NULL,
    [ErrorMessage]   NVARCHAR (1000) NULL,
    [ErrorNumber]    NVARCHAR (20)   NULL,
    [ErrorProcedure] NVARCHAR (100)  NULL,
    [ErrorSeverity]  NVARCHAR (10)   NULL,
    [ErrorState]     NVARCHAR (20)   NULL,
    [IsDelete]       BIT             NULL,
    [CreateTime]     DATE            NULL,
    [UpdateTime]     DATE            NULL,
    [InfoMesssage]   NVARCHAR (1000) NULL,
    CONSTRAINT [PK_T_JC_TASKINITLOG] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'任务初始化过程日志记录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskInitLog';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskInitLog', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskInitLog', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskInitLog', @level2type = N'COLUMN', @level2name = N'UpdateTime';

