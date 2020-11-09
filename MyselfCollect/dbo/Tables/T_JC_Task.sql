CREATE TABLE [dbo].[T_JC_Task] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [StartTime]         DATE           NOT NULL,
    [EndTime]           DATE           NOT NULL,
    [WageAccuracy]      INT            NOT NULL,
    [CollectlType]      NVARCHAR (20)  NOT NULL,
    [CreateTime]        DATETIME       CONSTRAINT [DF__T_JC_Task__Creat__1332DBDC] DEFAULT (getdate()) NOT NULL,
    [IsDelete]          BIT            CONSTRAINT [DF__T_JC_Task__IsDel__14270015] DEFAULT ((0)) NOT NULL,
    [Address]           NVARCHAR (20)  NOT NULL,
    [Address_ID]        NVARCHAR (30)  NOT NULL,
    [Description]       NVARCHAR (30)  NULL,
    [OrderID]           NVARCHAR (30)  NULL,
    [ShiKaiRate]        NVARCHAR (200) NULL,
    [NotShiKaiRate]     NVARCHAR (200) NULL,
    [CollectProduct]    INT            NOT NULL,
    [TaskType]          INT            CONSTRAINT [DF_T_JC_Task_TaskType] DEFAULT ((0)) NOT NULL,
    [UpdateTime]        DATETIME       CONSTRAINT [DF_T_JC_Task_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [NeedCollectTable]  BIT            CONSTRAINT [DF_T_JC_Task_NeedCollectTable_1] DEFAULT ((0)) NOT NULL,
    [IsForceDefault]    BIT            CONSTRAINT [DF_T_JC_Task_IsForceDefault_1] DEFAULT ((0)) NOT NULL,
    [IsInit]            BIT            CONSTRAINT [DF_T_JC_Task_IsInit] DEFAULT ((0)) NOT NULL,
    [SheBaoCapValue]    NVARCHAR (50)  NULL,
    [GongJiJinCapValue] NVARCHAR (50)  NULL,
    [UnitRate]          NVARCHAR (200) NULL,
    [IsLock]            BIT            CONSTRAINT [DF_T_JC_Task_IsLock] DEFAULT ((0)) NULL,
    [IsCallBack]        BIT            CONSTRAINT [DF_T_JC_Task_IsCallBack] DEFAULT ((0)) NULL,
    [TaskBatchCode]     NVARCHAR (50)  NULL,
    CONSTRAINT [PK_T_JC_TASK] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'集采任务表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集工作开始日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'StartTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集工作结束日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'EndTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'工资精度', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'WageAccuracy';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'CollectlType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建日期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'Address';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'Address_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集任务说明', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'Description';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'新系统订单号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'OrderID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'实开比例集合', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'ShiKaiRate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'非实开比例集合', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'NotShiKaiRate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集产品
   
   0  公积金和社保
   1  社保
   2  公积金', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'CollectProduct';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否需要采集表默认值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'NeedCollectTable';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否强制按默认项执行', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'IsForceDefault';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否进行了数据初始化操作', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'IsInit';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保特殊封顶值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'SheBaoCapValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金特殊封顶值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'GongJiJinCapValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金缴纳比例', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Task', @level2type = N'COLUMN', @level2name = N'UnitRate';

