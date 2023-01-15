CREATE DATABASE DB_QLCAPHE
on primary
(
	name = QLCAPHE_PRIMARY,
	filename = 'C:\test\qlcaphe_primary.mdf',
	size = 4MB,
	maxsize = 20MB,
	filegrowth = 5%
)

log on
(
	name = QLCAPHE_LOG,
	filename = 'C:\test\qlcaphe_log.ldf',
	size = 1MB,
	maxsize = 5MB,
	filegrowth = 5%
)

go
USE DB_QLCAPHE

go
CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(40),
	GIOITINH NVARCHAR(5),
	SDT VARCHAR(13)
)

go
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(10) PRIMARY KEY,
	TENNV NVARCHAR(40),
	GIOITINH NVARCHAR(5),
	SDT VARCHAR(13),
	DIACHI NVARCHAR(30)
)

go
CREATE TABLE HOADON
(
	MAHD VARCHAR(10) PRIMARY KEY,
	MAKH VARCHAR(10) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MANV VARCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(MANV),
	NGAYLAPHD DATE,
	TONGTIEN int
)

go
CREATE TABLE THUCDON
(
	MAMON VARCHAR(10) PRIMARY KEY,
	TENMON NVARCHAR(30),
	GIA int
)

go
CREATE TABLE CHITIETHOADON
(
	MAHD VARCHAR(10) FOREIGN KEY REFERENCES HOADON(MAHD),
	MAMON VARCHAR(10) FOREIGN KEY REFERENCES THUCDON(MAMON),
	SOLUONG INT CHECK(SOLUONG > 0),
	THANHTIEN int,
	CONSTRAINT PK_CTHD PRIMARY KEY (MAHD, MAMON)
)

go
INSERT INTO KHACHHANG VALUES
('KH001',N'Nguyễn Hải Yến',N'Nữ','0909400434'),
('KH002',N'Trương Mạnh Hùng',N'Nam','0908409271'),
('KH003',N'Đào Minh Châu',N'Nữ','0909406245'),
('KH004',N'Bùi Văn Cáp',N'Nam','09094092671'),
('KH005',N'Nguyễn Thị Thanh Thúy',N'Nữ','0909408724'),
('KH006',N'Nguyễn Thị Lan',N'Nữ','0908345690'),
('KH007',N'Nguyễn Thị Thanh Thúy',N'Nữ','090909128731'),
('KH008',N'Trần Thanh Tùng',N'Nam','0909408918'),
('KH009',N'Trương Thị Huệ',N'Nữ','0904408728'),
('KH010',N'Hà Thanh Trúc',N'Nữ','0909409823')

go
INSERT INTO NHANVIEN VALUES
('NV001',N'Trần Xuân Quỳnh Phương',N'Nữ','0123456789',N'Quận 12, TP.HCM'),
('NV002',N'Phan Duy Tân',N'Nam','0987654321',N'Hóc Môn, TP.HCM'),
('NV003',N'Lai Thiết Đồng',N'Nam','0123456789',N'Quận 08, TP.HCM'),
('NV004',N'Nguyễn Minh Trí',N'Nam','01234592674',N'Quận 12, TP.HCM'),
('NV005',N'Trần Phát Toàn',N'Nam','0123092189',N'Quận 02, TP.HCM'),
('NV006',N'Ngô Gia Ý',N'Nữ','0123452187',N'Quận 10, TP.HCM'),
('NV007',N'Lê Việt Anh',N'Nam','0109128789',N'Quận 11, TP.HCM'),
('NV008',N'Trần Minh Anh',N'Nữ','0123409759',N'Quận 03, TP.HCM'),
('NV009',N'Trịnh Kim Ánh',N'Nữ','0123459213',N'Quận 04, TP.HCM'),
('NV010',N'Ngô Minh Hiếu',N'Nam','0123474585',N'Quận 06, TP.HCM')

--============================Cá==========================
-- Trigger TR_CHANGED_CTHD : cập nhật TONGTIEN trong Hóa đơn khi bảng Chi tiết hóa đơn bị thay đổi
go
create trigger TR_CHANGED_CTHD on CHITIETHOADON
after insert, update, delete
as
begin
	declare @MAHD varchar(10), @MAMON varchar(10), @SOLUONG int, @THANHTIEN int

	-- Tính Thành tiền của các Chi tiết hóa đơn được insert, update
	declare _CURSOR cursor
	for select MAHD, MAMON, SOLUONG from inserted

	open _CURSOR
	while 0 = 0
	begin
		fetch next from _CURSOR into @MAHD, @MAMON, @SOLUONG
		if @@FETCH_STATUS <> 0 break

		-- Cập nhật thành tiền
		update CHITIETHOADON set THANHTIEN = @SOLUONG * (	select GIA from THUCDON
															where MAMON = @MAMON	)
		where MAHD = @MAHD and MAMON = @MAMON
	end
	close _CURSOR
	deallocate _CURSOR

	-- Cộng tiền bên thực đơn
	declare _CURSOR1 cursor
	for select MAHD, MAMON from inserted

	open _CURSOR1
	while 0 = 0
	begin
		fetch next from _CURSOR1 into @MAHD, @MAMON
		if @@FETCH_STATUS <> 0 break

		-- Cập nhật thành tiền
		set @THANHTIEN = (select THANHTIEN from CHITIETHOADON where MAHD = @MAHD and MAMON = @MAMON)
		update HOADON set TONGTIEN += @THANHTIEN
		where MAHD = @MAHD
	end
	close _CURSOR1
	deallocate _CURSOR1

	-- Trừ tiền bên thực đơn
	declare _CURSOR2 cursor
	for select MAHD, THANHTIEN from deleted

	open _CURSOR2
	while 0 = 0
	begin
		fetch next from _CURSOR2 into @MAHD, @THANHTIEN
		if @@FETCH_STATUS <> 0 break

		-- Cập nhật thành tiền
		update HOADON set TONGTIEN -= @THANHTIEN
		where MAHD = @MAHD
	end
	close _CURSOR2
	deallocate _CURSOR2
end

go
SET DATEFORMAT DMY

go
INSERT INTO HOADON VALUES
('HD001','KH001','NV002','05/08/2022', 0),
('HD002','KH003','NV004','15/09/2022', 0),
('HD003','KH004','NV009','20/10/2022', 0),
('HD004','KH010','NV006','23/07/2022', 0),
('HD005','KH002','NV007','15/11/2022', 0),
('HD006','KH008','NV010','02/06/2022', 0),
('HD007','KH005','NV005','06/10/2022', 0),
('HD008','KH005','NV001','18/10/2022', 0),
('HD009','KH006','NV009','29/09/2022', 0),
('HD010','KH009','NV005','31/10/2022', 0)

go
INSERT INTO THUCDON VALUES
('M001',N'Cà phê đen',15000),
('M002',N'Cà phê sữa',20000),
('M003',N'Sữa tươi cà phê',25000),
('M004',N'Trà sữa',20000),
('M005',N'Sữa chua',20000),
('M006',N'Trà đào cam sả',30000),
('M007',N'Trà ổi hồng',35000),
('M008',N'Coockie đá xay',35000),
('M009',N'Cappucino',55000),
('M010',N'Frappucino nóng',60000)

go
INSERT INTO CHITIETHOADON VALUES
('HD001','M002',2,NULL),
('HD002','M008',5,NULL),
('HD003','M006',3,NULL),
('HD004','M007',8,NULL),
('HD005','M005',4,NULL),
('HD006','M003',12,NULL),
('HD007','M009',9,NULL),
('HD008','M010',3,NULL),
('HD009','M008',8,NULL),
('HD010','M006',7,NULL)