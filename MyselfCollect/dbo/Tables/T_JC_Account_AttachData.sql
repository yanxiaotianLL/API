CREATE TABLE [dbo].[T_JC_Account_AttachData] (
    [CreateTime]          DATE           CONSTRAINT [DF__T_JC_Acco__Creat__5E1FF51F] DEFAULT (getdate()) NULL,
    [IsDelete]            BIT            CONSTRAINT [DF__T_JC_Acco__IsDel__5F141958] DEFAULT ((0)) NOT NULL,
    [AccountId]           INT            NULL,
    [CON_ACCE_ID]         NVARCHAR (50)  NULL,
    [BUSI_CUST_NO]        NVARCHAR (50)  NULL,
    [Address_ID]          NVARCHAR (30)  NULL,
    [Address]             NVARCHAR (20)  NULL,
    [UNIT_NO]             NVARCHAR (30)  NULL,
    [CONT_NO]             NVARCHAR (30)  NULL,
    [SEND_USER_ID]        VARCHAR (100)  NULL,
    [SEND_ORG_ID]         VARCHAR (100)  NULL,
    [BUSI_CUST_NAME]      NVARCHAR (500) NULL,
    [CONT_NAME]           NVARCHAR (500) NULL,
    [ACCE_NO]             VARCHAR (100)  NULL,
    [ACCE_NAME]           NVARCHAR (500) NULL,
    [SUPP_NO]             VARCHAR (100)  NULL,
    [SUPP_NAME]           NVARCHAR (500) NULL,
    [UpdateTime]          DATE           NULL,
    [RECE_SUPPLIERR_NAME] NVARCHAR (500) NULL,
    [RECE_SUPPLIER_ID]    VARCHAR (50)   NULL,
    [REG_NO]              VARCHAR (50)   NULL,
    [SEND_LOGIN_NAME]     NVARCHAR (30)  NULL,
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [SEND_ORG_NAME]       NVARCHAR (500) NULL,
    [UNIT_NAME_PRINT]     NVARCHAR (500) NULL,
    [UNIT_REG_NO]         NVARCHAR (500) NULL,
    [SEND_SUPPLIER_ID]    VARCHAR (50)   NULL,
    [SEND_USER]           VARCHAR (50)   NULL,
    CONSTRAINT [PK_T_JC_Account_AttachData] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_T_JC_Account_AttachData_T_JC_Account] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[T_JC_Account] ([Id])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'hr账户合同附件id关联表', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'CON_ACCE_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'Address_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'采集地区', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'Address';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'UNIT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'CONT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务员ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'SEND_USER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务部ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'SEND_ORG_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'商务合同名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'CONT_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'ACCE_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'合同附件名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'ACCE_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'SUPP_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'SUPP_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'UpdateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIERR_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'接单方供应商ID', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'RECE_SUPPLIER_ID';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'社保登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'REG_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'签约方业务代表登录名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'SEND_LOGIN_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金登记证号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_Account_AttachData', @level2type = N'COLUMN', @level2name = N'UNIT_REG_NO';

