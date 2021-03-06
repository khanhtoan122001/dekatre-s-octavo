--create database QuanLyDoXe

use QuanLyDoXe

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[ThamSo]    Script Date: 12/11/2021 1:23:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ThamSo](
	[TenThamSo] [nvarchar](50) NULL,
	[GiaTri] [int] NULL,
	[IDThamSo] [int] IDENTITY(1,1) NOT NULL,
	[NgayApDung] [smalldatetime] NULL,
	[GiaTriMoi] [int] NULL,
 CONSTRAINT [PK_ThamSo] PRIMARY KEY CLUSTERED 
(
	[IDThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 12/11/2021 1:24:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoaiTaiKhoan](
	[IDLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[IDLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[LoaiThe]    Script Date: 12/11/2021 1:24:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoaiThe](
	[IDLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_LoaiThe] PRIMARY KEY CLUSTERED 
(
	[IDLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/11/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HoaDon](
	[IDHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [smalldatetime] NULL,
	[ThanhTien] [money] NULL,
	[BienSo] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/11/2021 1:25:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TenThat] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[CMND] [nchar](10) NULL,
	[LoaiTaiKhoan] [int] NULL,
	[Avatar] [image] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([LoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([IDLoai])
GO

ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[TheXe]    Script Date: 12/11/2021 1:25:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TheXe](
	[IDThe] [int] IDENTITY(1,1) NOT NULL,
	[ChuSoHuu] [nvarchar](50) NULL,
	[NgayTao] [smalldatetime] NULL,
	[TenXe] [nvarchar](50) NULL,
	[BienSoXe] [nvarchar](50) NULL,
	[ThoiGianGui] [smalldatetime] NULL,
	[LoaiThe] [int] NULL,
	[Status] [bit] NULL,
	[AnhXe] [image] NULL,
 CONSTRAINT [PK_TheXe] PRIMARY KEY CLUSTERED 
(
	[IDThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TheXe]  WITH CHECK ADD  CONSTRAINT [FK_TheXe_LoaiThe] FOREIGN KEY([LoaiThe])
REFERENCES [dbo].[LoaiThe] ([IDLoai])
GO

ALTER TABLE [dbo].[TheXe] CHECK CONSTRAINT [FK_TheXe_LoaiThe]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoChamCongNhanVien]    Script Date: 12/11/2021 10:09:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoChamCongNhanVien](
	[IDBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [smalldatetime] NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[IsLogin] [bit] NULL,
	[ThoiGianLamViec] [int] NULL,
 CONSTRAINT [PK_BaoCaoChamCongNhanVien] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BaoCaoChamCongNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoChamCongNhanVien_BaoCaoChamCongNhanVien] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO

ALTER TABLE [dbo].[BaoCaoChamCongNhanVien] CHECK CONSTRAINT [FK_BaoCaoChamCongNhanVien_BaoCaoChamCongNhanVien]
GO


USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoDoanhThuThang]    Script Date: 12/11/2021 1:26:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoDoanhThuThang](
	[IDBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[Nam] [int] NULL,
	[LoaiThe] [int] NULL,
 CONSTRAINT [PK_BaoCaoDoanhThuThang] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BaoCaoDoanhThuThang]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoDoanhThuThang_LoaiThe] FOREIGN KEY([LoaiThe])
REFERENCES [dbo].[LoaiThe] ([IDLoai])
GO

ALTER TABLE [dbo].[BaoCaoDoanhThuThang] CHECK CONSTRAINT [FK_BaoCaoDoanhThuThang_LoaiThe]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoLichSuHoatDong]    Script Date: 12/11/2021 1:26:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoLichSuHoatDong](
	[IDBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [smalldatetime] NULL,
	[HoatDong] [int] NULL,
 CONSTRAINT [PK_BaoCaoLichSuHoatDong] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoMatDoGuiXe]    Script Date: 12/11/2021 1:27:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoMatDoGuiXe](
	[IDBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [smalldatetime] NULL,
	[Gio] [int] NULL,
	[TongXeVao] [int] NULL,
	[TongXeRa] [int] NULL,
	[ChenhLech] [int] NULL,
 CONSTRAINT [PK_BaoCaoMatDoGuiXe] PRIMARY KEY CLUSTERED 
(
	[IDBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoTongChi]    Script Date: 12/11/2021 1:27:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoTongChi](
	[IDBaoCaoChi] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
 CONSTRAINT [PK_BaoCaoTongChi] PRIMARY KEY CLUSTERED 
(
	[IDBaoCaoChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[BaoCaoTongThu]    Script Date: 12/11/2021 1:27:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoTongThu](
	[IDBaoCaoThu] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
 CONSTRAINT [PK_BaoCaoTongThu] PRIMARY KEY CLUSTERED 
(
	[IDBaoCaoThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[CT_BaoCaoDoanhThuThang]    Script Date: 12/11/2021 1:27:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CT_BaoCaoDoanhThuThang](
	[IDCTBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[IDBaoCao] [int] NULL,
	[Thang] [int] NULL,
	[TongThu] [int] NULL,
	[TongChi] [int] NULL,
	[ChenhLech] [int] NULL,
 CONSTRAINT [PK_CT_BaoCaoDoanhThuThang] PRIMARY KEY CLUSTERED 
(
	[IDCTBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CT_BaoCaoDoanhThuThang]  WITH CHECK ADD  CONSTRAINT [FK_CT_BaoCaoDoanhThuThang_BaoCaoDoanhThuThang] FOREIGN KEY([IDBaoCao])
REFERENCES [dbo].[BaoCaoDoanhThuThang] ([IDBaoCao])
GO

ALTER TABLE [dbo].[CT_BaoCaoDoanhThuThang] CHECK CONSTRAINT [FK_CT_BaoCaoDoanhThuThang_BaoCaoDoanhThuThang]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[CT_BaoCaoLichSuHoatDong]    Script Date: 12/11/2021 1:28:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CT_BaoCaoLichSuHoatDong](
	[IDCTBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[IDBaoCao] [int] NOT NULL,
	[ThoiGian] [smalldatetime] NULL,
	[BienSo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[IDCTBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CT_BaoCaoLichSuHoatDong]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_Table_1] FOREIGN KEY([IDBaoCao])
REFERENCES [dbo].[BaoCaoLichSuHoatDong] ([IDBaoCao])
GO

ALTER TABLE [dbo].[CT_BaoCaoLichSuHoatDong] CHECK CONSTRAINT [FK_Table_1_Table_1]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[CT_BaoCaoTongChi]    Script Date: 12/11/2021 1:28:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CT_BaoCaoTongChi](
	[IDCT_BaoCaoTongChi] [int] IDENTITY(1,1) NOT NULL,
	[IDBaoCao] [int] NULL,
	[ThoiGian] [smalldatetime] NULL,
	[GiaTri] [money] NULL,
	[HoatDong] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_BaoCaoTongChi] PRIMARY KEY CLUSTERED 
(
	[IDCT_BaoCaoTongChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CT_BaoCaoTongChi]  WITH CHECK ADD  CONSTRAINT [FK_CT_BaoCaoTongChi_BaoCaoTongChi] FOREIGN KEY([IDBaoCao])
REFERENCES [dbo].[BaoCaoTongChi] ([IDBaoCaoChi])
GO

ALTER TABLE [dbo].[CT_BaoCaoTongChi] CHECK CONSTRAINT [FK_CT_BaoCaoTongChi_BaoCaoTongChi]
GO

USE [QuanLyDoXe]
GO

/****** Object:  Table [dbo].[CT_BaoCaoTongThu]    Script Date: 12/11/2021 1:28:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CT_BaoCaoTongThu](
	[IDCT_BaoCaoTongThu] [int] IDENTITY(1,1) NOT NULL,
	[IDBaoCao] [int] NULL,
	[ThoiGian] [smalldatetime] NULL,
	[GiaTri] [money] NULL,
	[HoatDong] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_BaoCaoTongThu] PRIMARY KEY CLUSTERED 
(
	[IDCT_BaoCaoTongThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CT_BaoCaoTongThu]  WITH CHECK ADD  CONSTRAINT [FK_CT_BaoCaoTongThu_BaoCaoTongThu] FOREIGN KEY([IDBaoCao])
REFERENCES [dbo].[BaoCaoTongThu] ([IDBaoCaoThu])
GO

ALTER TABLE [dbo].[CT_BaoCaoTongThu] CHECK CONSTRAINT [FK_CT_BaoCaoTongThu_BaoCaoTongThu]
GO

