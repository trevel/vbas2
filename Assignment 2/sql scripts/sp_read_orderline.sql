USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_read_orderline]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].sp_read_orderline(
	  @id int OUTPUT
	, @orderid int OUTPUT
	, @prodid int OUTPUT
	, @quantity int OUTPUT
	, @shipdate date OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
SELECT @id=id,@orderid=order_id,@prodid=product_id,@shipdate=ship_date 
FROM dbo.Order_Line
IF @@ROWCOUNT=0
	SET @id=-1
END

GO

