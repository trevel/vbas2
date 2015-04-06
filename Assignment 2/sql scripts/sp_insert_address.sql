USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_insert_address]    Script Date: 05/04/2015 2:59:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insert_address](
	@street varchar(50)
	, @city varchar(50)
	, @province char(2)
	, @postcode char(6)
	, @type bit
	, @custid int
	, @id int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into dbo.Address(street,city,province,postal_code,type,customer_id)
values(@street,@city,@province,@postcode,@type,@custid);

SET @id = SCOPE_IDENTITY()
END


GO


