-- =============================================
-- Author:		<Author,,刘勇>
-- Create date: <Create Date,,2018年3月5日 09:42:39>
-- Description:	<Description,,临时帐号创建，已有帐号匹配>
-- =============================================
CREATE PROCEDURE [dbo].[P_CreateAccountTest]
	@taskid INT,
	@password NVARCHAR(30)
	
	--@Result BIT
	--@isbeijing INT -- 0 非北京,1 北京
AS
--SELECT @Result = 0;--执行结果
BEGIN
	--声明变量 
	DECLARE 
   @CON_ACCE_ID          nvarchar(50),  
   @BUSI_CUST_NO         nvarchar(30),
   @Address_ID           nvarchar(30),
   @Address              nvarchar(20),
   @CONT_NO              nvarchar(30),
   @SEND_USER_ID         varchar(100),
   @SEND_ORG_ID          varchar(100),
   @BUSI_CUST_NAME       nvarchar(300),
   @CONT_NAME            nvarchar(300),
   @ACCE_NO              varchar(100),
   @ACCE_NAME            nvarchar(300),
   @SUPP_NO              varchar(100),
   @SUPP_NAME            nvarchar(300),  
   @RECE_SUPPLIERR_NAME  nvarchar(200),
   @RECE_SUPPLIER_ID     varchar(50),
   @REG_NO               varchar(50),
   @UNIT_REG_NO          nvarchar(30),
   @SEND_LOGIN_NAME      nvarchar(30),
   @SEND_USER            nvarchar(30);
	--声明游标
	DECLARE T_JC_TaskUnitCusor CURSOR FAST_FORWARD FOR
        SELECT DISTINCT CON_ACCE_ID,BUSI_CUST_NO,Address_ID,Address,CONT_NO,SEND_USER_ID,SEND_ORG_ID,BUSI_CUST_NAME,CONT_NAME,ACCE_NO,SUPP_NO,SUPP_NAME,RECE_SUPPLIERR_NAME,RECE_SUPPLIER_ID,REG_NO,UNIT_REG_NO,SEND_LOGIN_NAME,SEND_USER
    FROM [dbo].[T_JC_TaskUnit] 
    WHERE TaskId = @taskid;
    
OPEN T_JC_TaskUnitCusor;

-- 取第一条记录
FETCH NEXT FROM T_JC_TaskUnitCusor INTO @CON_ACCE_ID,@BUSI_CUST_NO,@Address_ID,@Address,@CONT_NO,@SEND_USER_ID,@SEND_ORG_ID,@BUSI_CUST_NAME,@CONT_NAME,@ACCE_NO,@SUPP_NO,@SUPP_NAME,@RECE_SUPPLIERR_NAME,@RECE_SUPPLIER_ID,@REG_NO,@UNIT_REG_NO,@SEND_LOGIN_NAME,@SEND_USER;

