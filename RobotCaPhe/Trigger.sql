use DB_QLCAPHE
go

--=================================Quỳnh Phương===================================
--trigger xóa hóa đơn
create trigger xoaHoaDon on HoaDon
instead of delete
as
begin
	begin tran
		delete CHITIETHOADON where MAHD = (select MAHD from deleted)
		delete HOADON where MAHD = (select MAHD from deleted)
	commit tran
end
go
--trigger xóa khách hàng
create trigger xoaKhachHang on KhachHang
instead of delete
as
begin
	declare @makh varchar(10)
	set @makh = (select MAKH from deleted)
	update HOADON set MAKH = null where MAKH = @makh
	delete KHACHHANG where MAKH = @makh
end
go

--trigger xóa nhân viên
create trigger xoaNhanVien on NhanVien
instead of delete
as
begin
	update HOADON set MANV = null where MANV=(select MANV from deleted)
	delete NHANVIEN where MANV = (select MANV from deleted)
end
go

--trigger xóa món
create trigger xoaMon on THUCDON
instead of delete 
as
	begin
		update CHITIETHOADON set MAMON = null where MAMON = (select MAMON from deleted)
		delete THUCDON where MAMON = (select MAMON from deleted)
	end
go

--trigger thêm khách hàng mã tự động tăng
create trigger themKhachHang on KHACHHANG
 after insert
 as
 begin
	declare @MaKH varchar(10)

	begin tran set transaction isolation level read committed
		if not exists (select * from KHACHHANG)
		Set @MaKH = 1
		else
		begin
			Set @MaKH = (select RIGHT(MAX(MAKH),3) from KHACHHANG)+1
			Set @MaKH = 'KH'+REPLICATE('0',3-LEN(@MaKH)) + @MaKH
			update KHACHHANG set MAKH = @MaKH where MAKH = (select MAKH from inserted)
		end
	commit tran
 end
go

--trigger thêm nhân viên mã tự động tăng
create trigger themNhanVien on NHANVIEN
after insert
as
begin
	declare @MaNV varchar(10)

	begin tran set transaction isolation level read committed
		if not exists (select * from NHANVIEN) 
		Set @MaNV=1
		else
		begin
			Set @MaNV=(select RIGHT(MAX(MANV),3) from NHANVIEN)+1
			Set @MaNV='NV'+REPLICATE('0',3-LEN(@MaNV))+@MaNV
			update NHANVIEN set MANV=@MaNV where MANV=(select MANV from inserted)
		end
	commit tran
end
go

--trigger thêm hóa đơn mã tự động tăng
create trigger themHoaDon on HOADON
 after insert
 as
 begin
	begin tran set transaction isolation level read committed
		declare @MaHD varchar(10)
		if not exists (select * from HOADON) 
			Set @MaHD = 1
		else
		begin
			Set @MaHD = (select RIGHT(MAX(MAHD),3) from HOADON)+1
			Set @MaHD = 'HD'+REPLICATE('0',3-LEN(@MaHD))+@MaHD
			update HOADON set MAHD = @MaHD where MAHD = (select MAHD from inserted)
		end
	commit tran
end
go

--trigger thêm món trong thực đơn mã tự động tăng
create trigger themMonVaoThucDon on THUCDON
 after insert
 as
 begin
	begin tran set transaction isolation level read committed
		declare @MaMon varchar(10)
		if not exists (select * from THUCDON) 
		Set @MaMon=1
		else
		begin
			Set @MaMon=(select RIGHT(MAX(MAMON),3) from THUCDON)+1
			Set @MaMon='M'+REPLICATE('0',3-LEN(@MaMon))+@MaMon
			update THUCDON set MAMON=@MaMon where MAMON=(select MAMON from inserted)
		end
	commit tran
end
go

--function nội tuyến hiển thị hóa đơn theo khoảng thời gian
create function hienThiHoaDonTheoThoiGian (@ngayBD date, @ngayKT date)
returns @tbl table (maHD varchar(10), maKH varchar(10), maNV varchar(10), ngayLapHD date, tongTien int)
as
	begin
		insert into @tbl
		select * from HOADON where NGAYLAPHD between @ngayBD and @ngayKT
		return
	end
go

--update cột tổng tiền trên bảng hóa đơn = sum(thành tiền)
update HOADON set TONGTIEN=(select sum(THANHTIEN) from CHITIETHOADON where MAHD=HOADON.MAHD) 
go
--update cột thành tiền trên bảng chi tiết hóa đơn = số lượng * giá
update CHITIETHOADON set THANHTIEN=SOLUONG*(select GIA from THUCDON where MAMON=CHITIETHOADON.MAMON)
go
