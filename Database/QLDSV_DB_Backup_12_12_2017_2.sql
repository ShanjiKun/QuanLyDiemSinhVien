USE [QLDSV]
GO
/****** Object:  DatabaseRole [KHOA]    Script Date: 12/12/2017 10:01:18 AM ******/
CREATE ROLE [KHOA]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 12/12/2017 10:01:18 AM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [SINHVIEN]    Script Date: 12/12/2017 10:01:18 AM ******/
CREATE ROLE [SINHVIEN]
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
/****** Object:  Table [dbo].[CHI_TIET_TRUONG_KHOA]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_43BC0B06456F41F1B4515A422B3CC854]  DEFAULT (newsequentialid()),
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
/****** Object:  Table [dbo].[CHUYEN_NGANH]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_7BE3D1402EB547B68D37FEE42BD30156]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_GV_MON]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_GV_MON](
	[MaGV] [varchar](15) NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_AF8B440C45D2434AAD9282546C4DAD48]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_LOP_TC]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_0E6A74E5D61A449DB960992D60787D50]  DEFAULT (newsequentialid()),
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
/****** Object:  Table [dbo].[DANG_KY_MON_HOC]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_C61C3CD5B74C4142A086C40B332A9B5D]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaLTC] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANG_VIEN]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_FFA375CCF28E41CE9AEE90FA55DE6122]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KE_HOACH_GIANG_DAY]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F49D6D791D0942C7B1180C1DFB951252]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKh] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_DCC9AB9A030749498B1C9031AE8203A3]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_FBD4423A60BA46229906DD8F0CC3D426]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP_TC]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[MaLTC] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[MaGV] [varchar](15) NOT NULL,
	[SVToiThieu] [int] NOT NULL,
	[NgayMoDK] [datetime] NOT NULL,
	[NgayDongDK] [datetime] NOT NULL,
	[NgayThi] [datetime] NOT NULL,
	[MaKh] [varchar](10) NOT NULL,
	[TrangThai] [varchar](5) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3BD68BCE1D684D3EADE6AB213DAE5C93]  DEFAULT (newsequentialid()),
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
/****** Object:  Table [dbo].[MON]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_0E22501212384D40875A41DFD01E558E]  DEFAULT (newsequentialid()),
	[SoTC] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MaNV] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[MaPhBan] [varchar](5) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3BB1832D32844B80B334A7554A253FA3]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NIEN_KHOA]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NIEN_KHOA](
	[MaNK] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_42EAF99A6D5943B5B21E5395885B7D80]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONG_BAN]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG_BAN](
	[MaPhBan] [varchar](5) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F98104B3562146298020CC30E3EE3652]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaPhBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONG_HOC]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_8D2ADDB331EC483CB80E406FF25D0205]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINH_VIEN]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_EC501C0819B34943AEC31761001E6F6A]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[GetSubscriptions]    Script Date: 12/12/2017 10:01:18 AM ******/
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
/****** Object:  View [dbo].[VIEW_ValidCreditClass]    Script Date: 12/12/2017 10:01:18 AM ******/
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
WHERE NgayMoDK <= GETDATE() AND NgayDongDK >= GETDATE()

