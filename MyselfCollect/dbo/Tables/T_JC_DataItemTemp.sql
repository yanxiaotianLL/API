CREATE TABLE [dbo].[T_JC_DataItemTemp] (
    [Id]                  BIGINT          IDENTITY (1, 1) NOT NULL,
    [order_id]            NVARCHAR (50)   NULL,
    [UNIQ_NO]             NVARCHAR (20)   NULL,
    [EMP_NAME]            NVARCHAR (200)  NULL,
    [CER_TYPE]            NVARCHAR (20)   NULL,
    [EMP_ID_CARD]         NVARCHAR (20)   NULL,
    [EMP_IN_CODE]         NVARCHAR (50)   NULL,
    [COST_CENT_NO]        NVARCHAR (50)   NULL,
    [PER_PKG_NAME]        NVARCHAR (200)  NULL,
    [REG_NO]              NVARCHAR (30)   NULL,
    [UNIT_REG_NO]         NVARCHAR (30)   NULL,
    [UNIT_NO]             NVARCHAR (30)   NULL,
    [UNIT_NAME_PRINT]     NVARCHAR (50)   NULL,
    [INS_DECL_WAGE]       NVARCHAR (30)   NULL,
    [INS_BASE_WAGE]       NVARCHAR (30)   NULL,
    [ACCU_DECL_WAGE]      NVARCHAR (30)   NULL,
    [ACCU_BASE_WAGE]      NVARCHAR (30)   NULL,
    [BUSI_CUST_NO]        NVARCHAR (30)   NULL,
    [BUSI_CUST_NAME]      NVARCHAR (200)  NULL,
    [CONT_NO]             NVARCHAR (30)   NULL,
    [CONT_NAME]           NVARCHAR (200)  NULL,
    [ACCE_NO]             NVARCHAR (30)   NULL,
    [ACCE_NAME]           NVARCHAR (200)  NULL,
    [RECE_ORG_NAME]       NVARCHAR (200)  NULL,
    [RECE_USER]           NVARCHAR (50)   NULL,
    [RECE_LOGIN_NAME]     NVARCHAR (30)   NULL,
    [SEND_ORG_NAME]       NVARCHAR (200)  NULL,
    [SEND_USER]           NVARCHAR (30)   NULL,
    [SEND_LOGIN_NAME]     NVARCHAR (200)  NULL,
    [SEND_LOGIN_EMAIL]    NVARCHAR (50)   NULL,
    [SUPP_NAME]           NVARCHAR (200)  NULL,
    [SUPP_NO]             NVARCHAR (30)   NULL,
    [AREA_ID]             NVARCHAR (50)   NULL,
    [COLLT_TYPE]          NVARCHAR (30)   NULL,
    [PER_PKG_ID]          NVARCHAR (50)   NULL,
    [BUSI_CUST_ID]        NVARCHAR (50)   NULL,
    [CUST_CON_ID]         NVARCHAR (50)   NULL,
    [CON_ACCE_ID]         NVARCHAR (20)   NULL,
    [RECE_ORG_ID]         NVARCHAR (20)   NULL,
    [RECE_USER_ID]        NVARCHAR (20)   NULL,
    [SEND_ORG_ID]         NVARCHAR (20)   NULL,
    [SEND_USER_ID]        NVARCHAR (20)   NULL,
    [JC_Task_ID]          INT             NULL,
    [CreateTime]          DATE            CONSTRAINT [DF_T_JC_DataItemTemp_CreateTime] DEFAULT (getdate()) NULL,
    [IsDelete]            BIT             CONSTRAINT [DF_T_JC_DataItemTemp_IsDelete] DEFAULT ((0)) NULL,
    [RECE_SUPPLIERR_NAME] NVARCHAR (200)  NULL,
    [APEA]                NVARCHAR (200)  NULL,
    [PRODUCTTYPE]         NVARCHAR (20)   NULL,
    [PRODUCTID]           NVARCHAR (50)   NULL,
    [RECE_SUPPLIER_ID]    NVARCHAR (50)   NULL,
    [SEND_SUPPLIER_ID]    NVARCHAR (50)   NULL,
    [UpdateTime]          DATE            CONSTRAINT [DF_T_JC_DataItemTemp_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [JC_TaskUnit_ID]      INT             NULL,
    [State]               INT             CONSTRAINT [DF_T_JC_DataItemTemp_State] DEFAULT ((0)) NOT NULL,
    [INS_DECL_WAGE_NOW]   DECIMAL (18, 3) CONSTRAINT [DF_T_JC_DataItemTemp_INS_DECL_WAGE_NOW] DEFAULT ((0)) NULL,
    [ACCU_DECL_WAGE_NOW]  DECIMAL (18, 3) CONSTRAINT [DF_T_JC_DataItemTemp_ACCU_DECL_WAGE_NOW] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_T_JC_DataItemTemp] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'新系统数据中转', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'订单id
   order_id
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'order_id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'唯一号
   UNIQ_NO
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'UNIQ_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'雇员姓名
   EMP_NAME
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'EMP_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'证件类型
   CER_TYPE
   ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CER_TYPE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'证件号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'EMP_ID_CARD';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'员工内部编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'EMP_IN_CODE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'成本中心编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'COST_CENT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'成本中心名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'PER_PKG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'REG_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'UNIT_REG_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'UNIT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'UNIT_NAME_PRINT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保原工资', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'INS_DECL_WAGE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保原基数', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'INS_BASE_WAGE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金原工资', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'ACCU_DECL_WAGE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金原基数', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'ACCU_BASE_WAGE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CONT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CONT_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'ACCE_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'ACCE_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务部', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_ORG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单客服', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单客服登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_ORG_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_USER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表邮箱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_EMAIL';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SUPP_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SUPP_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'AREA_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'COLLT_TYPE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'成本中心ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'PER_PKG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CUST_CON_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CON_ACCE_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIERR_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'APEA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'产品类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'PRODUCTTYPE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'产品ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'PRODUCTID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'SEND_SUPPLIER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'填报状态，0：未填报，1：已经填报', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'State';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保当前工资', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'INS_DECL_WAGE_NOW';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金当前工资', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_DataItemTemp', @level2type = N'COLUMN', @level2name = N'ACCU_DECL_WAGE_NOW';

