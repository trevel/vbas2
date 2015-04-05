USE [cvb815a_assign2]
GO

/****** Object:  Table [dbo].[Address]    Script Date: 04/04/2015 9:52:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[street] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[province] [char](2) NOT NULL,
	[postal_code] [char](6) NOT NULL,
	[type] [bit] NOT NULL,
	[customer_id] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO

ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Customer]
GO