GO
INSERT [dbo].[CHI_TIET_TRUONG_KHOA] ([MaKh], [MaGV], [TuNgay], [DenNgay], [rowguid]) VALUES (N'CNTT', N'GV001', CAST(N'2017-01-01' AS Date), NULL, N'd8129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CHI_TIET_TRUONG_KHOA] ([MaKh], [MaGV], [TuNgay], [DenNgay], [rowguid]) VALUES (N'VT', N'GV003', CAST(N'2017-01-01' AS Date), NULL, N'd9129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh], [rowguid]) VALUES (N'CNHT', N'Hệ thống Thông Tin', N'CNTT', N'cb129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh], [rowguid]) VALUES (N'CNPM', N'Công nghệ Phần mềm', N'CNTT', N'cc129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh], [rowguid]) VALUES (N'VTDT', N'Điện tử', N'VT', N'cd129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CHUYEN_NGANH] ([MaCN], [Ten], [MaKh], [rowguid]) VALUES (N'VTHN', N'Hệ thống nhúng', N'VT', N'ce129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV001', N'M001', N'da129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV001', N'M002', N'db129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV002', N'M001', N'dc129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV002', N'M002', N'dd129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV003', N'M003', N'de129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV003', N'M004', N'df129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV004', N'M003', N'e0129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_GV_MON] ([MaGV], [MaMon], [rowguid]) VALUES (N'GV004', N'M004', N'e1129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (2, N'2A16', N'2', N'SANG', CAST(N'2017-11-15' AS Date), CAST(N'2017-12-15' AS Date), N'ed129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (46003, N'2A08', N'2', N'SANG', CAST(N'2017-12-10' AS Date), CAST(N'2018-01-10' AS Date), N'e048cb62-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (46003, N'2A16', N'3', N'SANG', CAST(N'2017-12-10' AS Date), CAST(N'2018-01-10' AS Date), N'8044eb79-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (46005, N'2A08', N'2', N'SANG', CAST(N'2017-12-10' AS Date), CAST(N'2018-01-10' AS Date), N'20078db1-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (46005, N'2A16', N'3', N'SANG', CAST(N'2017-12-10' AS Date), CAST(N'2018-01-10' AS Date), N'00ea39ba-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[CT_LOP_TC] ([MaLTC], [MaPh], [Thu], [Buoi], [NgayBatDau], [NgayKetThuc], [rowguid]) VALUES (46006, N'2A08', N'2', N'SANG', CAST(N'2018-01-11' AS Date), CAST(N'2018-01-12' AS Date), N'601da58e-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem], [rowguid]) VALUES (N'N13DCVT001', 2, NULL, N'f0129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem], [rowguid]) VALUES (N'N13DCVT002', 2, NULL, N'f1129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem], [rowguid]) VALUES (N'N13DCCN001', 46003, NULL, N'70455d77-76de-e711-a300-001c42f58b9c')
GO
INSERT [dbo].[DANG_KY_MON_HOC] ([MaSV], [MaLTC], [Diem], [rowguid]) VALUES (N'N13DCCN001', 46006, NULL, N'd1581f8f-cadd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh], [rowguid]) VALUES (N'GV001', N'Nguyễn Thị Linh Đan', N'Tiến sĩ', NULL, N'A', N'CNTT', N'cf129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh], [rowguid]) VALUES (N'GV002', N'Nguyễn Hải Đăng', N'Thạc sĩ', NULL, N'B', N'CNTT', N'd0129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh], [rowguid]) VALUES (N'GV003', N'Lê Mạnh Hùng', N'Tiến sĩ', NULL, N'C', N'VT', N'd1129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTen], [HocVi], [HocHam], [ChuyenMon], [MaKh], [rowguid]) VALUES (N'GV004', N'Bùi Thanh Liêm', N'Thạc Sĩ', NULL, N'D', N'VT', N'd2129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK], [rowguid]) VALUES (N'CNHT', N'M001', 1, N'e2129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK], [rowguid]) VALUES (N'CNPM', N'M002', 1, N'e3129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK], [rowguid]) VALUES (N'VTDT', N'M003', 1, N'e4129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KE_HOACH_GIANG_DAY] ([MaCN], [MaMon], [HK], [rowguid]) VALUES (N'VTHN', N'M004', 1, N'e5129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KHOA] ([MaKh], [Ten], [rowguid]) VALUES (N'CNTT', N'Công nghệ Thông tin', N'c0129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[KHOA] ([MaKh], [Ten], [rowguid]) VALUES (N'VT', N'Viễn Thông', N'c1129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH], [rowguid]) VALUES (N'D13CQCN01', N'Công Nghệ 1', N'CNTT', N'd3129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH], [rowguid]) VALUES (N'D13CQCN02', N'Công Nghệ 2', N'CNTT', N'd4129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH], [rowguid]) VALUES (N'D13CQCN03', N'Công Nghệ 3', N'CNTT', N'402d4e3f-88de-e711-a300-001c42f58b9c')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH], [rowguid]) VALUES (N'D13CQVT01', N'Viễn Thông 1', N'VT', N'd5129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[LOP] ([MaLop], [Ten], [MaKH], [rowguid]) VALUES (N'D13CQVT02', N'Viễn Thông 2', N'VT', N'd6129206-4bc9-e711-957a-001c42f58b9c')
GO
SET IDENTITY_INSERT [dbo].[LOP_TC] ON 

GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai], [rowguid]) VALUES (N'M001', 1, 1, N'2016-2017', 46003, N'GV001', 10, CAST(N'2017-12-09 04:49:09.000' AS DateTime), CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2018-01-24 04:49:09.000' AS DateTime), N'CNTT', N'MO', N'60095cfb-95dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai], [rowguid]) VALUES (N'M001', 2, 1, N'2016-2017', 46005, N'GV002', 10, CAST(N'2017-12-09 04:49:09.000' AS DateTime), CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2018-01-24 04:49:09.000' AS DateTime), N'CNTT', N'MO', N'00aaa426-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai], [rowguid]) VALUES (N'M002', 1, 1, N'2016-2017', 46006, N'GV001', 10, CAST(N'2017-12-09 04:49:09.000' AS DateTime), CAST(N'2017-12-12 04:49:09.000' AS DateTime), CAST(N'2018-01-24 04:49:09.000' AS DateTime), N'CNTT', N'MO', N'a07cc23b-96dd-e711-bf8e-001c42f58b9c')
GO
INSERT [dbo].[LOP_TC] ([MaMon], [Nhom], [HocKy], [MaNK], [MaLTC], [MaGV], [SVToiThieu], [NgayMoDK], [NgayDongDK], [NgayThi], [MaKh], [TrangThai], [rowguid]) VALUES (N'M003', 1, 1, N'2016-2017', 2, N'GV003', 10, CAST(N'2017-11-12 00:00:00.000' AS DateTime), CAST(N'2017-11-14 00:00:00.000' AS DateTime), CAST(N'2017-12-20 00:00:00.000' AS DateTime), N'VT', N'MO', N'eb129206-4bc9-e711-957a-001c42f58b9c')
GO
SET IDENTITY_INSERT [dbo].[LOP_TC] OFF
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [rowguid], [SoTC]) VALUES (N'M001', N'Phát triển Ứng dụng Phân tán', 32, NULL, N'c2129206-4bc9-e711-957a-001c42f58b9c', 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [rowguid], [SoTC]) VALUES (N'M002', N'Phát triển hệ thống dựa trên tri thức', 40, NULL, N'c3129206-4bc9-e711-957a-001c42f58b9c', 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [rowguid], [SoTC]) VALUES (N'M003', N'Truyền thông vô tuyến', 40, NULL, N'c4129206-4bc9-e711-957a-001c42f58b9c', 4)
GO
INSERT [dbo].[MON] ([MaMon], [Ten], [SoTLT], [SoTTH], [rowguid], [SoTC]) VALUES (N'M004', N'Kỹ thuật cao tần', 40, NULL, N'c5129206-4bc9-e711-957a-001c42f58b9c', 4)
GO
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] ON 

