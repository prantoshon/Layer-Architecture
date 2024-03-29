USE [MyDataBase]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 09/30/2019 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quanity] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderId], [ItemName], [Price], [Quanity]) VALUES (3, N'Expresso', 500, 5)
INSERT [dbo].[Orders] ([OrderId], [ItemName], [Price], [Quanity]) VALUES (4, N'cold', 8657, 857)
INSERT [dbo].[Orders] ([OrderId], [ItemName], [Price], [Quanity]) VALUES (5, N'Hot', 70, 7)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Table [dbo].[Items]    Script Date: 09/30/2019 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ItemPrice] [float] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[ItemName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON
INSERT [dbo].[Items] ([Id], [ItemName], [ItemPrice]) VALUES (10, N'Hot', 50)
INSERT [dbo].[Items] ([Id], [ItemName], [ItemPrice]) VALUES (3, N'Regular Coffee', 250)
INSERT [dbo].[Items] ([Id], [ItemName], [ItemPrice]) VALUES (7, N'Cold5', 77)
SET IDENTITY_INSERT [dbo].[Items] OFF
/****** Object:  Table [dbo].[Customers]    Script Date: 09/30/2019 19:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[CustomerAddress] [varchar](50) NOT NULL,
	[CustomerNumber] [varchar](11) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[CustomerName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (8, N'shuma', N'noukahli', N'026386938')
SET IDENTITY_INSERT [dbo].[Customers] OFF
