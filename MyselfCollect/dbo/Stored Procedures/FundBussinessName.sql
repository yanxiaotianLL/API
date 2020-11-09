-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.FundBussinessName
	-- Add the parameters for the stored procedure here
	@CON_ACCE_ID NVARCHAR(20),
    @BUSI_CUST_NO NVARCHAR(30), 
    @UNIT_NO NVARCHAR(30),
    @CONT_NO NVARCHAR(30), 
    @ACCE_NO NVARCHAR(30), 
    @SUPP_NO NVARCHAR(30),
    @SEND_USER_ID  VARCHAR(100), 
    @REG_NO VARCHAR(50), 
    @RECE_SUPPLIER_ID VARCHAR(50), 
    @CONT_NAME NVARCHAR(300),
    @ACCE_NAME NVARCHAR(300), 
    @SUPP_NAME NVARCHAR(300), 
    @RECE_SUPPLIERR_NAME NVARCHAR(200),
    @UNIT_NAME_PRINT NVARCHAR(200), 
    @SEND_LOGIN_NAME NVARCHAR(30), 
    @SEND_ORG_ID VARCHAR(100),
    @BUSI_CUST_NAME NVARCHAR(200), 
    @SEND_ORG_NAME NVARCHAR(200),
    @SEND_LOGIN_EMAIL NVARCHAR(50),
    @SEND_SUPPLIER_ID NVARCHAR(50),
    @SEND_USER NVARCHAR(100),
    @UNIT_REG_NO NVARCHAR(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

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
END
