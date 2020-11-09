-- =============================================
-- Author:		刘勇
-- Create date: 2018年3月22日 10:50:30
-- Description:	创建8位的临时账号
-- =============================================
CREATE PROCEDURE [dbo].[P_CreateTempAccount]
@PASS NVARCHAR(8) OUTPUT
AS

BEGIN
	 --生成帐号临时秘密 --start
    DECLARE @HRPassword NVARCHAR(8) = '';   
    DECLARE @PassLength INT = 0;
    
    WHILE @PassLength <8
    BEGIN
       
    IF @PassLength <=3
	    BEGIN    
	    
	    SET @HRPassword = @HRPassword +  char(65+ceiling(rand()*25));
	    END       
    ELSE
	BEGIN
	      SET @HRPassword = @HRPassword +  CONVERT(NVARCHAR(8),ceiling(rand()*10));
	END	
	
	SET @PassLength = @PassLength +1;
    SET @PASS=@HRPassword;
    END
END
