CREATE TABLE [dbo].[T_JC_File] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FileID]      NVARCHAR (50) NOT NULL,
    [FileName]    NVARCHAR (50) NULL,
    [Description] NVARCHAR (50) NULL,
    [FileType]    NVARCHAR (50) NULL,
    [TaskId]      INT           NULL,
    [CreateTime]  DATE          CONSTRAINT [DF__T_JC_File__Creat__10566F31] DEFAULT (getdate()) NOT NULL,
    [IsDelete]    BIT           CONSTRAINT [DF_T_JC_File_IsDelete] DEFAULT ((0)) NOT NULL,
    [UpdateTime]  DATE          CONSTRAINT [DF_T_JC_File_UpdateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_JC_FILE] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_T_JC_FIL_REFERENCE_T_JC_TAS] FOREIGN KEY ([TaskId]) REFERENCES [dbo].[T_JC_Task] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'数据文件表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'新系统文件系统唯一标识', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'FileID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'文件名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'FileName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'文件描述', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'文件类型
    0：采集数据文件
    1: 资料文档', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'FileType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'任务主键', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'TaskId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_File', @level2type = N'COLUMN', @level2name = N'IsDelete';

