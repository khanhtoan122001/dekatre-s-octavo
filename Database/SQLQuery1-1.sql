--create database QuanLyDoXe1

use QuanLyDoXe1

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 12/6/2021 1:27:51 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[LoaiThe]    Script Date: 12/6/2021 1:55:31 AM ******/
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



USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[ThamSo]    Script Date: 12/6/2021 1:55:50 AM ******/
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



USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/6/2021 1:28:43 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/6/2021 1:29:07 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[TheXe]    Script Date: 12/6/2021 1:29:20 AM ******/
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
 CONSTRAINT [PK_TheXe] PRIMARY KEY CLUSTERED 
(
	[IDThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TheXe]  WITH CHECK ADD  CONSTRAINT [FK_TheXe_LoaiThe] FOREIGN KEY([LoaiThe])
REFERENCES [dbo].[LoaiThe] ([IDLoai])
GO

ALTER TABLE [dbo].[TheXe] CHECK CONSTRAINT [FK_TheXe_LoaiThe]
GO

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[BaoCaoChamCongNhanVien]    Script Date: 12/6/2021 1:29:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BaoCaoChamCongNhanVien](
	[IDBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [smalldatetime] NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[BaoCaoDoanhThuThang]    Script Date: 12/6/2021 1:29:44 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[BaoCaoLichSuHoatDong]    Script Date: 12/6/2021 1:29:54 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[BaoCaoMatDoGuiXe]    Script Date: 12/6/2021 1:30:04 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[CT_BaoCaoDoanhThuThang]    Script Date: 12/6/2021 1:30:12 AM ******/
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

USE [QuanLyDoXe1]
GO

/****** Object:  Table [dbo].[CT_BaoCaoLichSuHoatDong]    Script Date: 12/6/2021 1:30:21 AM ******/
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

