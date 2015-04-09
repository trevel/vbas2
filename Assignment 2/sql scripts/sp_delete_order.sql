USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_delete_order]    Script Date: 08/04/2015 7:42:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_delete_order](
	@id int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

delete from dbo.Order_Line
where order_id=@id AND ship_date IS null;

delete from dbo.Orders
where id=@id;
END

GO


