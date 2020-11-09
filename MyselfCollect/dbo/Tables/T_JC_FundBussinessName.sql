CREATE TABLE [dbo].[T_JC_FundBussinessName] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [UNIT_NO]         NVARCHAR (30)  NULL,
    [UNIT_NAME_PRINT] NVARCHAR (500) NULL,
    [BUSI_CUST_NO]    NVARCHAR (30)  NULL,
    [BUSI_CUST_NAME]  NVARCHAR (500) NULL,
    [IsDelete]        BIT            CONSTRAINT [DF_T_FundBussinessName_IsDelete] DEFAULT ((0)) NOT NULL,
    [CreateTime]      DATE           CONSTRAINT [DF_T_FundBussinessName_CreateTime] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]      DATE           CONSTRAINT [DF_T_FundBussinessName_UpdateTime] DEFAULT (getdate()) NOT NULL,
    [OptAccount]      NVARCHAR (20)  NULL,
    CONSTRAINT [PK_T_FUNDBUSSINESSNAME] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Id', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'UNIT_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'公积金单位名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'UNIT_NAME_PRINT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NO';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'业务客户名称', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'BUSI_CUST_NAME';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'是否删除', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'IsDelete';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'CreateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'UpdateTime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'操作人员', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'T_JC_FundBussinessName', @level2type = N'COLUMN', @level2name = N'OptAccount';

