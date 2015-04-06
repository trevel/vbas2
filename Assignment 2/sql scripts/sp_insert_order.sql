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
CREATE PROCEDURE [dbo].[sp_insert_order](
	@date date
	, @disc numeric(3,0)
	, @custid int
	, @shipaddr int
	, @id int OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into dbo.Orders(order_date,discount,customer_id,shipping_address_id)
values(@date,@disc,@custid,@shipaddr);

SET @id = SCOPE_IDENTITY()
END

GO

