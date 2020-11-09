CREATE FUNCTION [dbo].[Decrypt]
(@patten NVARCHAR (4000), @password NVARCHAR (100))
RETURNS NVARCHAR (4000)
AS
 EXTERNAL NAME [Encryption].[UserDefinedFunctions].[Decrypt]