WHILE @@FETCH_STATUS=0
BEGIN
     DECLARE
     @ACCOUNT_ID INT,
     @ACCOUNT_NAME NVARCHAR(50),
     @ACCOUNT_COUNT INT;
     
    --获取现有帐号（根据业务客户和地区）
    SELECT @ACCOUNT_COUNT = COUNT(1) FROM [dbo].[T_JC_Account] WHERE  IsDelete = 0 AND BUSI_CUST_NO = @BUSI_CUST_NO AND AddressId = @Address_ID;
    --根据合同附件ID获取是否存在帐号
      SET  @ACCOUNT_ID = NULL;
      SELECT  @ACCOUNT_ID = AccountID FROM [dbo].[T_JC_Account_AttachData] WHERE  IsDelete = 0 AND CON_ACCE_ID = @CON_ACCE_ID;
    PRINT @ACCOUNT_ID;
    PRINT @CON_ACCE_ID;
    IF @ACCOUNT_ID IS NOT NULL
    BEGIN  
    FETCH NEXT FROM T_JC_TaskUnitCusor INTO @CON_ACCE_ID,@BUSI_CUST_NO,@Address_ID,@Address,@CONT_NO,@SEND_USER_ID,@SEND_ORG_ID,@BUSI_CUST_NAME,@CONT_NAME,@ACCE_NO,@SUPP_NO,@SUPP_NAME,@RECE_SUPPLIERR_NAME,@RECE_SUPPLIER_ID,@REG_NO,@UNIT_REG_NO,@SEND_LOGIN_NAME,@SEND_USER;
    CONTINUE;
    END
    
    
    --start--IF帐号匹配成功
    IF @ACCOUNT_COUNT = 1 --帐号匹配成功
    BEGIN
    --取到当前匹配的账户
    SELECT  @ACCOUNT_ID = Id FROM [dbo].[T_JC_Account] WHERE  IsDelete = 0 AND BUSI_CUST_NO = @BUSI_CUST_NO AND [AddressId] = @Address_ID;

         INSERT INTO [dbo].[T_JC_Account_AttachData]
           ([AccountId]
           ,[CON_ACCE_ID]
           ,[BUSI_CUST_NO]
           ,[Address_ID]
           ,[Address]
           ,[CONT_NO]
           ,[SEND_USER_ID]
           ,[SEND_ORG_ID]
           ,[BUSI_CUST_NAME]
           ,[CONT_NAME]
           ,[ACCE_NO]
           ,[ACCE_NAME]
           ,[SUPP_NO]
           ,[SUPP_NAME]
           ,[RECE_SUPPLIERR_NAME]
           ,[RECE_SUPPLIER_ID]
           ,[REG_NO]
           ,[SEND_LOGIN_NAME])
     VALUES
           (@ACCOUNT_ID
           ,@CON_ACCE_ID
           ,@BUSI_CUST_NO
           ,@Address_ID
           ,@Address
           ,@CONT_NO
           ,@SEND_USER_ID
           ,@SEND_ORG_ID
           ,@BUSI_CUST_NAME
           ,@CONT_NAME
           ,@ACCE_NO
           ,@ACCE_NAME
           ,@SUPP_NO
           ,@SUPP_NAME
           ,@RECE_SUPPLIERR_NAME
           ,@RECE_SUPPLIER_ID
           ,@REG_NO
           ,@SEND_LOGIN_NAME);   
    --end--IF帐号匹配成功
    END 
    ELSE --匹配不成功
    --start --匹配不成功,存在多条记录，继续细化帐号拆分
    BEGIN  
    
    --生成帐号临时秘密 --start
    DECLARE @HRPassword NVARCHAR(8);
    EXEC dbo.P_CreateTempAccount @HRPassword OUTPUT ;  
    --生成帐号临时秘密 --end
     
    --生成帐号主信息
    INSERT INTO [dbo].[T_JC_Account]
           ([Password]
           ,[RealName]
           ,[Email]
           ,[Phone]
           ,[State]
           ,[IsEmailVerification]
           ,[IsPhoneVerification]
           ,[BUSI_CUST_NO]
           ,[AddressId]
           ,[Address]
           ,[TempPassword])
     VALUES
           (dbo.MD5(@HRPassword)
           ,''
           ,''
           ,''
           ,0
           ,0
           ,0
           ,@BUSI_CUST_NO
           ,@Address_ID
           ,@Address
           ,@HRPassword);
    --生成帐号数据副表
    SELECT @ACCOUNT_ID = @@IDENTITY;
    SELECT @ACCOUNT_NAME = 'temp'+RIGHT(@ACCOUNT_ID,6);
    --将用户临时生成登录名称更新到记录
    UPDATE [dbo].[T_JC_Account] SET Name = @ACCOUNT_NAME WHERE Id = @ACCOUNT_ID;
    INSERT INTO [dbo].[T_JC_Account_AttachData]
           ([AccountId]
           ,[CON_ACCE_ID]
           ,[BUSI_CUST_NO]
           ,[Address_ID]
           ,[Address]
           ,[CONT_NO]
           ,[SEND_USER_ID]
           ,[SEND_ORG_ID]
           ,[BUSI_CUST_NAME]
           ,[CONT_NAME]
           ,[ACCE_NO]
           ,[ACCE_NAME]
           ,[SUPP_NO]
           ,[SUPP_NAME]
           ,[RECE_SUPPLIERR_NAME]
           ,[RECE_SUPPLIER_ID]
           ,[REG_NO]
           ,[SEND_LOGIN_NAME])
     VALUES
           (@ACCOUNT_ID
           ,@CON_ACCE_ID
           ,@BUSI_CUST_NO
           ,@Address_ID
           ,@Address
           ,@CONT_NO
           ,@SEND_USER_ID
           ,@SEND_ORG_ID
           ,@BUSI_CUST_NAME
           ,@CONT_NAME
           ,@ACCE_NO
           ,@ACCE_NAME
           ,@SUPP_NO
           ,@SUPP_NAME
           ,@RECE_SUPPLIERR_NAME
           ,@RECE_SUPPLIER_ID
           ,@REG_NO
           ,@SEND_LOGIN_NAME);
           
           
    
    END
    
    
    --end --匹配不成功
    -- 取下一条记录
    FETCH NEXT FROM T_JC_TaskUnitCusor INTO @CON_ACCE_ID,@BUSI_CUST_NO,@Address_ID,@Address,@CONT_NO,@SEND_USER_ID,@SEND_ORG_ID,@BUSI_CUST_NAME,@CONT_NAME,@ACCE_NO,@SUPP_NO,@SUPP_NAME,@RECE_SUPPLIERR_NAME,@RECE_SUPPLIER_ID,@REG_NO,@UNIT_REG_NO,@SEND_LOGIN_NAME,@SEND_USER;
END

-- 关闭游标
CLOSE T_JC_TaskUnitCusor;

-- 释放游标
DEALLOCATE T_JC_TaskUnitCusor;
--SELECT @Result = 1;--执行结果	
END
