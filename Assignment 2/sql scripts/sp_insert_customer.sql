USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_insert_customer]    Script Date: 05/04/2015 2:59:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insert_customer](
	@name varchar(50)
	, @email varchar(50)
	, @phone varchar(50)
	, @credit numeric(9,2)
	, @id int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into dbo.Customer(name,email,phone,credit_limit)
values(@name,@email,@phone,@credit);

SET @id = SCOPE_IDENTITY()
END


GO


