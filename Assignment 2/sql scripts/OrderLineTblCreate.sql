USE [cvb815a_assign2]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 04/04/2015 9:54:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [date] NOT NULL,
	[discount] [numeric](3, 0) NOT NULL,
	[customer_id] [int] NOT NULL,
	[shipping_address_id] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Address] FOREIGN KEY([shipping_address_id])
REFERENCES [dbo].[Address] ([id])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_Address]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Order_Customer]
GO

