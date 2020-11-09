CREATE FUNCTION [dbo].[MD5]
(@patten NVARCHAR (4000))
RETURNS NVARCHAR (4000)
AS
 EXTERNAL NAME [Encryption].[UserDefinedFunctions].[MD5]

