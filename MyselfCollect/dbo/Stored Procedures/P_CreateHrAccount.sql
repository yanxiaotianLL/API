-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[P_CreateHrAccount]
	-- Add the parameters for the stored procedure here
	@TaskType INT,
	@ACCE_NO NVARCHAR(30),
	@TASK_UNIT_ID INT,
	@BUSI_CUST_NO NVARCHAR(30),
	@Address_ID NVARCHAR(30),	
    @CON_ACCE_ID NVARCHAR(20),
    @Address NVARCHAR(20),
    @UNIT_NO NVARCHAR(30),
    @CONT_NO NVARCHAR(30),
    @SEND_USER_ID VARCHAR(100),
    @SEND_ORG_ID  VARCHAR(100),
    @BUSI_CUST_NAME NVARCHAR(200),
    @CONT_NAME NVARCHAR(300),    
    @ACCE_NAME NVARCHAR(300),
    @SUPP_NO NVARCHAR(30),
    @SUPP_NAME NVARCHAR(300),
    @RECE_SUPPLIERR_NAME NVARCHAR(200),
    @RECE_SUPPLIER_ID VARCHAR(50),
    @REG_NO VARCHAR(50),
    @SEND_LOGIN_NAME NVARCHAR(30),
    @SEND_ORG_NAME NVARCHAR(200),
    @UNIT_NAME_PRINT NVARCHAR(200),
    @SEND_SUPPLIER_ID NVARCHAR(50),
    @SEND_USER NVARCHAR(100), 
    @UNIT_REG_NO NVARCHAR(30)
   
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    PRINT '--------------------START-----------------生成hr帐号-----------------------------'
                    IF @TaskType = 0  --如果是普通采集任务，进行hr帐号生成，补充采集不进行该数据拆分项
                        BEGIN
                            DECLARE @ACCOUNTID INT ,
                                @ACCOUNTNAME NVARCHAR(50);
        --(1)--判断hr账户-合同附件ID是否能匹配到，如果能匹配到，则使用
                            IF EXISTS ( SELECT  ACCE_NO
                                        FROM    dbo.T_JC_Account_AttachData
                                        WHERE   ACCE_NO = @ACCE_NO ) 
                                BEGIN
            
                                    SELECT  @ACCOUNTID = a.Id ,
                                            @ACCOUNTNAME = a.Name
                                    FROM    T_JC_Account a
                                            INNER JOIN T_JC_Account_AttachData d ON d.AccountId = a.Id
                                    WHERE   d.ACCE_NO = @ACCE_NO
                                            AND a.IsDelete = 0
                                            AND d.IsDelete = 0;           
            
                                    UPDATE  T_JC_TaskUnit
                                    SET     AccountID = @ACCOUNTID ,
                                            AccountName = @ACCOUNTNAME WHERE Id = @TASK_UNIT_ID; 
                                END
                            ELSE 
                                BEGIN 
			--(2)-- 如果该业务客户id下只有一个帐号，则没有进行过拆分，直接使用
                                    IF 1 = (SELECT COUNT(1) FROM (SELECT DISTINCT AccountId
                                             FROM   dbo.T_JC_Account_AttachData 
                                             WHERE  BUSI_CUST_NO = @BUSI_CUST_NO
                                                    AND IsDelete = 0  AND Address_ID = @Address_ID) t)
                                           
                                        BEGIN				
                        
                                            SELECT  @ACCOUNTID = a.Id ,
                                                    @ACCOUNTNAME = a.Name
                                            FROM    T_JC_Account a
                                            WHERE   IsDelete = 0
                                                    AND Id = (
                                                     SELECT DISTINCT AccountId
													 FROM   dbo.T_JC_Account_AttachData 
													 WHERE  BUSI_CUST_NO = @BUSI_CUST_NO
															AND IsDelete = 0  AND Address_ID = @Address_ID
													 --GROUP BY AccountId
                                                    );     
                                            UPDATE  T_JC_TaskUnit
                                            SET     AccountID = @ACCOUNTID ,
                                                    AccountName = @ACCOUNTNAME WHERE Id = @TASK_UNIT_ID;  
				
				--将帐号副表数据进行填充
			
                                            INSERT  INTO [dbo].[T_JC_Account_AttachData]
                                                    ( [CreateTime] ,
                                                      [IsDelete] ,
                                                      [AccountId] ,
                                                      [CON_ACCE_ID] ,
                                                      [BUSI_CUST_NO] ,
                                                      [Address_ID] ,
                                                      [Address] ,
                                                      [UNIT_NO] ,
                                                      [CONT_NO] ,
                                                      [SEND_USER_ID] ,
                                                      [SEND_ORG_ID] ,
                                                      [BUSI_CUST_NAME] ,
                                                      [CONT_NAME] ,
                                                      [ACCE_NO] ,
                                                      [ACCE_NAME] ,
                                                      [SUPP_NO] ,
                                                      [SUPP_NAME] ,
                                                      [UpdateTime] ,
                                                      [RECE_SUPPLIERR_NAME] ,
                                                      [RECE_SUPPLIER_ID] ,
                                                      [REG_NO] ,
                                                      [SEND_LOGIN_NAME] ,
                                                      [SEND_ORG_NAME] ,
                                                      [UNIT_NAME_PRINT],
                                                      [SEND_SUPPLIER_ID],
                                                      [SEND_USER]
                                                    )
                                            VALUES  ( GETDATE() ,
                                                      0 ,
                                                      @ACCOUNTID ,
                                                      @CON_ACCE_ID ,
                                                      @BUSI_CUST_NO ,
                                                      @Address_ID ,
                                                      @Address ,
                                                      @UNIT_NO ,
                                                      @CONT_NO ,
                                                      @SEND_USER_ID ,
                                                      @SEND_ORG_ID ,
                                                      @BUSI_CUST_NAME ,
                                                      @CONT_NAME ,
                                                      @ACCE_NO ,
                                                      @ACCE_NAME ,
                                                      @SUPP_NO ,
                                                      @SUPP_NAME ,
                                                      GETDATE() ,
                                                      @RECE_SUPPLIERR_NAME ,
                                                      @RECE_SUPPLIER_ID ,
                                                      @REG_NO ,
                                                      @SEND_LOGIN_NAME ,
                                                      @SEND_ORG_NAME ,
                                                      @UNIT_NAME_PRINT,
                                                      @SEND_SUPPLIER_ID,
                                                      @SEND_USER
                                                    );
                                        END            
            --(3)--判断该业务客户id下有几个账号，如果超过1个账号，则进行过拆分，生成临时账号
                                    ELSE 
                                        BEGIN
                                            DECLARE @return_value INT ,
                                                @PASS NVARCHAR(8);

                                            EXEC @return_value = [dbo].[P_CreateTempAccount] @PASS = @PASS OUTPUT;
                                            INSERT  INTO [dbo].[T_JC_Account]
                                                    ( [Name] ,
                                                      [Password] ,
                                                      [RealName] ,
                                                      [Email] ,
                                                      [Phone] ,
                                                      [State] ,
                                                      [IsDelete] ,
                                                      [CreateTime] ,
                                                      [ActiveTime] ,
                                                      [UpdateTime] ,
                                                      [IsEmailVerification] ,
                                                      [IsPhoneVerification] ,
                                                      [BUSI_CUST_NO] ,
                                                      [AddressId] ,
                                                      [Address] ,
                                                      [TempPassword]
                                                    )
                                            VALUES  ( '' ,
                                                      @PASS ,
                                                      '' ,
                                                      '' ,
                                                      '' ,
                                                      0 ,
                                                      0 ,
                                                      GETDATE() ,
                                                      GETDATE() ,
                                                      GETDATE() ,
                                                      0 ,
                                                      0 ,
                                                      @BUSI_CUST_NO ,
                                                      @Address_ID ,
                                                      @Address ,
                                                      @PASS
                                                    );
				 --生成临时账号名称
				 --PRINT '--生成临时账号名称'
                                            SELECT  @ACCOUNTID = @@identity;
                                            SELECT  @ACCOUNTNAME = 'temp'
                                                    + RIGHT(@ACCOUNTID, 6);
		         --将生成的临时账号名称更新到数据库
		         --PRINT ' --将生成的临时账号名称更新到数据库'
                                            UPDATE  dbo.T_JC_Account
                                            SET     Name = @ACCOUNTNAME
                                            WHERE Id = @ACCOUNTID;
		         --将帐号副表数据进行填充
		         --PRINT '  --将帐号副表数据进行填充'
                                            INSERT  INTO [dbo].[T_JC_Account_AttachData]
                                                    ( [CreateTime] ,
                                                      [IsDelete] ,
                                                      [AccountId] ,
                                                      [CON_ACCE_ID] ,
                                                      [BUSI_CUST_NO] ,
                                                      [Address_ID] ,
                                                      [Address] ,
                                                      [UNIT_NO] ,
                                                      [CONT_NO] ,
                                                      [SEND_USER_ID] ,
                                                      [SEND_ORG_ID] ,
                                                      [BUSI_CUST_NAME] ,
                                                      [CONT_NAME] ,
                                                      [ACCE_NO] ,
                                                      [ACCE_NAME] ,
                                                      [SUPP_NO] ,
                                                      [SUPP_NAME] ,
                                                      [UpdateTime] ,
                                                      [RECE_SUPPLIERR_NAME] ,
                                                      [RECE_SUPPLIER_ID] ,
                                                      [REG_NO] ,
                                                      [SEND_LOGIN_NAME] ,
                                                      [SEND_ORG_NAME] ,
                                                      [UNIT_NAME_PRINT],
                                                      [UNIT_REG_NO],
                                                      [SEND_USER]
                                                    )
                                            VALUES  ( GETDATE() ,
                                                      0 ,
                                                      @ACCOUNTID ,
                                                      @CON_ACCE_ID ,
                                                      @BUSI_CUST_NO ,
                                                      @Address_ID ,
                                                      @Address ,
                                                      @UNIT_NO ,
                                                      @CONT_NO ,
                                                      @SEND_USER_ID ,
                                                      @SEND_ORG_ID ,
                                                      @BUSI_CUST_NAME ,
                                                      @CONT_NAME ,
                                                      @ACCE_NO ,
                                                      @ACCE_NAME ,
                                                      @SUPP_NO ,
                                                      @SUPP_NAME ,
                                                      GETDATE() ,
                                                      @RECE_SUPPLIERR_NAME ,
                                                      @RECE_SUPPLIER_ID ,
                                                      @REG_NO ,
                                                      @SEND_LOGIN_NAME ,
                                                      @SEND_ORG_NAME ,
                                                      @UNIT_NAME_PRINT,
                                                      @UNIT_REG_NO,
                                                      @SEND_USER
                                                    );
                                    UPDATE  T_JC_TaskUnit
                                    SET     AccountID = @ACCOUNTID ,
                                            AccountName = @ACCOUNTNAME WHERE Id = @TASK_UNIT_ID; 
                                    END
        
                                END    
                        END
        
        
        

        --------------------END-----------------生成hr帐号-------------------------------
    
END
