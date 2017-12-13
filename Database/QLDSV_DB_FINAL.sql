USE [QLDSV]
GO
/****** Object:  User [11]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE USER [11] FOR LOGIN [Test] WITH DEFAULT_SCHEMA=[11]
GO
/****** Object:  User [12]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE USER [12] FOR LOGIN [Test2] WITH DEFAULT_SCHEMA=[12]
GO
/****** Object:  User [13]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE USER [13] FOR LOGIN [Test3] WITH DEFAULT_SCHEMA=[13]
GO
/****** Object:  User [N13DCCN001]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE USER [N13DCCN001] FOR LOGIN [TestSV] WITH DEFAULT_SCHEMA=[N13DCCN001]
GO
/****** Object:  DatabaseRole [KHOA]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE ROLE [KHOA]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [SINHVIEN]    Script Date: 12/13/2017 5:35:54 PM ******/
CREATE ROLE [SINHVIEN]
GO
ALTER ROLE [PGV] ADD MEMBER [11]
GO
ALTER ROLE [db_datareader] ADD MEMBER [11]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [11]
GO
ALTER ROLE [KHOA] ADD MEMBER [12]
GO
ALTER ROLE [db_datareader] ADD MEMBER [12]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [12]
GO
ALTER ROLE [KHOA] ADD MEMBER [13]
GO
ALTER ROLE [db_datareader] ADD MEMBER [13]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [13]
GO
ALTER ROLE [SINHVIEN] ADD MEMBER [N13DCCN001]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N13DCCN001]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [N13DCCN001]
GO
ALTER ROLE [db_datareader] ADD MEMBER [KHOA]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [KHOA]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SINHVIEN]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [SINHVIEN]
GO
/****** Object:  Table [dbo].[CHI_TIET_TRUONG_KHOA]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_TRUONG_KHOA](
	[MaKh] [varchar](10) NOT NULL,
	[MaGV] [varchar](15) NOT NULL,
	[TuNgay] [date] NOT NULL,
	[DenNgay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC,
	[MaGV] ASC,
	[TuNgay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUYEN_NGANH]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUYEN_NGANH](
	[MaCN] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MaKh] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_GV_MON]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_GV_MON](
	[MaGV] [varchar](15) NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_LOP_TC]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_LOP_TC](
	[MaLTC] [int] NOT NULL,
	[MaPh] [varchar](10) NOT NULL,
	[Thu] [varchar](7) NOT NULL,
	[Buoi] [varchar](5) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLTC] ASC,
	[MaPh] ASC,
	[Thu] ASC,
	[Buoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANG_KY_MON_HOC]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANG_KY_MON_HOC](
	[MaSV] [varchar](15) NOT NULL,
	[MaLTC] [int] NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLTC] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANG_VIEN]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANG_VIEN](
	[MaGV] [varchar](15) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[HocVi] [nvarchar](50) NULL,
	[HocHam] [nvarchar](50) NULL,
	[ChuyenMon] [nvarchar](50) NOT NULL,
	[MaKh] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KE_HOACH_GIANG_DAY]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KE_HOACH_GIANG_DAY](
	[MaCN] [varchar](10) NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[HK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKh] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [varchar](15) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP_TC]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP_TC](
	[MaMon] [varchar](10) NOT NULL,
	[Nhom] [int] NOT NULL,
	[HocKy] [int] NOT NULL,
	[MaNK] [varchar](20) NOT NULL,
	[MaLTC] [int] IDENTITY(1,1) NOT NULL,
	[MaGV] [varchar](15) NOT NULL,
	[SVToiThieu] [int] NOT NULL,
	[NgayMoDK] [datetime] NOT NULL,
	[NgayDongDK] [datetime] NOT NULL,
	[NgayThi] [datetime] NOT NULL,
	[MaKh] [varchar](10) NOT NULL,
	[TrangThai] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[Nhom] ASC,
	[HocKy] ASC,
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MON]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MON](
	[MaMon] [varchar](10) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[SoTLT] [int] NOT NULL,
	[SoTTH] [int] NULL,
	[SoTC] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[MaPhBan] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NIEN_KHOA]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NIEN_KHOA](
	[MaNK] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONG_BAN]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG_BAN](
	[MaPhBan] [varchar](5) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONG_HOC]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG_HOC](
	[MaPhong] [varchar](10) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[SoCho] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINH_VIEN]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINH_VIEN](
	[MaSV] [varchar](15) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Phai] [nvarchar](5) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[KhoaHoc] [int] NOT NULL,
	[MaLop] [varchar](15) NOT NULL,
	[MaCN] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[GetSubscriptions]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[GetSubscriptions]
as
SELECT k.Ten as Name, s.ServerName, s.ScienceID FROM KHOA k
INNER JOIN (
				SELECT name as Name,
						sms.subscriber_server as ServerName,
						smp.description ScienceID
				  FROM (SELECT name, [description], pubid FROM sysmergepublications smp WHERE [publisher_db] = 'QLDSV') smp
				  INNER JOIN (SELECT subscriber_server, pubid FROM sysmergesubscriptions WHERE db_name = 'QLDSV' AND pubid != subid) sms
				  ON smp.pubid = sms.pubid
			 ) s
ON k.MaKh = s.ScienceID

GO
/****** Object:  View [dbo].[VIEW_ValidCreditClass]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[VIEW_ValidCreditClass]
AS
SELECT ltc.MaLTC, ltc.MaMon, m.Ten as 'TenMon', SoTC, Nhom, gv.HoTen as 'CBGD'
FROM LOP_TC ltc INNER JOIN MON m
ON ltc.MaMon = m.MaMon
INNER JOIN GIANG_VIEN gv
ON ltc.MaGV = gv.MaGV
WHERE ltc.TrangThai = 'MO' AND NgayMoDK <= GETDATE() AND NgayDongDK >= GETDATE()



GO
INSERT [dbo].[CHI_TIET_TRUONG_KHOA] ([MaKh], [MaGV], [TuNgay], [DenNgay]) VALUES (N'CNTT', N'GV001', CAST(N'2017-01-01' AS Date), NULL)
GO
INSERT [dbo].[CHI_TIET_TRUONG_KHOA] ([MaKh], [MaGV], [TuNgay], [DenNgay]) VALUES (N'VT', N'GV003', CAST(N'2017-01-01' AS Date), NULL)
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh]) VALUES (N'CNHT', N'Hệ thống Thông Tin', N'CNTT')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh]) VALUES (N'CNPM', N'Công nghệ Phần mềm', N'CNTT')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh]) VALUES (N'VTDT', N'Điện tử', N'VT')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh]) VALUES (N'VTHN', N'Hệ thống nhúng', N'VT')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV001', N'M001')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV001', N'M002')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV002', N'M001')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV002', N'M002')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV003', N'M003')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV003', N'M004')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV004', N'M003')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon]) VALUES (N'GV004', N'M004')
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN001', 46007, 9)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN002', 46007, NULL)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN003', 46007, NULL)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN004', 46008, 9)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN001', 46009, 9)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN002', 46009, NULL)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN003', 46009, NULL)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN001', 46010, 6)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN002', 46010, NULL)
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem]) VALUES (N'N13DCCN003', 46010, NULL)
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh]) VALUES (N'GV001', N'Nguyễn Thị Linh Đan', N'Tiến sĩ', N'', N'C', N'CNTT')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh]) VALUES (N'GV002', N'Nguyễn Hải Đăng', N'Thạc sĩ', NULL, N'B', N'CNTT')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh]) VALUES (N'GV003', N'Lê Mạnh Hùng', N'Tiến sĩ', NULL, N'C', N'VT')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh]) VALUES (N'GV004', N'Bùi Thanh Liêm', N'Thạc Sĩ', N'', N'V', N'VT')
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK]) VALUES (N'CNHT', N'M001', 1)
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK]) VALUES (N'CNPM', N'M002', 1)
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK]) VALUES (N'VTDT', N'M003', 1)
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK]) VALUES (N'VTHN', N'M004', 1)
GO
INSERT [dbo].[KHOA] ([MaKh], [Ten]) VALUES (N'CNTT', N'Công nghệ Thông tin')
GO
INSERT [dbo].[KHOA] ([MaKh], [Ten]) VALUES (N'VT', N'Viễn Thông')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH]) VALUES (N'D13CQCN01', N'Công Nghệ 1', N'CNTT')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH]) VALUES (N'D13CQCN02', N'Công Nghệ 2', N'CNTT')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH]) VALUES (N'D13CQVT01', N'Viễn Thông 1', N'VT')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH]) VALUES (N'D13CQVT02', N'Viễn Thông 2', N'VT')
GO
SET IDENTITY_INSERT [dbo].[LOP_TC] ON 

GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M001', 1, 1, N'2016-2017', 46007, N'GV001', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M001', 2, 1, N'2016-2017', 46008, N'GV002', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M002', 1, 1, N'2016-2017', 46009, N'GV001', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M002', 2, 1, N'2016-2017', 70006, N'GV001', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M002', 3, 1, N'2016-2017', 70008, N'GV001', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M003', 1, 1, N'2016-2017', 46010, N'GV003', 10, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-13 04:49:09.000' AS DateTime), N'CNTT', N'MO')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai]) VALUES (N'M004', 1, 1, N'2016-2017', 68004, N'GV003', 44, CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2017-12-15 04:49:09.000' AS DateTime), CAST(N'2018-01-10 04:49:09.000' AS DateTime), N'VT', N'MO')
GO
SET IDENTITY_INSERT [dbo].[LOP_TC] OFF
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [SoTC]) VALUES (N'M001', N'Phát triển Ứng dụng Phân tán', 26, 0, 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [SoTC]) VALUES (N'M002', N'Phát triển hệ thống dựa trên tri thức', 40, NULL, 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [SoTC]) VALUES (N'M003', N'Truyền thông vô tuyến', 40, NULL, 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [SoTC]) VALUES (N'M004', N'Kỹ thuật cao tần', 40, NULL, 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [SoTC]) VALUES (N'M005', N'C++', 26, 0, 4)
GO
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] ON 

GO
INSERT [dbo].[NHAN_VIEN] ([MaNV], [Ten], [DiaChi], [MaPhBan]) VALUES (1, N'Nguyễn Thị Hiền Minh', N'Q9, TPHCM', N'PGV')
GO
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] OFF
GO
INSERT [dbo].[NIEN_KHOA] ([MaNK], [Ten]) VALUES (N'2016-2017', N'2016-2017')
GO
INSERT [dbo].[NIEN_KHOA] ([MaNK], [Ten]) VALUES (N'2017-2018', N'2017-2018')
GO
INSERT [dbo].[PHONG_BAN] ([MaPhBan], [Ten]) VALUES (N'PGV', N'Phòng Giáo Vụ')
GO
INSERT [dbo].[PHONG_HOC] ([MaPhong], [Ten], [SoCho]) VALUES (N'2A08', N'2A08', 60)
GO
INSERT [dbo].[PHONG_HOC] ([MaPhong], [Ten], [SoCho]) VALUES (N'2A16', N'2A16', 80)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN001', N'Testing 1', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN0010', N'Testing 10', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN002', N'Testing 2', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN003', N'Testing 3', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN004', N'Testing 4', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN005', N'Testing 5', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN006', N'Testing 6', N'NAM', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN007', N'Testing 7', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN008', N'Testing 8', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCCN009', N'Testing 7', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQCN02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT001', N'VTTesting 1', N'NAM', N'TPCHM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT002', N'VTTesting 2', N'NAM', N'TPCHM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT003', N'VTTesting 3', N'NAM', N'TPCHM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT004', N'VTTesting 1', N'NAM', N'TPCHM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT01', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT005', N'VTTesting 5', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT006', N'VTTesting 6', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT007', N'VTTesting 7', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT02', NULL)
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN]) VALUES (N'N13DCVT008', N'VTTesting 8', N'NU', N'TPHCM', CAST(N'1995-12-13' AS Date), 2013, N'D13CQVT02', NULL)
GO
/****** Object:  Index [UQ__LOP_TC__3B98372D73F19B79]    Script Date: 12/13/2017 5:35:54 PM ******/
ALTER TABLE [dbo].[LOP_TC] ADD UNIQUE NONCLUSTERED 
(
	[MaLTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHI_TIET_TRUONG_KHOA]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
GO
ALTER TABLE [dbo].[CHI_TIET_TRUONG_KHOA]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KHOA] ([MaKh])
GO
ALTER TABLE [dbo].[CHUYEN_NGANH]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KHOA] ([MaKh])
GO
ALTER TABLE [dbo].[CT_GV_MON]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
GO
ALTER TABLE [dbo].[CT_GV_MON]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[CT_LOP_TC]  WITH CHECK ADD FOREIGN KEY([MaLTC])
REFERENCES [dbo].[LOP_TC] ([MaLTC])
GO
ALTER TABLE [dbo].[CT_LOP_TC]  WITH CHECK ADD FOREIGN KEY([MaPh])
REFERENCES [dbo].[PHONG_HOC] ([MaPhong])
GO
ALTER TABLE [dbo].[DANG_KY_MON_HOC]  WITH CHECK ADD FOREIGN KEY([MaLTC])
REFERENCES [dbo].[LOP_TC] ([MaLTC])
GO
ALTER TABLE [dbo].[DANG_KY_MON_HOC]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINH_VIEN] ([MaSV])
GO
ALTER TABLE [dbo].[GIANG_VIEN]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KHOA] ([MaKh])
GO
ALTER TABLE [dbo].[KE_HOACH_GIANG_DAY]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[KE_HOACH_GIANG_DAY]  WITH CHECK ADD FOREIGN KEY([MaCN])
REFERENCES [dbo].[CHUYEN_NGANH] ([MaCN])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHOA] ([MaKh])
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KHOA] ([MaKh])
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD FOREIGN KEY([MaNK])
REFERENCES [dbo].[NIEN_KHOA] ([MaNK])
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD  CONSTRAINT [FK_LOP_TC_CT_GV_MON] FOREIGN KEY([MaGV], [MaMon])
REFERENCES [dbo].[CT_GV_MON] ([MaGV], [MaMon])
GO
ALTER TABLE [dbo].[LOP_TC] CHECK CONSTRAINT [FK_LOP_TC_CT_GV_MON]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD FOREIGN KEY([MaPhBan])
REFERENCES [dbo].[PHONG_BAN] ([MaPhBan])
GO
ALTER TABLE [dbo].[SINH_VIEN]  WITH CHECK ADD FOREIGN KEY([MaCN])
REFERENCES [dbo].[CHUYEN_NGANH] ([MaCN])
GO
ALTER TABLE [dbo].[SINH_VIEN]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[CT_LOP_TC]  WITH CHECK ADD CHECK  (([Buoi]='SANG' OR [Buoi]='CHIEU'))
GO
ALTER TABLE [dbo].[CT_LOP_TC]  WITH CHECK ADD CHECK  (([Thu]>=(2) OR [Thu]<=(7)))
GO
ALTER TABLE [dbo].[DANG_KY_MON_HOC]  WITH CHECK ADD CHECK  (([DIEM]>=(0) OR [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD CHECK  (([HocKy]>=(1) AND [HocKy]<=(3)))
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD CHECK  (([Nhom]>=(1)))
GO
ALTER TABLE [dbo].[LOP_TC]  WITH CHECK ADD CHECK  (([TrangThai]='HUY' OR [TrangThai]='MO'))
GO
ALTER TABLE [dbo].[SINH_VIEN]  WITH CHECK ADD CHECK  (([Phai]='NAM' OR [PHAI]='NU'))
GO
/****** Object:  StoredProcedure [dbo].[SP_CancelCreditClass]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CancelCreditClass]
	@maLTC int
AS
IF EXISTS(SELECT 1 FROM CT_LOP_TC WHERE MaLTC = @maLTC)
BEGIN
	SELECT 'FAILURE' AS RESPONSE
END
ELSE
BEGIN
	UPDATE LOP_TC SET TrangThai = 'HUY' WHERE MaLTC = @maLTC
	SELECT 'SUCCESS' AS RESPONSE
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRegistrationByCredit]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRegistrationByCredit]
	@maLopTC int
AS
SELECT dk.MaSV, sv.HoTen, dk.MaLTC, Diem
FROM DANG_KY_MON_HOC dk
INNER JOIN
SINH_VIEN sv on sv.MaSV = dk.MaSV
WHERE MaLTC = @maLopTC
GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudent]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SP_GetStudent]
(
@Malop varchar(15)

)
as
IF exists (SELECT 1 FROM SINH_VIEN WHERE MaLop = @Malop)
	BEGIN
		SELECT MaSV, HoTen, Phai, NgaySinh, DiaChi From SINH_VIEN where MaLop=@Malop
	END
ELSE
	BEGIN
		SELECT MaSV, HoTen, Phai, NgaySinh, DiaChi From LINK1.QLDSV.dbo.SINH_VIEN where MaLop=@Malop
	END


GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentByClass]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetStudentByClass]
	@maLop VARCHAR(15)
AS
SELECT MaSV, HoTen, Phai, DiaChi, NgaySinh, KhoaHoc, MaCN FROM SINH_VIEN WHERE MaLop = @maLop
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Login]
	@login NVARCHAR (50)
AS
DECLARE @user NVARCHAR(50)
DECLARE @role nvarchar(50)
DECLARE @hoTen nvarchar(50)

--Get user from login
SELECT @user=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@login)

--Get role of user
SELECT @role = name
FROM sys.sysusers 
WHERE UID = (SELECT GROUPUID 
             FROM SYS.SYSMEMBERS 
              WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										WHERE NAME=@user))

--Get name from user
IF(@role = 'PGV')
BEGIN
	SELECT @hoTen = Ten FROM NHAN_VIEN WHERE MaNV = @user
END
ELSE
BEGIN
	IF(@role = 'KHOA')
	BEGIN
		SELECT @hoTen = HoTen FROM GIANG_VIEN WHERE MaGV = @user
	END
	ELSE
	IF(@role = 'SINHVIEN')
		BEGIN
			SELECT @hoTen = HoTen FROM SINH_VIEN WHERE MaSV = @user
		END
END

--Return result
SELECT @user as Id, @hoTen as Name, @role as Role
GO
/****** Object:  StoredProcedure [dbo].[SP_SignUp]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Create by Vinh Huynh 11/16/2017

CREATE PROCEDURE [dbo].[SP_SignUp]
(
	@login varchar(20),
	@password varchar(20),
	@id varchar(20),
	@role varchar(20)
)
AS
--Declare var
DECLARE @RET INT

--Add Login
EXEC @RET= SP_ADDLOGIN @login, @password,'QLDSV'
IF (@RET =1)  -- LOGIN NAME BI TRUNG
    RETURN 1
 
--Map login to user
EXEC @RET= SP_GRANTDBACCESS @login, @id
IF (@RET =1)  -- USER  NAME BI TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @login
		RETURN 2
	END

--Check valid role
IF (@role != 'PGV' AND @role != 'KHOA' AND @role != 'SINHVIEN')
	BEGIN
		EXEC SP_DROPLOGIN @login
		EXEC SP_DROPUSER @id
		RETURN 3 --	INVALID ROLE
	END

--Map user to role
IF (@role = 'PGV' OR @role = 'KHOA')
	BEGIN
		EXEC sp_addsrvrolemember @login, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @login, 'SysAdmin'
	END
EXEC sp_addrolemember @role, @id

--Sign up success
RETURN 0  -- THANH CONG

GO
/****** Object:  StoredProcedure [dbo].[SP_StranStudent]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SP_StranStudent]
@MaSV varchar(15)
AS
IF EXISTS(SELECT 1 FROM DANG_KY_MON_HOC  WHERE MaSV=@MaSV)
BEGIN
	select HocKy,m.Ten, Diem from DANG_KY_MON_HOC dkmh
	 inner join LOP_TC  ltc on dkmh.MaLTC=ltc.MaLTC 
	 inner join MON m on ltc.MaMon=m.MaMon
	 Where dkmh.MaSV=@MaSV
END
 

Else 
BEGIN
	select HocKy,m.Ten, Diem from LINK1.QLDSV.DBO.DANG_KY_MON_HOC dkmh
	 inner join LINK1.QLDSV.DBO.LOP_TC  ltc on dkmh.MaLTC=ltc.MaLTC 
	 inner join LINK1.QLDSV.DBO.MON m on ltc.MaMon=m.MaMon
	 Where dkmh.MaSV=@MaSV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_StranSub]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[SP_StranSub]
@MaLTC int
AS
IF EXISTS(Select 1 From LOP_TC WHERE MaLTC = @MaLTC)
BEGIN
	select sv.MaSV, HoTen, NgaySinh, Phai, Diem 
	from DANG_KY_MON_HOC as dkmh inner join SINH_VIEN as sv 
		ON MaLTC = @MaLTC 
		WHERE sv.MaSV = dkmh.MaSV
END
ELSE
BEGIN
	select sv.MaSV, HoTen, NgaySinh, Phai, Diem 
	from LINK1.QLDSV.dbo.DANG_KY_MON_HOC as dkmh inner join LINK1.QLDSV.dbo.SINH_VIEN as sv 
		ON MaLTC = @MaLTC 
		WHERE sv.MaSV = dkmh.MaSV
END

GO
/****** Object:  StoredProcedure [dbo].[SP_StudentExam]    Script Date: 12/13/2017 5:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SP_StudentExam]
@MaLTC int
as
IF EXISTS(SELECT 1 FROM LOP_TC WHERE MaLTC = @MaLTC)
	BEGIN
		SELECT sv.MaSV, HoTen FROM SINH_VIEN sv
		INNER JOIN
			DANG_KY_MON_HOC dkmh 
			ON sv.MaSV=dkmh.MaSV
		WHERE MaLTC=@MaLTC
	END
ELSE
	BEGIN
		SELECT sv.MaSV, HoTen FROM LINK1.QLDSV.DBO.SINH_VIEN sv
		INNER JOIN
			LINK1.QLDSV.DBO.DANG_KY_MON_HOC dkmh 
			ON sv.MaSV=dkmh.MaSV
		WHERE MaLTC=@MaLTC
	END



GO
