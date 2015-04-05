USE [cvb815a_assign2]
GO

/****** Object:  Table [dbo].[Order_Line]    Script Date: 04/04/2015 9:54:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order_Line](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[ship_date] [date] NULL,
 CONSTRAINT [PK_Order_Line] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Order_Line]  WITH CHECK ADD  CONSTRAINT [FK_Order_Line_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([id])
GO

ALTER TABLE [dbo].[Order_Line] CHECK CONSTRAINT [FK_Order_Line_Order]
GO

ALTER TABLE [dbo].[Order_Line]  WITH CHECK ADD  CONSTRAINT [FK_Order_Line_Product] FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([id])
GO

ALTER TABLE [dbo].[Order_Line] CHECK CONSTRAINT [FK_Order_Line_Product]
GO

