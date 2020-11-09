-- =============================================
-- Author:		<Author,,刘勇>
-- Create date: <Create Date,,17:16:45>
-- Description:	<Description,,拆分任务单元并初始化用户>
-- =============================================
CREATE PROCEDURE  [dbo].[P_SplitTask]
@taskid int,
@Address_ID NVARCHAR(30),
@Address NVARCHAR(20),
@StartTime date,
@EndTime date,
@CollectlType NVARCHAR(20),
@CollectlProduct int
AS
BEGIN
	--声明变量 BUSI_CUST_ID,CON_ACCE_ID,CONT_NO,BUSI_CUST_NO,UNIT_NO
	DECLARE 
	@BUSI_CUST_ID NVARCHAR(50),
	@CON_ACCE_ID NVARCHAR(20),
	@CONT_NO NVARCHAR(30),
	@BUSI_CUST_NO NVARCHAR(30),
	@UNIT_NO NVARCHAR(30);
	
	--声明游标
	DECLARE T_JC_DataItemTemp CURSOR FAST_FORWARD FOR
    SELECT DISTINCT BUSI_CUST_ID,CON_ACCE_ID,CONT_NO,BUSI_CUST_NO,UNIT_NO
    FROM [FesSys].[dbo].[T_JC_DataItemTemp]
    WHERE JC_Task_ID = @taskid
    ORDER BY BUSI_CUST_ID;
    
OPEN T_JC_DataItemTemp;

-- 取第一条记录
FETCH NEXT FROM T_JC_DataItemTemp INTO @BUSI_CUST_ID,@CON_ACCE_ID,@CONT_NO,@BUSI_CUST_NO,@UNIT_NO;

WHILE @@FETCH_STATUS=0
BEGIN
    -- 操作
    --UPDATE HR.Employees SET fullname= @firstname+' '+@lastname WHERE empid=@empid;
    --创建用户帐号
    --检查是否存在可用帐号
    --定义用户临时变量
	DECLARE 
	@ACCOUNTID int,
	@State int
    --用户变量赋值
    --select @ACCOUNTID =  t.Id from [FesSys].[dbo].[T_JC_Account] t inner join [FesSys].[dbo].[T_JC_Account_CON_ACCE] s on t.Id = s.AccountId where t.BUSI_CUST_NO = @BUSI_CUST_NO and t.UNIT_NO = @UNIT_NO and t.CONT_NO = @CONT_NO and t.CON_ACCE_ID = @CON_ACCE_ID and s.CON_ACCE_ID;
	--检测是否取道帐号
	
	--生成任务子项
	INSERT INTO [FesSys].[dbo].[T_JC_TaskUnit]([CON_ACCE_ID],
	[BUSI_CUST_NO],
	[UNIT_NO],
	[Address_ID],
	[Address],
	[TaskId],
	[StartTime],
	[EndTime],
	[State],
	[CONT_NO],
	[CollectlType],
	[CollectlProduct]) VALUES(@CON_ACCE_ID,
	@BUSI_CUST_NO,
	@UNIT_NO,
	@Address_ID,
	@Address,
	@taskid,
	@StartTime,
	@EndTime,
	0,
	@CONT_NO,
	@CollectlType,
	@CollectlProduct);
    --print @BUSI_CUST_ID;
    -- 取下一条记录
    FETCH NEXT FROM T_JC_DataItemTemp INTO  @BUSI_CUST_ID,@CON_ACCE_ID,@CONT_NO,@BUSI_CUST_NO,@UNIT_NO;
END

-- 关闭游标
CLOSE T_JC_DataItemTemp;

-- 释放游标
DEALLOCATE T_JC_DataItemTemp;

--将临时表数据导入T_JC_DataItem
set IDENTITY_INSERT dbo.T_JC_DataItem ON;
INSERT INTO dbo.T_JC_DataItem
        (Id,
         order_id ,
          UNIQ_NO ,
          EMP_NAME ,
          CER_TYPE ,
          EMP_ID_CARD ,
          EMP_IN_CODE ,
          COST_CENT_NO ,
          PER_PKG_NAME ,
          REG_NO ,
          UNIT_REG_NO ,
          UNIT_NO ,
          UNIT_NAME_PRINT ,
          INS_DECL_WAGE ,
          INS_BASE_WAGE ,
          ACCU_DECL_WAGE ,
          ACCU_BASE_WAGE ,
          BUSI_CUST_NO ,
          BUSI_CUST_NAME ,
          CONT_NO ,
          CONT_NAME ,
          ACCE_NO ,
          ACCE_NAME ,
          RECE_ORG_NAME ,
          RECE_USER ,
          RECE_LOGIN_NAME ,
          SEND_ORG_NAME ,
          SEND_USER ,
          SEND_LOGIN_NAME ,
          SEND_LOGIN_EMAIL ,
          SUPP_NAME ,
          SUPP_NO ,
          AREA_ID ,
          COLLT_TYPE ,
          PER_PKG_ID ,
          BUSI_CUST_ID ,
          CUST_CON_ID ,
          CON_ACCE_ID ,
          RECE_ORG_ID ,
          RECE_USER_ID ,
          SEND_ORG_ID ,
          SEND_USER_ID ,
          JC_Task_ID ,
          CreateTime ,
          IsDelete ,
          RECE_SUPPLIERR_NAME ,
          APEA ,
          PRODUCTTYPE ,
          PRODUCTID ,
          RECE_SUPPLIER_ID ,
          SEND_SUPPLIER_ID
        ) SELECT  Id,
         order_id ,
          UNIQ_NO ,
          EMP_NAME ,
          CER_TYPE ,
          EMP_ID_CARD ,
          EMP_IN_CODE ,
          COST_CENT_NO ,
          PER_PKG_NAME ,
          REG_NO ,
          UNIT_REG_NO ,
          UNIT_NO ,
          UNIT_NAME_PRINT ,
          INS_DECL_WAGE ,
          INS_BASE_WAGE ,
          ACCU_DECL_WAGE ,
          ACCU_BASE_WAGE ,
          BUSI_CUST_NO ,
          BUSI_CUST_NAME ,
          CONT_NO ,
          CONT_NAME ,
          ACCE_NO ,
          ACCE_NAME ,
          RECE_ORG_NAME ,
          RECE_USER ,
          RECE_LOGIN_NAME ,
          SEND_ORG_NAME ,
          SEND_USER ,
          SEND_LOGIN_NAME ,
          SEND_LOGIN_EMAIL ,
          SUPP_NAME ,
          SUPP_NO ,
          AREA_ID ,
          COLLT_TYPE ,
          PER_PKG_ID ,
          BUSI_CUST_ID ,
          CUST_CON_ID ,
          CON_ACCE_ID ,
          RECE_ORG_ID ,
          RECE_USER_ID ,
          SEND_ORG_ID ,
          SEND_USER_ID ,
          JC_Task_ID ,
          CreateTime ,
          IsDelete ,
          RECE_SUPPLIERR_NAME ,
          APEA ,
          PRODUCTTYPE ,
          PRODUCTID ,
          RECE_SUPPLIER_ID ,
          SEND_SUPPLIER_ID
         FROM T_JC_DataItemTemp WHERE JC_Task_ID = 39; 
         set IDENTITY_INSERT dbo.T_JC_DataItem OFF

END
