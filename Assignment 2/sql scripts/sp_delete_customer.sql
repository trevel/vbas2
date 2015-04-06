USE [cvb815a_assign2]
GO

/****** Object:  StoredProcedure [dbo].[sp_delete_customer]    Script Date: 05/04/2015 3:10:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_delete_customer](
	@id int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

delete from dbo.Customer
where id=@id;
END


GO

