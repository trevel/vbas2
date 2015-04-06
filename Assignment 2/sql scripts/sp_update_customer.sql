USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_update_customer]    Script Date: 05/04/2015 3:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_update_customer](
	@id int
	, @name varchar(50)
	, @email varchar(50)
	, @phone varchar(50)
	, @credit numeric(9,2))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE dbo.Customer
SET name=@name,email=@email,phone=@phone,credit_limit=@credit
WHERE id=@id;
END


GO


