USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_insert_product]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insert_product](
	@desc varchar(50)
	, @price numeric(9,2)
	, @inv int
	, @active bit
	, @id int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into dbo.Product(description, price, inventory, active)
values(@desc,@price,@inv,@active);

SET @id = SCOPE_IDENTITY()
END

GO

