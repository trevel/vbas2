USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_read_order]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].sp_read_order(
	  @id int OUTPUT
	, @date date OUTPUT
	, @disc numeric(3,0) OUTPUT
	, @custid int OUTPUT
	, @shipaddr int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
SELECT @id=id,@date=order_date,@disc=discount,@custid=customer_id,@shipaddr=shipping_address_id 
FROM dbo.Orders
WHERE id=@id;
IF @@ROWCOUNT=0
	SET @id=-1
END

GO

