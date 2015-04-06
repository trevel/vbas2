USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_insert_order]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insert_orderline](
	@orderid int
	, @prodid int
	, @quantity int
	, @shipdate date
	, @id int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into dbo.Order_Line(order_id,product_id,quantity,ship_date)
values(@orderid,@prodid,@quantity,@shipdate);

SET @id = SCOPE_IDENTITY()
END

GO

