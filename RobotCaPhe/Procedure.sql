USE [DB_QLCAPHE]
GO
/****** Object:  StoredProcedure [dbo].[DeleteHD]    Script Date: 1/3/2023 9:52:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteHD]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT OFF;
DELETE FROM HOADON
WHERE  (MAHD = @ma)

/****** Object:  StoredProcedure [dbo].[DeleteKhachHang]    Script Date: 1/3/2023 9:53:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteKhachHang]
(
	@MA varchar(10)
)
AS
	SET NOCOUNT OFF;
DELETE KHACHHANG WHERE MAKH=@MA

/****** Object:  StoredProcedure [dbo].[DeleteNhanVien]    Script Date: 1/3/2023 9:53:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteNhanVien]
(
	@MA varchar(10)
)
AS
	SET NOCOUNT OFF;
DELETE NHANVIEN WHERE MANV=@MA

/****** Object:  StoredProcedure [dbo].[GetHD]    Script Date: 1/3/2023 9:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetHD]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MAHD, MAKH, MANV, NGAYLAPHD, TONGTIEN
FROM     HOADON
WHERE  (MAHD = @ma)

/****** Object:  StoredProcedure [dbo].[UpdateHD]    Script Date: 1/3/2023 9:54:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateHD]
(
	@MAKH varchar(10),
	@MANV varchar(10),
	@NGAYLAP date,
	@MAHD varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE HOADON SET MAKH=@MAKH, MANV=@MANV, NGAYLAPHD=@NGAYLAP, TONGTIEN=NULL WHERE MAHD=@MAHD

/****** Object:  StoredProcedure [dbo].[UpdateKhachHang]    Script Date: 1/3/2023 9:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateKhachHang]
(
	@TEN nvarchar(40),
	@GT nvarchar(5),
	@SDT varchar(13),
	@MAKH varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE KHACHHANG SET TENKH=@TEN, GIOITINH=@GT, SDT=@SDT WHERE MAKH=@MAKH

/****** Object:  StoredProcedure [dbo].[UpdateNhanVien]    Script Date: 1/3/2023 9:54:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateNhanVien]
(
	@TEN nvarchar(40),
	@GT nvarchar(5),
	@SDT varchar(13),
	@DC nvarchar(30),
	@MA varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE NHANVIEN SET TENNV=@TEN, GIOITINH=@GT, SDT=@SDT, DIACHI=@DC WHERE MANV=@MA

/****** Object:  StoredProcedure [dbo].[capNhatMonTrenThucDon]    Script Date: 1/5/2023 1:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[capNhatMonTrenThucDon]
(
	@TEN nvarchar(30),
	@GIA int,
	@MA varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE THUCDON SET TENMON=@TEN, GIA=@GIA WHERE MAMON=@MA

/****** Object:  StoredProcedure [dbo].[hienThiChiTietHoaDon]    Script Date: 1/5/2023 1:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[hienThiChiTietHoaDon]
(
	@MA varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MAHD, MAMON, SOLUONG, THANHTIEN FROM dbo.CHITIETHOADON WHERE MAHD=@MA

/****** Object:  StoredProcedure [dbo].[pHienThiHoaDonTheoThoiGian]    Script Date: 1/5/2023 1:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pHienThiHoaDonTheoThoiGian]
(
	@bd date,
	@kt date
)
AS
	SET NOCOUNT ON;
select * from dbo.hienThiHoaDonTheoThoiGian(@bd, @kt)

/****** Object:  StoredProcedure [dbo].[xoaMonKhoiThucDon]    Script Date: 1/5/2023 1:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[xoaMonKhoiThucDon]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT OFF;
delete THUCDON where MAMON=@ma
go

--proc them chi tiet hoa don
create proc themChiTietHoaDon @mahd varchar(10), @mamon varchar(10), @sl int
as
begin
	if exists (select * from CHITIETHOADON where MAHD=@mahd and MAMON=@mamon)
		update CHITIETHOADON set SOLUONG+=@sl
		where MAHD=@mahd and MAMON = @mamon
	else
		insert into CHITIETHOADON (MAHD, MAMON, SOLUONG) values (@mahd, @mamon,@sl)
end

go
create proc soLuongHoaDon @slhd int output
as
begin
	select @slhd = (select count(*) from HOADON)
end

go
alter proc backUPFull
as
	begin
		alter database DB_QLCAPHE
		set recovery full

		backup database DB_QLCAPHE
		to disk='C:\test\caphe.bak'
	end
go
exec backUPFull
alter proc restoreFull
as
	begin
		declare @sql varchar(max)
		restore database DB_QLCAPHE from disk='C:\test\caphe.bak' with recovery, replace
	end
go
exec restoreFull