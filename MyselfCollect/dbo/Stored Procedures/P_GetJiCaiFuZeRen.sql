-- =============================================
-- Author:		刘勇
-- Create date: 2018年4月3日 14:51:28
-- Description:	任务初始化完成，发送邮件给对应的业务员以及集采负责人
-- =============================================
CREATE PROCEDURE [dbo].[P_GetJiCaiFuZeRen] @taskId INT --任务ID
AS 
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON;
 --变量定义
        DECLARE @CollectlType NVARCHAR(20); -- 采集类型  A或者B
        SELECT  @CollectlType = CollectlType
        FROM    dbo.T_JC_Task
        WHERE   Id = @taskId;
  
        IF @CollectlType = 'A' 
            BEGIN
 --获取到所有集采负责人信息,注意区分 采集类型为 A和B的区别： A类按部门查找  B：按供应商查找（两个：一个总的，一个按供应商的）
                SELECT  UserName ,
                        Email
                FROM    [FesSysBak1].[dbo].T_Admin_Account a
                WHERE   a.DepartID IN (
                        SELECT  DISTINCT
                                SEND_ORG_ID
                        FROM    [FesSysBak1].[dbo].T_JC_TaskUnit
                        WHERE   TaskId = @taskId
                                AND a.Id IN (
                                SELECT  [AccountID]
                                FROM    [FesSysBak1].[dbo].[T_Admin_AcountRole]
                                WHERE   RoleID = ( SELECT   r.Id
                                                   FROM     FesSysBak1.dbo.T_Admin_Role r
                                                   WHERE    r.RoleCode = 'JC_Admin_ Official'
                                                 ) ) ) 
                UNION ALL  
                SELECT  UserName ,
                        Email
                FROM    [FesSysBak1].[dbo].T_Admin_Account
                WHERE   SEND_LOGIN_NAME IN (
                        SELECT  DISTINCT
                                SEND_LOGIN_NAME
                        FROM    [FesSysBak1].[dbo].T_JC_TaskUnit
                        WHERE   TaskId = @taskId );
            END
        ELSE 
            BEGIN
 --获取到所有集采负责人信息,注意区分 采集类型为 A和B的区别： A类按部门查找  B：按供应商查找（两个：一个总的，一个按供应商的）
 --北京B类集采负责人
                SELECT  UserName ,
                        Email
                FROM    [FesSysBak1].[dbo].T_Admin_Account a
                WHERE   a.SEND_SUPPLIER_ID IN (
                        SELECT  DISTINCT
                                SEND_SUPPLIER_ID
                        FROM    [FesSysBak1].[dbo].T_JC_TaskUnit
                        WHERE   TaskId = @taskId
                                AND a.Id IN (
                                SELECT  [AccountID]
                                FROM    [FesSysBak1].[dbo].[T_Admin_AcountRole]
                                WHERE   RoleID = ( SELECT   r.Id
                                                   FROM     FesSysBak1.dbo.T_Admin_Role r
                                                   WHERE    r.RoleCode = 'JC_Admin_ Official_B'
                                                 ) ) ) 
                UNION ALL
  --北京B类总集采负责人
  SELECT       UserName ,
               Email
               FROM    [FesSysBak1].[dbo].T_Admin_Account a 
               WHERE Id = (SELECT TOP 1 [AccountID]
                                FROM    [FesSysBak1].[dbo].[T_Admin_AcountRole]
                                WHERE   RoleID = ( SELECT   r.Id
                                                   FROM     FesSysBak1.dbo.T_Admin_Role r
                                                   WHERE    r.RoleCode = 'JC_Admin_ Official_A'
                                                 ) )
                
  --获取到所有业务员信息
                UNION ALL
                SELECT  UserName ,
                        Email
                FROM    [FesSysBak1].[dbo].T_Admin_Account
                WHERE   SEND_LOGIN_NAME IN (
                        SELECT  DISTINCT
                                SEND_LOGIN_NAME
                        FROM    [FesSysBak1].[dbo].T_JC_TaskUnit
                        WHERE   TaskId = @taskId )
            END
  
    END
