USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_ship_order_item]    Script Date: 09/04/2015 9:20:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ship_order_item](
	@id int,
	@prodid int OUTPUT,
	@qty int OUTPUT)
AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE dbo.Order_Line
SET ship_date=DATEADD(dd, DATEDIFF(dd, 0, getdate()), 0)
WHERE id=@id;

SELECT @prodid=product_id,@qty=quantity
FROM dbo.Order_line
WHERE id=@id;

END


GO


