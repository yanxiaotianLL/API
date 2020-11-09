-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  dbo.CreateAdminAccount
	-- Add the parameters for the stored procedure here
	@SEND_ORG_ID VARCHAR(100),
    @SEND_LOGIN_NAME NVARCHAR(30),   
    @SEND_ORG_NAME NVARCHAR(200),   
    @SEND_USER_ID VARCHAR(100),
    @SEND_LOGIN_EMAIL NVARCHAR(50),
    @SEND_SUPPLIER_ID NVARCHAR(50),
    @SUPP_NO NVARCHAR(30),
    @adminAccountId INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    --------------------START-----------------生成业务员帐号-------------------------       
         
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
       
    --------------------END-----------------生成业务员帐号---------------------------------
    
END
