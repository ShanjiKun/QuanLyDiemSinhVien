USE [QLDSV]
GO

/****** Object:  View [dbo].[VIEW_ValidCreditClass]    Script Date: 12/11/2017 2:29:15 PM ******/
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