GO
INSERT [dbo].[NHAN_VIEN] ([MaNV], [Ten], [DiaChi], [MaPhBan], [rowguid]) VALUES (1, N'Nguyễn Thị Hiền Minh', N'Q9, TPHCM', N'PGV', N'd7129206-4bc9-e711-957a-001c42f58b9c')
GO
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] OFF
GO
INSERT [dbo].[NIEN_KHOA] ([MaNK], [Ten], [rowguid]) VALUES (N'2016-2017', N'2016-2017', N'c6129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[NIEN_KHOA] ([MaNK], [Ten], [rowguid]) VALUES (N'2017-2018', N'2017-2018', N'c7129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[PHONG_BAN] ([MaPhBan], [Ten], [rowguid]) VALUES (N'PGV', N'Phòng Giáo Vụ', N'c8129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[PHONG_HOC] ([MaPhong], [Ten], [SoCho], [rowguid]) VALUES (N'2A08', N'2A08', 60, N'c9129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[PHONG_HOC] ([MaPhong], [Ten], [SoCho], [rowguid]) VALUES (N'2A16', N'2A16', 80, N'ca129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN001', N'Nguyễn Thị Diệu Nhi', N'NU', N'Q10, TPHCM', CAST(N'1995-12-12' AS Date), 2013, N'D13CQCN01', NULL, N'e6129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN002', N'Nguyễn Văn Ba', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', NULL, N'e7129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN003', N'Tess', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', N'CNHT', N'7020f05a-b6de-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN004', N'Test', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', N'CNHT', N'a0847ba9-b6de-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN005', N'Test1', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', N'CNHT', N'308659e9-b6de-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN006', N'Test1', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', NULL, N'807bc08e-bade-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN007', N'Test1', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', NULL, N'50dd80ab-bade-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCCN008', N'Test1', N'NAM', N'Q11, TPHCM', CAST(N'1995-11-11' AS Date), 2013, N'D13CQCN01', N'CNHT', N'50b00a6b-bcde-e711-9c0e-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCVT001', N'Nguyễn Thị Quỳnh Trang', N'NU', N'Q12, TPHCM', CAST(N'1995-10-10' AS Date), 2013, N'D13CQVT01', NULL, N'e8129206-4bc9-e711-957a-001c42f58b9c')
GO
INSERT [dbo].[SINH_VIEN] ([MaSV], [HoTen], [Phai], [DiaChi], [NgaySinh], [KhoaHoc], [MaLop], [MaCN], [rowguid]) VALUES (N'N13DCVT002', N'Nguyễn Minh Thiện', N'NAM', N'Q3, TPCHM', CAST(N'1995-09-09' AS Date), 2013, N'D13CQVT01', NULL, N'e9129206-4bc9-e711-957a-001c42f58b9c')
GO
/****** Object:  Index [UQ__LOP_TC__3B98372D73F19B79]    Script Date: 12/12/2017 10:01:18 AM ******/
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
ALTER TABLE [dbo].[LOP_TC]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_11DB75BD_86C0_48F8_80B2_38D4AC999ECB] CHECK NOT FOR REPLICATION (([MaLTC]>(2) AND [MaLTC]<=(1002) OR [MaLTC]>(1002) AND [MaLTC]<=(2002)))
GO
ALTER TABLE [dbo].[LOP_TC] CHECK CONSTRAINT [repl_identity_range_11DB75BD_86C0_48F8_80B2_38D4AC999ECB]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_496C4B8F_FB03_4441_8763_DA2745F2EB58] CHECK NOT FOR REPLICATION (([MaNV]>(1) AND [MaNV]<=(1001) OR [MaNV]>(1001) AND [MaNV]<=(2001)))
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [repl_identity_range_496C4B8F_FB03_4441_8763_DA2745F2EB58]
GO
ALTER TABLE [dbo].[SINH_VIEN]  WITH CHECK ADD CHECK  (([Phai]='NAM' OR [PHAI]='NU'))
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRegistrationByCredit]    Script Date: 12/12/2017 10:01:18 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_GetStudent]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetStudent](
	@malop varchar(15)
)
as
SELECT MaSV,
		HoTen,
		Phai,
		DiaChi,
		NgaySinh,
		KhoaHoc
FROM SINH_VIEN
WHERE MaLop = @malop
GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentByClass]    Script Date: 12/12/2017 10:01:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetStudentByClass]
	@maLop VARCHAR(15)
AS
SELECT MaSV, HoTen, Phai, DiaChi, NgaySinh, KhoaHoc, MaCN FROM SINH_VIEN WHERE MaLop = @maLop
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 12/12/2017 10:01:18 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_SignUp]    Script Date: 12/12/2017 10:01:18 AM ******/
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
	END
EXEC sp_addrolemember @role, @id

--Sign up success
RETURN 0  -- THANH CONG

GO
