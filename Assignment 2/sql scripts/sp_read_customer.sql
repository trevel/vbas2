USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_read_customer]    Script Date: 05/04/2015 3:18:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_read_customer](
	@id int OUTPUT
	, @name varchar(50) OUTPUT
	, @email varchar(50) OUTPUT
	, @phone varchar(50) OUTPUT
	, @credit numeric(9,2) OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
SELECT @id=id,@name=name,@email=email,@phone=phone,@credit=credit_limit 
FROM dbo.Customer
WHERE id=@id;
IF @@ROWCOUNT=0
	SET @id=-1
END


GO


