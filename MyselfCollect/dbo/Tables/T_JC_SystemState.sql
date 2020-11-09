CREATE TABLE [dbo].[T_JC_SystemState] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [IsDelete]    BIT           DEFAULT ((0)) NOT NULL,
    [CreateTime]  DATE          DEFAULT (getdate()) NOT NULL,
    [UpdateTime]  DATE          DEFAULT (getdate()) NOT NULL,
    [State]       BIT           DEFAULT ((1)) NULL,
    [Description] NVARCHAR (50) NULL,
    CONSTRAINT [PK_T_JC_SYSTEMSTATE] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统状态变更表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SystemState';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SystemState', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SystemState', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SystemState', @level2type = N'COLUMN', @level2name = N'UpdateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系统运行状态
   
   0:运行维护状态
   1:系统正常运行', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_SystemState', @level2type = N'COLUMN', @level2name = N'State';

