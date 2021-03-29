/****** Object:  Table [dbo].[Sectors]    Script Date: 28/03/2021 20:48:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sectors]') AND type in (N'U'))
DROP TABLE [dbo].[Sectors]
GO

/****** Object:  Table [dbo].[Sectors]    Script Date: 28/03/2021 20:48:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sectors](
	[Id] [tinyint] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type in (N'U'))
DROP TABLE [dbo].[Categories]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 28/03/2021 20:48:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories](
	[Id] [tinyint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Trades]    Script Date: 28/03/2021 20:49:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trades]') AND type in (N'U'))
DROP TABLE [dbo].[Trades]
GO

/****** Object:  Table [dbo].[Trades]    Script Date: 28/03/2021 20:49:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trades]') AND type in (N'U'))
DROP TABLE [dbo].[Trades]
GO

/****** Object:  Table [dbo].[Trades]    Script Date: 28/03/2021 20:55:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Trades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [money] NOT NULL,
	[IdSector] [tinyint] NOT NULL,
	[IdCategory] [tinyint] NULL,
 CONSTRAINT [PK_Trades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Trades]  WITH CHECK ADD  CONSTRAINT [FK_Trades_Categories] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Categories] ([Id])
GO

ALTER TABLE [dbo].[Trades] CHECK CONSTRAINT [FK_Trades_Categories]
GO

ALTER TABLE [dbo].[Trades]  WITH CHECK ADD  CONSTRAINT [FK_Trades_Sectors] FOREIGN KEY([IdSector])
REFERENCES [dbo].[Sectors] ([Id])
GO

ALTER TABLE [dbo].[Trades] CHECK CONSTRAINT [FK_Trades_Sectors]
GO