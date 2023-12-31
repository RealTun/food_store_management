USE [master]
GO
/****** Object:  Database [QLNhaHang]    Script Date: 31/10/2023 11:46:19 CH ******/
CREATE DATABASE [QLNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNhaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNhaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLNhaHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNhaHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNhaHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QLNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNhaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNhaHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNhaHang', N'ON'
GO
ALTER DATABASE [QLNhaHang] SET QUERY_STORE = OFF
GO
USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAN](
	[MaBan] [varchar](5) NOT NULL,
	[TenBan] [nvarchar](20) NULL,
	[LoaiBan] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaHD] [varchar](10) NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HD_KM]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HD_KM](
	[MaHD] [varchar](10) NOT NULL,
	[MaKM] [varchar](5) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](40) NULL,
	[SoTien] [float] NULL,
	[ThoiGian] [smalldatetime] NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InfoFood]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InfoFood](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[TienLai] [int] NULL,
	[ThoiGian] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[MaKM] [varchar](5) NOT NULL,
	[TenKM] [nvarchar](30) NULL,
	[Giatri] [int] NULL,
	[ThoigianBD] [date] NULL,
	[ThoigianKT] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LICHLAM]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LICHLAM](
	[MaNV] [varchar](10) NOT NULL,
	[Ca] [int] NULL,
	[NgayLam] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[NgayLam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MaNL] [varchar](5) NOT NULL,
	[TenNL] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[HSD] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC,
	[HSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](40) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [varchar](40) NULL,
	[Sdt] [varchar](12) NULL,
	[ChucVu] [nvarchar](15) NULL,
	[Luong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NV_BAN]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NV_BAN](
	[MaBan] [varchar](5) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[Sdt] [varchar](12) NULL,
	[Thoigian] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC,
	[Thoigian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[usn] [varchar](10) NOT NULL,
	[pwd] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[usn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TK_NV]    Script Date: 31/10/2023 11:46:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TK_NV](
	[MaNV] [varchar](10) NULL,
	[usn] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN1', N'Bàn 1', N'Nhỏ')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN2', N'Bàn 2', N'Lớn')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN3', N'Bàn 3', N'Lớn')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN4', N'Bàn 4', N'Vừa')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN5', N'Bàn 5', N'Vừa')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [LoaiBan]) VALUES (N'BAN6', N'Bàn 6', N'Nhỏ')
