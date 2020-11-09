-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.P_DataListEncryption
	@taskid INT ,
    @PASSWORD NVARCHAR(30)
AS
BEGIN
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
           
        END CATCH
    --------------------END-------------------执行机密数据加密操作------------------------- 
END
