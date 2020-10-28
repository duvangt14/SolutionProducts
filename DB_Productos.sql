IF NOT EXISTS(SELECT 1 FROM sys.databases WHERE name='Producto')
    CREATE DATABASE [Producto]
GO

USE [Producto]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 28/10/2020 09:27:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Product](
	[IdProducto] [int] NOT NULL,
	[CodProducto] [int] NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[PrecioUnitario] [numeric](18, 2) NULL,
	[PorcentajeDescuento] [numeric](18, 2) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
