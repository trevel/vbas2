USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_read_product]   */
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].sp_read_product(
	  @id int OUTPUT
	, @desc varchar(50) OUTPUT
	, @price numeric(9,2) OUTPUT
	, @inv int OUTPUT
	, @active bit OUTPUT)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
SELECT @id=id,@desc=description,@price=price,@inv=inventory,@active=active 
FROM dbo.Product
WHERE id=@id;
IF @@ROWCOUNT=0
	SET @id=-1
END

GO

