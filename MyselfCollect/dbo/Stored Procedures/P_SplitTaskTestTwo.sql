-- =============================================
-- Author:		<Author,,刘勇>
-- Create date: <Create Date,,17:16:45>
-- Description:	<Description,,拆分任务单元并初始化用户>
-- =============================================
CREATE PROCEDURE [dbo].[P_SplitTaskTestTwo]
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
   
  

    --------------------START-----------------遍历游标指向的所有数据-----------------------
     --------------------START----------------执行机密数据加密操作-------------------------
    
     EXEC dbo.P_DataListEncryption @taskid, @PASSWORD;       
    
     --------------------END-------------------执行机密数据加密操作------------------------- 
     
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
       
		 -- 取第一条记录
        FETCH NEXT FROM T_JC_DataItem INTO @CON_ACCE_ID, @BUSI_CUST_NO,
            @UNIT_NO, @CONT_NO, @ACCE_NO, @SUPP_NO, @SEND_USER_ID, @REG_NO,
            @RECE_SUPPLIER_ID, @CONT_NAME, @ACCE_NAME, @SUPP_NAME,
            @RECE_SUPPLIERR_NAME, @UNIT_NAME_PRINT, @SEND_LOGIN_NAME,
            @SEND_ORG_ID, @BUSI_CUST_NAME, @SEND_ORG_NAME,@SEND_LOGIN_EMAIL,
                    @SEND_SUPPLIER_ID,@SEND_USER,@UNIT_REG_NO;            
      
       WHILE @@FETCH_STATUS = 0 
       BEGIN 
        --------------------START-----------------遍历游标-----------------------
        BEGIN TRANSACTION   
        BEGIN TRY
             --------------------START-----------------遍历游标指向的所有数据,生成任务子项-----------------       
       
        EXEC [dbo].[P_CreateUnit]
		@CON_ACCE_ID ,
		@BUSI_CUST_NO,
		@UNIT_NO ,
		@Address_ID,
		@Address,
		@taskid,
		@StartTime,
		@EndTime,    
		@CONT_NO,
		@ACCE_NO,
		@SUPP_NO ,
		@IsNeedCollectTable,
		@CollectlType,
		@CollectlProduct,
		@SEND_USER_ID,
		@SEND_ORG_ID,
		@UNIT_REG_NO,
		@SEND_LOGIN_NAME, 
		@REG_NO,
		@RECE_SUPPLIER_ID,
		@CONT_NAME,
		@ACCE_NAME,
		@SUPP_NAME,
		@RECE_SUPPLIERR_NAME,
		@UNIT_NAME_PRINT,
		@SEND_ORG_NAME,
		@SEND_LOGIN_EMAIL,--@SEND_LOGIN_EMAIL
		@SEND_SUPPLIER_ID,
		@BUSI_CUST_NAME,
		@SEND_USER ,		
		@TASK_UNIT_ID = @TASK_UNIT_ID OUTPUT;
	      
        --------------------END-----------------遍历游标指向的所有数据,生成子项----------
        --------------------START-----------------生成hr帐号-----------------------------
        
        EXEC [dbo].[P_CreateHrAccount]
		@TaskType,
		@ACCE_NO,
		@TASK_UNIT_ID,
		@BUSI_CUST_NO,
		@Address_ID,	
		@CON_ACCE_ID,
		@Address,
		@UNIT_NO,
		@CONT_NO,
		@SEND_USER_ID,
		@SEND_ORG_ID,
		@BUSI_CUST_NAME,
		@CONT_NAME,    
		@ACCE_NAME,
		@SUPP_NO,
		@SUPP_NAME,
		@RECE_SUPPLIERR_NAME,
		@RECE_SUPPLIER_ID,
		@REG_NO,
		@SEND_LOGIN_NAME,
		@SEND_ORG_NAME,
		@UNIT_NAME_PRINT,
		@SEND_SUPPLIER_ID,
		@SEND_USER, 
		@UNIT_REG_NO;                   

        --------------------END-----------------生成hr帐号-------------------------------
       
    
        --------------------START-----------------生成业务员帐号-------------------------       
         
        EXEC	[dbo].[CreateAdminAccount]
		@SEND_ORG_ID,
		@SEND_LOGIN_NAME,   
		@SEND_ORG_NAME,   
		@SEND_USER_ID,
		@SEND_LOGIN_EMAIL,
		@SEND_SUPPLIER_ID,
		@SUPP_NO,
		@adminAccountId = @adminAccountId OUTPUT;
       
        --------------------END-----------------生成业务员帐号---------------------------------
 
    
    
        --------------------START-----------------公积金单位名称处理-----------------------------

        EXEC	[dbo].[FundBussinessName]
		@CON_ACCE_ID,
		@BUSI_CUST_NO, 
		@UNIT_NO,
		@CONT_NO, 
		@ACCE_NO, 
		@SUPP_NO,
		@SEND_USER_ID, 
		@REG_NO, 
		@RECE_SUPPLIER_ID, 
		@CONT_NAME,
		@ACCE_NAME, 
		@SUPP_NAME, 
		@RECE_SUPPLIERR_NAME,
		@UNIT_NAME_PRINT, 
		@SEND_LOGIN_NAME, 
		@SEND_ORG_ID,
		@BUSI_CUST_NAME, 
		@SEND_ORG_NAME,
		@SEND_LOGIN_EMAIL,
		@SEND_SUPPLIER_ID,
		@SEND_USER,
		@UNIT_REG_NO;                 
            
		--------------------END-----------------公积金单位名称处理-----------------------------
                    
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
                      ERROR_MESSAGE() +'EXEC [dbo].[P_SplitTaskTestTwo] @taskid:'+@taskid+'@CON_ACCE_ID:'+@CON_ACCE_ID+'@UNIT_NO:'+@UNIT_NO,
                      ERROR_NUMBER() ,
                      ERROR_PROCEDURE() ,
                      ERROR_SEVERITY() ,
                      ERROR_STATE() ,
                      0 ,
                      GETDATE() ,
                      GETDATE()
                    )
           
        END CATCH     
                --数据初始化
               set @CON_ACCE_ID = '';
               set @BUSI_CUST_NO = '';
               set @UNIT_NO = '';
               set @CONT_NO = '';
               set @ACCE_NO = '';
               set @SUPP_NO = '';
               set @SEND_USER_ID = '';
               set @REG_NO = '';
               set @RECE_SUPPLIER_ID = '';
               set @CONT_NAME = '';
               set @ACCE_NAME = '';
               set @SUPP_NAME = '';
               set @RECE_SUPPLIERR_NAME='';
               set @UNIT_NAME_PRINT='';
               set @SEND_LOGIN_NAME='';
               set @SEND_ORG_ID='';
               set @BUSI_CUST_NAME='';
               set @SEND_ORG_NAME='';
               set @SEND_LOGIN_EMAIL='';
               set @SEND_SUPPLIER_ID='';
               set @SEND_USER='';
               set @UNIT_REG_NO='';




				-- 取下一条记录
                    FETCH NEXT FROM T_JC_DataItem INTO @CON_ACCE_ID,
                        @BUSI_CUST_NO, @UNIT_NO, @CONT_NO, @ACCE_NO, @SUPP_NO,
                        @SEND_USER_ID, @REG_NO, @RECE_SUPPLIER_ID, @CONT_NAME,
                        @ACCE_NAME, @SUPP_NAME, @RECE_SUPPLIERR_NAME,
                        @UNIT_NAME_PRINT, @SEND_LOGIN_NAME, @SEND_ORG_ID,
                        @BUSI_CUST_NAME, @SEND_ORG_NAME,@SEND_LOGIN_EMAIL,
                              @SEND_SUPPLIER_ID,@SEND_USER,@UNIT_REG_NO;
                END
            
          
    --------------------END-----------------遍历游标-----------------------
  
		-- 关闭游标
        CLOSE T_JC_DataItem;

		-- 释放游标
        DEALLOCATE T_JC_DataItem;
 --------------------END-----------------遍历游标指向的所有数据-----------------------
     
    END

