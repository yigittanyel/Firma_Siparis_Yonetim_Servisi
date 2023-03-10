USE [master]
GO
/****** Object:  Database [fw_firmasiparis]    Script Date: 13.01.2023 14:53:53 ******/
CREATE DATABASE [fw_firmasiparis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'fw_firmasiparis', FILENAME = N'D:\programlar\MSSQL15.MSSQLSERVER\MSSQL\DATA\fw_firmasiparis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'fw_firmasiparis_log', FILENAME = N'D:\programlar\MSSQL15.MSSQLSERVER\MSSQL\DATA\fw_firmasiparis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [fw_firmasiparis] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [fw_firmasiparis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [fw_firmasiparis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET ARITHABORT OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [fw_firmasiparis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [fw_firmasiparis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [fw_firmasiparis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET  ENABLE_BROKER 
GO
ALTER DATABASE [fw_firmasiparis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [fw_firmasiparis] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [fw_firmasiparis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [fw_firmasiparis] SET  MULTI_USER 
GO
ALTER DATABASE [fw_firmasiparis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [fw_firmasiparis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [fw_firmasiparis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [fw_firmasiparis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [fw_firmasiparis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [fw_firmasiparis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [fw_firmasiparis] SET QUERY_STORE = OFF
GO
USE [fw_firmasiparis]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13.01.2023 14:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firmalar]    Script Date: 13.01.2023 14:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [nvarchar](max) NULL,
	[OnayDurumu] [bit] NOT NULL,
	[SiparisIzinBaslangicSaati] [datetime2](7) NOT NULL,
	[SiparisIzinBitisSaati] [datetime2](7) NULL,
 CONSTRAINT [PK_Firmalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 13.01.2023 14:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirmaId] [int] NULL,
	[UrunId] [int] NULL,
	[SiparisiVerenMusteriAdi] [nvarchar](max) NOT NULL,
	[SiparisTarihi] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 13.01.2023 14:53:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](max) NULL,
	[Stok] [int] NOT NULL,
	[Fiyat] [decimal](18, 2) NOT NULL,
	[FirmaId] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230112104121_initial-create', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230112160511_bazikisimlarnullableyapildi', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230112162800_urunlerdefirmaidnullablekaldirildi', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230112164320_urunfirmaidnullableyapildi', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230112164617_urunadinullableyapildi', N'6.0.12')
GO
SET IDENTITY_INSERT [dbo].[Firmalar] ON 

INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (1, N'deneme', 1, CAST(N'2022-01-12T16:05:31.8820000' AS DateTime2), CAST(N'2023-02-14T16:05:31.8820000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (5, N'deneme2', 0, CAST(N'2022-01-10T13:46:06.4400000' AS DateTime2), CAST(N'2023-01-11T18:46:06.4400000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (6, N'deneme8', 1, CAST(N'2023-01-12T15:39:57.5060000' AS DateTime2), CAST(N'2023-01-12T15:39:57.5060000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (7, N'string', 1, CAST(N'2023-01-12T15:57:15.5100000' AS DateTime2), CAST(N'2023-01-12T15:57:15.5100000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (8, N'deneme firması', 0, CAST(N'2023-01-11T19:11:35.6820000' AS DateTime2), CAST(N'2023-01-14T19:11:35.6820000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (10, N'mediatr', 1, CAST(N'2023-01-13T09:09:01.7350000' AS DateTime2), CAST(N'2023-01-13T09:09:01.7350000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (11, N'firma deneme', 1, CAST(N'2023-01-13T09:12:29.4300000' AS DateTime2), CAST(N'2023-01-13T09:12:29.4300000' AS DateTime2))
INSERT [dbo].[Firmalar] ([Id], [FirmaAdi], [OnayDurumu], [SiparisIzinBaslangicSaati], [SiparisIzinBitisSaati]) VALUES (12, N'deneme89', 1, CAST(N'2023-01-13T10:16:04.1410000' AS DateTime2), CAST(N'2023-01-13T10:16:04.1410000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Firmalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([Id], [FirmaId], [UrunId], [SiparisiVerenMusteriAdi], [SiparisTarihi]) VALUES (1, 1, 1, N'yigit', CAST(N'2022-01-12T16:05:31.8820000' AS DateTime2))
INSERT [dbo].[Siparisler] ([Id], [FirmaId], [UrunId], [SiparisiVerenMusteriAdi], [SiparisTarihi]) VALUES (2, 1, 1, N'yigit', CAST(N'2023-01-12T18:32:37.5650000' AS DateTime2))
INSERT [dbo].[Siparisler] ([Id], [FirmaId], [UrunId], [SiparisiVerenMusteriAdi], [SiparisTarihi]) VALUES (3, 5, 2, N'yigit', CAST(N'2023-01-12T18:32:37.5650000' AS DateTime2))
INSERT [dbo].[Siparisler] ([Id], [FirmaId], [UrunId], [SiparisiVerenMusteriAdi], [SiparisTarihi]) VALUES (4, 1, 1, N'string', CAST(N'2023-01-12T19:07:46.2370000' AS DateTime2))
INSERT [dbo].[Siparisler] ([Id], [FirmaId], [UrunId], [SiparisiVerenMusteriAdi], [SiparisTarihi]) VALUES (5, 1, 1, N'string', CAST(N'2023-01-12T19:07:46.2370000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [UrunAdi], [Stok], [Fiyat], [FirmaId]) VALUES (1, N'DENEME', 10, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Urunler] ([Id], [UrunAdi], [Stok], [Fiyat], [FirmaId]) VALUES (2, N'abc', 10, CAST(24.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[Urunler] ([Id], [UrunAdi], [Stok], [Fiyat], [FirmaId]) VALUES (3, N'string', 10, CAST(50.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Urunler] ([Id], [UrunAdi], [Stok], [Fiyat], [FirmaId]) VALUES (4, N'yeni ürün', 40, CAST(100.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Urunler] ([Id], [UrunAdi], [Stok], [Fiyat], [FirmaId]) VALUES (5, N'melikenin ürünü', 50, CAST(600.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
/****** Object:  Index [IX_Siparisler_FirmaId]    Script Date: 13.01.2023 14:53:53 ******/
CREATE NONCLUSTERED INDEX [IX_Siparisler_FirmaId] ON [dbo].[Siparisler]
(
	[FirmaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Siparisler_UrunId]    Script Date: 13.01.2023 14:53:53 ******/
CREATE NONCLUSTERED INDEX [IX_Siparisler_UrunId] ON [dbo].[Siparisler]
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Urunler_FirmaId]    Script Date: 13.01.2023 14:53:53 ******/
CREATE NONCLUSTERED INDEX [IX_Urunler_FirmaId] ON [dbo].[Urunler]
(
	[FirmaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Firmalar_FirmaId] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[Firmalar] ([Id])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Firmalar_FirmaId]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Urunler_UrunId] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([Id])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Urunler_UrunId]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Firmalar_FirmaId] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[Firmalar] ([Id])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Firmalar_FirmaId]
GO
USE [master]
GO
ALTER DATABASE [fw_firmasiparis] SET  READ_WRITE 
GO
