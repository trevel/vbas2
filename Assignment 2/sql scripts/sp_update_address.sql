USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_update_address]    Script Date: 05/04/2015 3:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_update_address](
	@id int
	, @street varchar(50)
	, @city varchar(50)
	, @province char(2)
	, @postcode char(6)
	, @type bit
	, @custid int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE dbo.Address
SET street=@street,city=@city,province=@province,postal_code=@postcode,type=@type,customer_id=@custid
WHERE id=@id;
END


GO


