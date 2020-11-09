CREATE TABLE [dbo].[T_JC_TaskUnit] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [CON_ACCE_ID]         NVARCHAR (30)  NULL,
    [BUSI_CUST_NO]        NVARCHAR (30)  NULL,
    [UNIT_NO]             NVARCHAR (30)  NULL,
    [Address_ID]          NVARCHAR (50)  NULL,
    [Address]             NVARCHAR (50)  NULL,
    [AccountID]           INT            NULL,
    [AccountName]         NVARCHAR (50)  NULL,
    [IsDelete]            BIT            CONSTRAINT [DF__T_JC_Task__IsDel__7BB05806] DEFAULT ((0)) NOT NULL,
    [CreateTime]          DATETIME       CONSTRAINT [DF__T_JC_Task__Creat__7CA47C3F] DEFAULT (getdate()) NOT NULL,
    [TaskId]              INT            NULL,
    [StartTime]           DATE           NULL,
    [EndTime]             DATE           NULL,
    [State]               INT            NULL,
    [CONT_NO]             NVARCHAR (30)  NULL,
    [ACCE_NO]             NVARCHAR (30)  NULL,
    [SUPP_NO]             NVARCHAR (30)  NULL,
    [IsNeedCollectTable]  BIT            NULL,
    [IsNeedAuditing]      BIT            NULL,
    [AuditingState]       INT            CONSTRAINT [DF__T_JC_Task__Audit__7D98A078] DEFAULT ((0)) NULL,
    [AuditingAccountName] NVARCHAR (50)  NULL,
    [AuditingAccountID]   INT            NULL,
    [CollectionTableNo]   NVARCHAR (50)  NULL,
    [CollectlType]        NVARCHAR (50)  NULL,
    [CollectlProduct]     INT            NULL,
    [ShiKaiRate]          NVARCHAR (50)  NULL,
    [NotShiKaiRate]       NVARCHAR (50)  NULL,
    [SheBaoCapValue]      NVARCHAR (50)  NULL,
    [GongJiJinCapValue]   NVARCHAR (50)  NULL,
    [SEND_USER_ID]        VARCHAR (30)   NULL,
    [SEND_ORG_ID]         VARCHAR (30)   NULL,
    [UNIT_REG_NO]         NVARCHAR (30)  NULL,
    [SEND_LOGIN_NAME]     NVARCHAR (200) NULL,
    [REG_NO]              VARCHAR (50)   NULL,
    [RECE_SUPPLIER_ID]    VARCHAR (50)   NULL,
    [CONT_NAME]           NVARCHAR (500) NULL,
    [ACCE_NAME]           NVARCHAR (500) NULL,
    [SUPP_NAME]           NVARCHAR (300) NULL,
    [RECE_SUPPLIERR_NAME] NVARCHAR (200) NULL,
    [UNIT_NAME_PRINT]     NVARCHAR (500) NULL,
    [BUSI_CUST_NAME]      NVARCHAR (500) NULL,
    [RECE_ORG_NAME]       NVARCHAR (200) NULL,
    [RECE_USER]           NVARCHAR (50)  NULL,
    [RECE_LOGIN_NAME]     NVARCHAR (30)  NULL,
    [SEND_ORG_NAME]       NVARCHAR (50)  NULL,
    [SEND_USER]           NVARCHAR (30)  NULL,
    [SEND_LOGIN_EMAIL]    VARCHAR (50)   NULL,
    [BUSI_CUST_ID]        VARCHAR (30)   NULL,
    [CUST_CON_ID]         VARCHAR (30)   NULL,
    [RECE_ORG_ID]         VARCHAR (30)   NULL,
    [RECE_USER_ID]        VARCHAR (30)   NULL,
    [ReceiptDate]         DATETIME       NULL,
    [ReceiptAdminName]    NVARCHAR (200) NULL,
    [UnitRate]            NVARCHAR (200) NULL,
    [UpdateTime]          DATETIME       CONSTRAINT [DF_T_JC_TaskUnit_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [SEND_SUPPLIER_ID]    VARCHAR (50)   NULL,
    CONSTRAINT [PK_T_JC_TASKUNIT] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [_dta_index_T_JC_TaskUnit_21_1426104121__K11_1_2_3_4_5_6_7_8_9_10_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_]
    ON [dbo].[T_JC_TaskUnit]([TaskId] ASC)
    INCLUDE([Id], [CON_ACCE_ID], [BUSI_CUST_NO], [UNIT_NO], [Address_ID], [Address], [AccountID], [AccountName], [IsDelete], [CreateTime], [StartTime], [EndTime], [State], [CONT_NO], [ACCE_NO], [SUPP_NO], [IsNeedCollectTable], [IsNeedAuditing], [AuditingState], [AuditingAccountName], [AuditingAccountID], [CollectionTableNo], [CollectlType], [CollectlProduct], [ShiKaiRate], [NotShiKaiRate], [SheBaoCapValue], [GongJiJinCapValue], [SEND_USER_ID], [SEND_ORG_ID], [UNIT_REG_NO], [SEND_LOGIN_NAME], [REG_NO], [RECE_SUPPLIER_ID], [CONT_NAME], [ACCE_NAME], [SUPP_NAME], [RECE_SUPPLIERR_NAME], [UNIT_NAME_PRINT], [BUSI_CUST_NAME], [RECE_ORG_NAME], [RECE_USER], [RECE_LOGIN_NAME], [SEND_ORG_NAME], [SEND_USER], [SEND_LOGIN_EMAIL], [BUSI_CUST_ID], [CUST_CON_ID], [RECE_ORG_ID], [RECE_USER_ID], [ReceiptDate], [ReceiptAdminName], [UnitRate], [UpdateTime], [SEND_SUPPLIER_ID]);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'拆分单元表
   
   从新系统数据分组提取生成，分组如下
   
   业务客户ID→合同附件ID→公积金单位编号→采集地区', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'UNIT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'Address_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'Address';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'关联账号ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'AccountID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'关联账号名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'AccountName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集任务外键关联', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'TaskId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集任务开始时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'StartTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集任务结束时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'EndTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集任务子项状态
   
   
   0    未填报：初始状态为未填报；
   1    填报中：部分员工填报；
   2    已填报：全部员工填报完成；
   3    已提交：点击【提交】或者【提交打印】后状态为“已提交”；
   4    已签收：纸质采集表签收完成后；  统一状态，改为已经完成
   
   
   未填报：初始状态为未填报；
   填报中：部分员工填报；
   已填报：全部员工填报完成；
   已提交：点击【提交】或者【提交打印】后状态为“已提交”；
   已签收：纸质采集表签收完成后；
   未登录：未登录采集系统；
   已登录：登录采集系统之后状态更新为“已登录”。
   
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'State';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CONT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'ACCE_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SUPP_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否需要纸采集表
   
   北京默认需要
   全国默认不需要
   
   所以目前之后北京的有审核流程
   
   
   北京不需要审核流程
   
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'IsNeedCollectTable';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否需要纸采集表是否需要审核', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'IsNeedAuditing';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'审核状态
   0  审核通过  1  审核不通过 -1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'AuditingState';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'审核人', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'AuditingAccountName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'审核人ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'AuditingAccountID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集表生成编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CollectionTableNo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CollectlType';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集产品
   
   0  公积金和社保
   1  社保
   2  公积金', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CollectlProduct';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金实开比例', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'ShiKaiRate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金非实开比例', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'NotShiKaiRate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保特殊封顶值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SheBaoCapValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金特殊封顶值', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'GongJiJinCapValue';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'UNIT_REG_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'REG_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CONT_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'ACCE_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SUPP_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIERR_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'UNIT_NAME_PRINT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务部', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_ORG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单客服', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单客服登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_ORG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_EMAIL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'CUST_CON_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'RECE_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签收时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'ReceiptDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签收人', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'ReceiptAdminName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金缴纳比例', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'UnitRate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_TaskUnit', @level2type = N'COLUMN', @level2name = N'SEND_SUPPLIER_ID';

