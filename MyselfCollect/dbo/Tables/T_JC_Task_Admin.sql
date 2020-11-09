CREATE TABLE [dbo].[T_JC_Task_Admin] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [TaskId]           INT            NULL,
    [SEND_USER_ID]     VARCHAR (100)  NULL,
    [SEND_ORG_ID]      VARCHAR (100)  NOT NULL,
    [SEND_LOGIN_NAME]  NVARCHAR (50)  NULL,
    [SEND_ORG_NAME]    NVARCHAR (200) NULL,
    [SEND_USER]        NVARCHAR (200) NULL,
    [UpdateTime]       DATE           CONSTRAINT [DF_T_JC_Task_Admin_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [SEND_LOGIN_EMAIL] VARCHAR (100)  NULL,
    [IsDelete]         BIT            CONSTRAINT [DF__T_JC_Task__IsDel__269AB60B] DEFAULT ((0)) NOT NULL,
    [CreateTime]       DATE           CONSTRAINT [DF__T_JC_Task__Creat__278EDA44] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_T_JC_TASK_ADMIN] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_T_JC_TAS_REFERENCE_T_JC_TAS] FOREIGN KEY ([TaskId]) REFERENCES [dbo].[T_JC_Task] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'记录业务管理员与采集的关系，便于系统查询记录', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_ORG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'UpdateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_EMAIL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task_Admin', @level2type = N'COLUMN', @level2name = N'CreateTime';

