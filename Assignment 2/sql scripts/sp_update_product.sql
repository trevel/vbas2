USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_update_product]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].sp_update_product(
	@id int
	, @desc varchar(50)
	, @price numeric(9,2)
	, @inv int
	, @active bit)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE dbo.Product
SET description=@desc,price=@price,inventory=@inv,active=@active
WHERE id=@id;
END

GO

