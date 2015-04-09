USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_product_removeinv]    Script Date: 08/04/2015 9:51:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_product_removeinv](
	@id int
	,@amt int)
AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE dbo.Product
SET inventory=inventory-@amt
WHERE id=@id;

END


GO