GO
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'B001', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'D002', 2)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'D006', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'P001', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'P002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'1', N'P003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'D006', 3)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'G001', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'G002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'G004', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'S002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'2', N'S003', 2)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'B003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'D001', 2)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'D005', 2)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'M002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'M003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'P001', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'P002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'P005', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'3', N'S003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'4', N'D002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'4', N'D006', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'4', N'M002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'4', N'M003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'4', N'P001', 3)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'B001', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'B003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'P002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'P003', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'P005', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'5', N'P006', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'6', N'B003', 3)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'6', N'D001', 2)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'6', N'D006', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'6', N'G002', 1)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaMon], [SoLuong]) VALUES (N'6', N'G004', 1)
GO
INSERT [dbo].[HD_KM] ([MaHD], [MaKM]) VALUES (N'1', N'KM2')
INSERT [dbo].[HD_KM] ([MaHD], [MaKM]) VALUES (N'3', N'KM1')
INSERT [dbo].[HD_KM] ([MaHD], [MaKM]) VALUES (N'4', N'KM2')
INSERT [dbo].[HD_KM] ([MaHD], [MaKM]) VALUES (N'5', N'KM2')
INSERT [dbo].[HD_KM] ([MaHD], [MaKM]) VALUES (N'6', N'KM3')
GO
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'1', N'Người đi bao', 497000, CAST(N'2023-04-10T01:27:00' AS SmallDateTime), N'NV01')
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'2', N'Lọ lem công chúa', 569000, CAST(N'2023-04-10T01:30:00' AS SmallDateTime), N'NV01')
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'3', N'Ếch đại ka', 816000, CAST(N'2023-04-10T01:31:00' AS SmallDateTime), N'NV01')
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'4', N'Chim sẻ đi mưa', 675000, CAST(N'2023-04-10T01:32:00' AS SmallDateTime), N'NV02')
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'5', N'Quy', 680000, CAST(N'2023-05-04T11:05:00' AS SmallDateTime), N'NV01')
INSERT [dbo].[HoaDon] ([MaHD], [TenKH], [SoTien], [ThoiGian], [MaNV]) VALUES (N'6', N'Khách vãng', 473000, CAST(N'2023-05-07T15:27:00' AS SmallDateTime), N'NV01')
GO
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'B001', N'Bánh mì que nướng', 49000, 12000, CAST(N'2022-11-05T00:06:51.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'B002', N'Bánh mì bơ tỏi', 49000, 12000, CAST(N'2022-11-05T00:06:54.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'B003', N'Bánh mì kẹp nướng', 89000, 17000, CAST(N'2022-11-05T00:06:56.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'B004', N'Bánh mì nướng mật', 29000, 9000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D001', N'Pepsi 330ml', 19000, 4000, CAST(N'2022-11-05T00:06:57.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D002', N'7Up 330ml', 15000, 3000, CAST(N'2022-11-05T00:06:59.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D003', N'Heineken 330ml', 29000, 4000, CAST(N'2022-11-05T00:07:08.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D004', N'Tiger Crystal 330ml', 29000, 4000, CAST(N'2022-11-05T00:07:07.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D005', N'Mirinda Soda kem 330ml', 15000, 3000, CAST(N'2022-11-05T00:08:02.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'D006', N'Aquafina 500ml', 15000, 3000, CAST(N'2022-11-05T00:08:03.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'G001', N'Gà lắc phô mai', 109000, 24000, CAST(N'2022-11-05T00:08:05.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'G002', N'Gà giòn xốt Hàn', 99000, 19000, CAST(N'2022-11-05T00:08:07.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'G003', N'Gà giòn xốt tương tỏi', 119000, 23000, CAST(N'2022-11-05T00:10:34.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'G004', N'Gà Popcorn', 109000, 17000, CAST(N'2022-11-05T00:10:43.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'M001', N'Mỳ Ý sốt kem tươi', 119000, 17000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'M002', N'Mỳ Ý giăm bông', 99000, 27000, CAST(N'2022-11-05T00:08:11.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'M003', N'Mỳ Ý thịt bò bằm', 129000, 27000, CAST(N'2022-11-05T00:07:53.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P001', N'Pizza Hải sản cao cấp', 139000, 31000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P002', N'Pizza Tôm Cocktail', 139000, 31000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P003', N'Pizza Thịt xông khói', 169000, 37000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P004', N'Pizza Phô mai', 119000, 21000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P005', N'Pizza Hawai', 159000, 28000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P006', N'Pizza Rau củ', 119000, 17000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'P007', N'Pizza Gà nướng tam vị', 160000, 37000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'S001', N'Salad đặc sắc', 49000, 12000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'S002', N'Salad gà không xương', 69000, 18000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'S003', N'Salad da cá hồi', 69000, 16000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
INSERT [dbo].[InfoFood] ([MaMon], [TenMon], [DonGia], [TienLai], [ThoiGian]) VALUES (N'S004', N'Salad trộn xốt Caesar', 59000, 12000, CAST(N'2022-11-05T00:12:13.000' AS DateTime))
GO
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [Giatri], [ThoigianBD], [ThoigianKT]) VALUES (N'KM1', N'Giảm giá 75k!', 75000, CAST(N'2023-04-03' AS Date), CAST(N'2023-04-10' AS Date))
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [Giatri], [ThoigianBD], [ThoigianKT]) VALUES (N'KM2', N'Chào đón tháng 4', 44000, CAST(N'2023-04-07' AS Date), CAST(N'2023-04-10' AS Date))
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [Giatri], [ThoigianBD], [ThoigianKT]) VALUES (N'KM3', N'Chào đón tháng 5', 55000, CAST(N'2023-05-01' AS Date), CAST(N'2023-05-10' AS Date))
INSERT [dbo].[KHUYENMAI] ([MaKM], [TenKM], [Giatri], [ThoigianBD], [ThoigianKT]) VALUES (N'MA0', N'Test update 1', 80319, CAST(N'2023-04-03' AS Date), CAST(N'2023-04-13' AS Date))
GO
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV01', 1, CAST(N'2023-04-05' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV01', 2, CAST(N'2023-04-06' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV01', 1, CAST(N'2023-04-07' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV02', 1, CAST(N'2023-04-05' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV02', 1, CAST(N'2023-04-06' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV02', 3, CAST(N'2023-04-07' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV03', 2, CAST(N'2023-04-05' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV03', 3, CAST(N'2023-04-06' AS Date))
INSERT [dbo].[LICHLAM] ([MaNV], [Ca], [NgayLam]) VALUES (N'NV04', 2, CAST(N'2023-04-05' AS Date))
GO
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL1', N'Bột mỳ', 20000, 12, CAST(N'2023-06-10' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL1', N'Bột mỳ', 20000, 12, CAST(N'2023-07-20' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL2', N'Cà chua', 12000, 30, CAST(N'2023-04-20' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL3', N'Lạp xưởng', 25000, 70, CAST(N'2023-08-20' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL4', N'Thịt bò', 105000, 25, CAST(N'2023-04-11' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL5', N'Thịt gà', 70000, 15, CAST(N'2023-04-15' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL6', N'Thịt heo', 89000, 27, CAST(N'2023-04-13' AS Date))
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNL], [DonGia], [SoLuong], [HSD]) VALUES (N'NL7', N'Rau sà lách', 5500, 23, CAST(N'2023-04-10' AS Date))
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Sdt], [ChucVu], [Luong]) VALUES (N'NV01', N'Đỗ Hữu Tuấn', N'Nam', N'21/06/2003', N'0393490572', N'Quản lý', 250000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Sdt], [ChucVu], [Luong]) VALUES (N'NV02', N'Nguyễn Đức Minh', N'Nam', N'11/09/2003', N'09399182191', N'Nhân viên', 200000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Sdt], [ChucVu], [Luong]) VALUES (N'NV03', N'Phan Lan Nhi', N'Nữ', N'9/10/2003', N'0391284818', N'Nhân viên', 200000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Sdt], [ChucVu], [Luong]) VALUES (N'NV04', N'Nguyễn Thị Hà Vi', N'Nữ', N'2/11/2003', N'0913921991', N'Nhân viên', 200000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [Sdt], [ChucVu], [Luong]) VALUES (N'NV05', N'Nguyễn Văn A', N'Nam', N'31/08/2023', N'0938192831', N'Nhân viên', 150000)
GO
INSERT [dbo].[NV_BAN] ([MaBan], [MaNV], [TenKH], [Sdt], [Thoigian]) VALUES (N'BAN1', N'NV01', N'Tấm', N'03139231231', CAST(N'2023-04-07T22:14:00' AS SmallDateTime))
INSERT [dbo].[NV_BAN] ([MaBan], [MaNV], [TenKH], [Sdt], [Thoigian]) VALUES (N'BAN2', N'NV03', N'LỌ LEM', N'093123812381', CAST(N'2023-04-09T07:01:00' AS SmallDateTime))
INSERT [dbo].[NV_BAN] ([MaBan], [MaNV], [TenKH], [Sdt], [Thoigian]) VALUES (N'BAN2', N'NV01', N'NGUOIDATBAN', N'039128312831', CAST(N'2023-04-11T11:30:00' AS SmallDateTime))
GO
INSERT [dbo].[TAIKHOAN] ([usn], [pwd]) VALUES (N'admin', N'admin')
INSERT [dbo].[TAIKHOAN] ([usn], [pwd]) VALUES (N'employee', N'12345')
GO
INSERT [dbo].[TK_NV] ([MaNV], [usn]) VALUES (N'NV01', N'admin')
INSERT [dbo].[TK_NV] ([MaNV], [usn]) VALUES (N'NV02', N'employee')
INSERT [dbo].[TK_NV] ([MaNV], [usn]) VALUES (N'NV03', N'employee')
INSERT [dbo].[TK_NV] ([MaNV], [usn]) VALUES (N'NV04', N'employee')
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [fk_mm_cthd] FOREIGN KEY([MaMon])
REFERENCES [dbo].[InfoFood] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [fk_mm_cthd]
GO
ALTER TABLE [dbo].[HD_KM]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[HD_KM]  WITH CHECK ADD FOREIGN KEY([MaKM])
REFERENCES [dbo].[KHUYENMAI] ([MaKM])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_nv_hd] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_nv_hd]
GO
ALTER TABLE [dbo].[LICHLAM]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NV_BAN]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BAN] ([MaBan])
GO
ALTER TABLE [dbo].[NV_BAN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TK_NV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TK_NV]  WITH CHECK ADD FOREIGN KEY([usn])
REFERENCES [dbo].[TAIKHOAN] ([usn])
GO
USE [master]
GO
ALTER DATABASE [QLNhaHang] SET  READ_WRITE 
GO
