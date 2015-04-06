USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_read_address]    Script Date: 05/04/2015 3:18:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_read_address](
	@id int OUTPUT
	, @street varchar(50) OUTPUT
	, @city varchar(50) OUTPUT
	, @province char(2) OUTPUT
	, @postcode char(6) OUTPUT
	, @type bit OUTPUT
	, @custid int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
SELECT @id=id,@street=street,@city=city,@province=province,@postcode=postal_code,@type=type,@custid=customer_id 
FROM dbo.Address
WHERE id=@id;
IF @@ROWCOUNT=0
	SET @id=-1
END


GO


