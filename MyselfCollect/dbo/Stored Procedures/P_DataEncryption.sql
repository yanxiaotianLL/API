-- =============================================
-- Author:		刘勇
-- Create date: 2018年3月22日 10:59:39
-- Description:	任务受保护数据加密
-- =============================================
CREATE PROCEDURE [dbo].[P_DataEncryption]
	@TaskID INT, -- 任务ID
	@Password NVARCHAR(50) --用于加密的密钥	
AS
BEGIN
	IF EXISTS(SELECT * FROM dbo.T_JC_Task WHERE Id = @TaskID)
	BEGIN
	UPDATE dbo.T_JC_DataItem 
	SET 
		EMP_NAME = dbo.Encryption(EMP_NAME,@Password),--员工姓名
		EMP_ID_CARD = dbo.Encryption(EMP_ID_CARD,@Password),--证件号
		BUSI_CUST_NAME = dbo.Encryption(BUSI_CUST_NAME,@Password),--业务客户
		CONT_NAME = dbo.Encryption(CONT_NAME,@Password),--商务合同
		ACCE_NAME = dbo.Encryption(ACCE_NAME,@Password),--合同附件名称
		RECE_SUPPLIERR_NAME = dbo.Encryption(RECE_SUPPLIERR_NAME,@Password),--接单方供应商名称
		SUPP_NAME = dbo.Encryption(SUPP_NAME,@Password), --签约方供应商名称
		UNIT_NAME_PRINT = dbo.Encryption(UNIT_NAME_PRINT,@Password)--公积金单位名称
	WHERE JC_Task_ID = @TaskID;
	
	END
	
END
