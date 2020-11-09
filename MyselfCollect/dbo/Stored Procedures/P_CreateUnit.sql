-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[P_CreateUnit]
	-- Add the parameters for the stored procedure here
	@CON_ACCE_ID NVARCHAR(20),
    @BUSI_CUST_NO NVARCHAR(30),
    @UNIT_NO NVARCHAR(30),
    @Address_ID  NVARCHAR(30),
    @Address NVARCHAR(20),
    @taskid INT,
    @StartTime DATE,
    @EndTime DATE,    
    @CONT_NO NVARCHAR(30),
    @ACCE_NO NVARCHAR(30),
    @SUPP_NO NVARCHAR(30),
    @IsNeedCollectTable BIT,
    @CollectlType NVARCHAR(20),
    @CollectlProduct INT,
    @SEND_USER_ID VARCHAR(100),
    @SEND_ORG_ID  VARCHAR(100),
    @UNIT_REG_NO NVARCHAR(30),
    @SEND_LOGIN_NAME NVARCHAR(30), 
    @REG_NO VARCHAR(50),
    @RECE_SUPPLIER_ID VARCHAR(50),
    @CONT_NAME NVARCHAR(300),
    @ACCE_NAME NVARCHAR(300),
    @SUPP_NAME NVARCHAR(300),
    @RECE_SUPPLIERR_NAME NVARCHAR(200),
    @UNIT_NAME_PRINT NVARCHAR(200),
    @SEND_ORG_NAME NVARCHAR(200),
    @SEND_LOGIN_EMAIL NVARCHAR(50),--@SEND_LOGIN_EMAIL
    @SEND_SUPPLIER_ID NVARCHAR(50),
    @BUSI_CUST_NAME NVARCHAR(200),
    @SEND_USER NVARCHAR(100),
    @TASK_UNIT_ID INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

           PRINT '--------------------START-----------------遍历游标指向的所有数据,生成任务子项-----------------';
        declare @UNIT_RATE VARCHAR(10);
        SET @UNIT_RATE = '';
        IF @Address_ID = '752254'
        BEGIN
        SET @UNIT_RATE = '12%';
        END
        
        
                    INSERT  INTO [dbo].[T_JC_TaskUnit]
                            ( [CON_ACCE_ID] ,
                              [BUSI_CUST_NO] ,
                              [UNIT_NO] ,
                              [Address_ID] ,
                              [Address] ,
                              [TaskId] ,
                              [StartTime] ,
                              [EndTime] ,
                              [State] ,
                              [CONT_NO] ,
                              [ACCE_NO] ,
                              [SUPP_NO] ,
                              [IsNeedCollectTable] ,
                              [IsNeedAuditing] ,
                              [AuditingState] ,
                              [AuditingAccountName] ,
                              [AuditingAccountID] ,
                              [CollectionTableNo] ,
                              [CollectlType] ,
                              [CollectlProduct] ,
                              [ShiKaiRate] ,
                              [NotShiKaiRate] ,
                              [SheBaoCapValue] ,
                              [GongJiJinCapValue] ,
                              [SEND_USER_ID] ,
                              [SEND_ORG_ID] ,
                              [UNIT_REG_NO] ,
                              [SEND_LOGIN_NAME] ,
                              [REG_NO] ,
                              [RECE_SUPPLIER_ID] ,
                              [CONT_NAME] ,
                              [ACCE_NAME] ,
                              [SUPP_NAME] ,
                              [RECE_SUPPLIERR_NAME] ,
                              [UNIT_NAME_PRINT] ,
                              [SEND_ORG_NAME],
                              [SEND_LOGIN_EMAIL],
                              [SEND_SUPPLIER_ID],
                              [BUSI_CUST_NAME],
                              [SEND_USER],
                              [UnitRate]
                              
                            )
                    VALUES  ( @CON_ACCE_ID ,
                              @BUSI_CUST_NO ,
                              @UNIT_NO ,
                              @Address_ID ,
                              @Address ,
                              @taskid ,
                              @StartTime ,
                              @EndTime ,
                              0 ,
                              @CONT_NO ,
                              @ACCE_NO ,
                              @SUPP_NO ,
                              @IsNeedCollectTable ,
                              0 ,
                              0 ,
                              '' ,
                              0 ,
                              '' ,
                              @CollectlType ,
                              @CollectlProduct ,
                              '' ,
                              '' ,
                              '' ,
                              '' ,
                              @SEND_USER_ID ,
                              @SEND_ORG_ID ,
                              @UNIT_REG_NO ,
                              @SEND_LOGIN_NAME ,
                              @REG_NO ,
                              @RECE_SUPPLIER_ID ,
                              @CONT_NAME ,
                              @ACCE_NAME ,
                              @SUPP_NAME ,
                              @RECE_SUPPLIERR_NAME ,
                              @UNIT_NAME_PRINT ,
                              @SEND_ORG_NAME,
                              @SEND_LOGIN_EMAIL ,--@SEND_LOGIN_EMAIL
                              @SEND_SUPPLIER_ID,
                              @BUSI_CUST_NAME,
                              @SEND_USER,
                              @UNIT_RATE
                            );
                      
        SET @TASK_UNIT_ID = @@IDENTITY;
        
		PRINT '--------------------END-----------------遍历游标指向的所有数据,生成子项----------'  
		
END
