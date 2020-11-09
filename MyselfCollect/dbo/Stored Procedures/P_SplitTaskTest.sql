-- =============================================
-- Author:		<Author,,刘勇>
-- Create date: <Create Date,,17:16:45>
-- Description:	<Description,,拆分任务单元并初始化用户>
-- =============================================
CREATE PROCEDURE [dbo].[P_SplitTaskTest]
    @taskid INT ,
    @Address_ID NVARCHAR(30) ,
    @Address NVARCHAR(20) ,
    @StartTime DATE ,
    @EndTime DATE ,
    @CollectlType NVARCHAR(20) ,
    @CollectlProduct INT ,
    @IsNeedCollectTable BIT ,--是否需要纸采集表
    @PASSWORD NVARCHAR(30) , --用于加密敏感信息
    @TaskType INT ,--任务类型0:普通任务1：补充采集
    @ResultCode BIT OUTPUT ,  --执行结果 0 失败  1 成功
    @ResultMessage NVARCHAR(500) OUTPUT --失败原因
AS --执行结果初始化
    SET @ResultCode = 1;
    SET @ResultMessage = '';
    BEGIN
	    --声明变量,用于接收游标数据
        DECLARE @CON_ACCE_ID NVARCHAR(20) ,--合同附件ID
            @BUSI_CUST_NO NVARCHAR(30) ,--业务客户编号
            @UNIT_NO NVARCHAR(30) ,--公积金单位编号
            @CONT_NO NVARCHAR(30) ,--商务合同编号
            @ACCE_NO NVARCHAR(30) ,--合同附件编号
            @SUPP_NO NVARCHAR(30) ,--签约方供应商编号
            @SEND_USER_ID VARCHAR(100) ,--签约方业务员ID
            @SEND_USER NVARCHAR(100),--签约方业务代表
            @SEND_ORG_ID VARCHAR(100) ,--签约方业务部ID
            @UNIT_REG_NO NVARCHAR(30) ,--公积金登记证号
            @SEND_LOGIN_NAME NVARCHAR(30) ,--签约方业务代表登录名
            @REG_NO VARCHAR(50) ,--社保登记证号
            @RECE_SUPPLIER_ID VARCHAR(50) ,--接单方供应商ID
            @CONT_NAME NVARCHAR(300) ,--商务合同名称
            @ACCE_NAME NVARCHAR(300) ,--合同附件名称
            @SUPP_NAME NVARCHAR(300) ,--签约方供应商名称
            @RECE_SUPPLIERR_NAME NVARCHAR(200) ,--接单方供应商名称
            @UNIT_NAME_PRINT NVARCHAR(200) ,--公积金单位名称
            @BUSI_CUST_NAME NVARCHAR(200) ,--业务客户名称
            @SEND_ORG_NAME NVARCHAR(200),--业务部门名称
            @SEND_LOGIN_EMAIL NVARCHAR(50),--签约方业务代表邮箱
            @SEND_SUPPLIER_ID NVARCHAR(50),--签约方供应商ID
            @TASK_UNIT_ID INT,
            @adminAccountId int;--业务员Id
   
   --------------------START----------------执行机密数据加密操作-------------------------

        BEGIN TRANSACTION   
        BEGIN TRY
            EXEC dbo.P_DataEncryption @taskid, @PASSWORD;            
            COMMIT TRANSACTION;
        END TRY
        BEGIN CATCH				
				
					   
            ROLLBACK TRANSACTION; -- 回滚
            INSERT  INTO [dbo].[T_JC_TaskInitLog]
                    ( [ErrorLine] ,
                      [ErrorMessage] ,
                      [ErrorNumber] ,
                      [ErrorProcedure] ,
                      [ErrorSeverity] ,
                      [ErrorState] ,
                      [IsDelete] ,
                      [CreateTime] ,
                      [UpdateTime]
                    )
            VALUES  ( ERROR_LINE() ,
                      ERROR_MESSAGE() +'EXEC dbo.P_DataEncryption @taskid, @PASSWORD',
                      ERROR_NUMBER() ,
                      ERROR_PROCEDURE() ,
                      ERROR_SEVERITY() ,
                      ERROR_STATE() ,
                      0 ,
                      GETDATE() ,
                      GETDATE()
                    )
            SET @ResultCode = 0;
            SET @ResultMessage = ERROR_MESSAGE();	
            
            PRINT ERROR_MESSAGE();
        END CATCH
    --------------------END-------------------执行机密数据加密操作------------------------- 

    --------------------START-----------------遍历游标指向的所有数据-----------------------

	--声明游标
        DECLARE T_JC_DataItem CURSOR FAST_FORWARD READ_ONLY
        FOR
            SELECT DISTINCT
                    CON_ACCE_ID ,
                    BUSI_CUST_NO ,
                    UNIT_NO ,
                    CONT_NO ,
                    ACCE_NO ,
                    SUPP_NO ,
                    SEND_USER_ID ,
                    REG_NO ,
                    RECE_SUPPLIER_ID ,
                    CONT_NAME ,
                    ACCE_NAME ,
                    SUPP_NAME ,
                    RECE_SUPPLIERR_NAME ,
                    UNIT_NAME_PRINT ,
                    SEND_LOGIN_NAME ,
                    SEND_ORG_ID ,
                    BUSI_CUST_NAME ,
                    SEND_ORG_NAME,
                    SEND_LOGIN_EMAIL,
                    SEND_SUPPLIER_ID,
                    SEND_USER,
                    UNIT_REG_NO
                    
            FROM    [dbo].[T_JC_DataItem]
            WHERE   JC_Task_ID = @taskid;
   
    
        OPEN T_JC_DataItem;
        
        PRINT  '-- 取第一条记录'
		 -- 取第一条记录
        FETCH NEXT FROM T_JC_DataItem INTO @CON_ACCE_ID, @BUSI_CUST_NO,
            @UNIT_NO, @CONT_NO, @ACCE_NO, @SUPP_NO, @SEND_USER_ID, @REG_NO,
            @RECE_SUPPLIER_ID, @CONT_NAME, @ACCE_NAME, @SUPP_NAME,
            @RECE_SUPPLIERR_NAME, @UNIT_NAME_PRINT, @SEND_LOGIN_NAME,
            @SEND_ORG_ID, @BUSI_CUST_NAME, @SEND_ORG_NAME,@SEND_LOGIN_EMAIL,
                    @SEND_SUPPLIER_ID,@SEND_USER,@UNIT_REG_NO;
            
        --BEGIN TRANSACTION
        --BEGIN TRY 
            WHILE @@FETCH_STATUS = 0 
            BEGIN 
        --------------------START-----------------遍历游标-----------------------
        PRINT ' --------------------START-----------------遍历游标-----------------------';
                 	  	
        --------------------START-----------------遍历游标指向的所有数据,生成任务子项-----------------
        PRINT '--------------------START-----------------遍历游标指向的所有数据,生成任务子项-----------------';
        
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
                              'yu.shuo@fesco.com.cn' ,--@SEND_LOGIN_EMAIL
                              @SEND_SUPPLIER_ID,
                              @BUSI_CUST_NAME,
                              @SEND_USER,
                              '12%'
                            );
                      
        SET @TASK_UNIT_ID = @@IDENTITY;
        
		PRINT '--------------------END-----------------遍历游标指向的所有数据,生成子项----------'            
        --------------------END-----------------遍历游标指向的所有数据,生成子项----------
        --------------------START-----------------生成hr帐号-----------------------------
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
       
    
        --------------------START-----------------生成业务员帐号-------------------------
        --IF(@CollectlType != 'B')
        --IF(1=1)
        --BEGIN
         
         IF NOT EXISTS ( SELECT  Id
                                    FROM    T_Admin_Account
                                    WHERE   SEND_LOGIN_NAME = @SEND_LOGIN_NAME ) 
                        BEGIN
                            INSERT  INTO [dbo].[T_Admin_Account]
                                    ( [DepartID] ,
                                      [UserName] ,
                                      [Password] ,
                                      [DepartName] ,
                                      [CreateTime] ,
                                      [UpdateTime] ,
                                      [IsDelete] ,
                                      [SEND_LOGIN_NAME] ,
                                      [SEND_USER_ID],
                                      [Email],
                                      [SEND_SUPPLIER_ID],
                                      [SUPP_NO]
                                    )
                            VALUES  ( CONVERT(INT, @SEND_ORG_ID) ,
                                      @SEND_LOGIN_NAME ,
                                      dbo.MD5('123456') ,
                                      @SEND_ORG_NAME ,
                                      GETDATE() ,
                                      GETDATE() ,
                                      0 ,
                                      @SEND_LOGIN_NAME ,
                                      @SEND_USER_ID,
                                      @SEND_LOGIN_EMAIL,
                                      @SEND_SUPPLIER_ID,
                                      @SUPP_NO
                                    );
                                    
                        SET @adminAccountId = @@identity;
                        INSERT INTO [dbo].[T_Admin_AcountRole]
							   ([RoleID]
							   ,[AccountID]
							   ,[IsDelete]
							   ,[CreateTime]
							   ,[CreateAdmin]
							   ,[SortValue]
							   ,[UpdateTime])
						 VALUES
							   (19
							   ,@adminAccountId
							   ,0
							   ,GETDATE()
							   ,''
							   ,''
							   ,GETDATE());



                        END
        --END
        
                   
  
    --------------------END-----------------生成业务员帐号---------------------------------
 
    
    
    --------------------START-----------------公积金单位名称处理-----------------------------

   
                    IF ( @UNIT_NO IS NOT NULL
                         AND @UNIT_NO != '252'
                       )
                       BEGIN
						   IF EXISTS ( SELECT UNIT_NO
                                         FROM   dbo.T_JC_FundBussinessName
                                         WHERE  UNIT_NO = @UNIT_NO ) 
                            BEGIN
                              UPDATE  [dbo].[T_JC_FundBussinessName]
                            SET     [UNIT_NAME_PRINT] = @UNIT_NAME_PRINT
                            WHERE   UNIT_NO = @UNIT_NO;
                            
                            END
                            ELSE
                            BEGIN
                            INSERT  INTO [dbo].[T_JC_FundBussinessName]
                                    ( [UNIT_NO] ,
                                      [UNIT_NAME_PRINT] ,
                                      [BUSI_CUST_NO] ,
                                      [BUSI_CUST_NAME] ,
                                      [IsDelete]
                                    )
                            VALUES  ( @UNIT_NO ,
                                      @UNIT_NAME_PRINT ,
                                      @BUSI_CUST_NO ,
                                      @BUSI_CUST_NAME ,
                                      0
                                    )
                            END
                         
                       END
                       
                       
                       
                       
		--------------------END-----------------公积金单位名称处理-----------------------------
		PRINT '--------------------END-----------------公积金单位名称处理-----------------------------'
					
				-- 取下一条记录
                    FETCH NEXT FROM T_JC_DataItem INTO @CON_ACCE_ID,
                        @BUSI_CUST_NO, @UNIT_NO, @CONT_NO, @ACCE_NO, @SUPP_NO,
                        @SEND_USER_ID, @REG_NO, @RECE_SUPPLIER_ID, @CONT_NAME,
                        @ACCE_NAME, @SUPP_NAME, @RECE_SUPPLIERR_NAME,
                        @UNIT_NAME_PRINT, @SEND_LOGIN_NAME, @SEND_ORG_ID,
                        @BUSI_CUST_NAME, @SEND_ORG_NAME,@SEND_LOGIN_EMAIL,
                              @SEND_SUPPLIER_ID,@SEND_USER,@UNIT_REG_NO;
                END
            
           -- COMMIT TRANSACTION;
       -- END TRY
        --BEGIN CATCH				
					   
            --ROLLBACK TRANSACTION; -- 回滚
           -- INSERT  INTO [dbo].[T_JC_TaskInitLog]
           --         ( [ErrorLine] ,
           --           [ErrorMessage] ,
           --           [ErrorNumber] ,
           --           [ErrorProcedure] ,
           --           [ErrorSeverity] ,
           --           [ErrorState] ,
           --           [IsDelete] ,
           --           [CreateTime] ,
           --           [UpdateTime]
           --         )
           -- VALUES  ( ERROR_LINE() ,
           --           ERROR_MESSAGE() ,
           --           ERROR_NUMBER() ,
           --           ERROR_PROCEDURE() ,
           --           ERROR_SEVERITY() ,
           --           ERROR_STATE() ,
           --           0 ,
           --           GETDATE() ,
           --           GETDATE()
           --         );
           -- SET @ResultCode = 0;
           -- SET @ResultMessage = ERROR_MESSAGE();		
           --PRINT '556-ERROR'   
           --PRINT   @ResultMessage
        --END CATCH
    --------------------END-----------------遍历游标-----------------------
  
		-- 关闭游标
        CLOSE T_JC_DataItem;

		-- 释放游标
        DEALLOCATE T_JC_DataItem;
 --------------------END-----------------遍历游标指向的所有数据-----------------------
        --SELECT  @Result = 1;--执行结果
    END

