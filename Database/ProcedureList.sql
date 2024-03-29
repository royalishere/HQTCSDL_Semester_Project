USE HTDatGiaoThucAn
GO

	-- Đăng nhập
CREATE PROC sp_DangNhap
	@TENDANGNHAP VARCHAR(30),
	@MATKHAU VARCHAR(30),
	@MAACC VARCHAR(5) OUTPUT,
	@LOAIACC INT OUTPUT,
	@TRANGTHAI VARCHAR(20) OUTPUT
AS
BEGIN
	SET @MAACC = 'NULL'
	IF NOT EXISTS (SELECT MaTK
				FROM TaiKhoan 
				WHERE TenDangNhap = @TENDANGNHAP 
				AND MatKhau = @MATKHAU)
	BEGIN
		PRINT N'Sai tên đăng nhập hoặc mật khẩu'
		RETURN 0
	END
	
	-- lấy mã acc
	SET @MAACC = (SELECT MaTK
				FROM TaiKhoan 
				WHERE TenDangNhap = @TENDANGNHAP 
				AND MatKhau = @MATKHAU)
				
	-- lấy trạng thái
	SET @TRANGTHAI = (SELECT TrangThai
				FROM TaiKhoan 
				WHERE TenDangNhap = @TENDANGNHAP 
				AND MatKhau = @MATKHAU)

	-- lấy loại acc
	DECLARE @LOAI VARCHAR(30) 
	SET @LOAI = (SELECT loaiTK
				FROM TaiKhoan 
				WHERE TenDangNhap = @TENDANGNHAP 
				AND MatKhau = @MATKHAU)
	IF(@LOAI = 'AD')
		SET @LOAIACC = 0
	ELSE IF (@LOAI = 'DT')
		set @LOAIACC = 1
	ELSE IF (@LOAI = 'KH')
		SET @LOAIACC = 2
	ELSE IF (@LOAI = 'NV')
		SET @LOAIACC = 3
	ELSE IF (@LOAI = 'TX')
		SET @LOAIACC = 4
		
	-- xử lí đăng nhập
	if (@MAACC != 'NULL')
	BEGIN
		PRINT N'Đăng nhập thành công'
		RETURN 1
	END
	ELSE RETURN 0	
END
GO

	-- Đăng ký
create proc sp_dangky
	@matk char(5),
	@tentk varchar(30),
	@pass varchar(30),
	@loaitk varchar(30)
as
begin tran
	insert into TaiKhoan values (@matk, @tentk, @pass, @loaitk, 'Kich hoat')
commit tran

drop proc test
create proc test
	@input int,
	@output int output
as
begin tran
	begin try
		if @input > 1 
			print ('nice try')
	end try
	begin catch
		return 0
		rollback tran
	end catch
commit tran
return 1
go

Declare @return_status int;
exec @return_status = test 6, @return_status;
print @return_status;
go

grant execute on sp_DangNhap to public

exec sp_DangNhap 'sa', '1', null, null, null
-------PHAN HE DOI TAC--------
--- Dang ky thong tin
create proc dangky_doitac
	@MaCuaHang char(5),
	@TenCuaHang nvarchar(50),
	@NgDaiDien char(5),
	@SLChiNhanh int,
	@TGMoCua time,
	@TGDongCua time,
	@DiaChi nvarchar(100),
	@SDT varchar(11),
	@Email varchar(50)
as
begin transaction
	begin try
		if @MaCuaHang is not null and @TenCuaHang is not null and @NgDaiDien is not null
		--- and not @SLChiNhanh = '' and not @TGMoCua = '' and not @TGDongCua = '' and not @DiaChi = '' and not @SDT = '' and not @Email = ''
		begin
			if exists( select * from ThongTinDoiTac dt where dt.MaCuaHang = @MaCuaHang)
			begin
				PRINT 'Ma cua hang ' + @MaCuaHang + ' da ton tai'
				rollback transaction
				return
			end
			if not exists (select * from ThongTinDaiDien dd where dd.MaNgDaiDien = @NgDaiDien)
			begin
				PRINT 'Ng dai dien ' +@NgDaiDien + ' khong ton tai'
				rollback transaction
				return
			end
			if @SLChiNhanh <= 0
			begin
				PRINT 'So luong chi nhanh khong hop le'
				rollback transaction
				return
			end
			if @TGMoCua > @TGDongCua
			begin
				PRINT 'Thoi gian khong hop le'
				rollback transaction
				return
			end
			insert into ThongTinDoiTac
			values(@MaCuaHang, @TenCuaHang, @NgDaiDien, @SLChiNhanh, @TGMoCua, @TGDongCua, @DiaChi, @SDT, @Email)

			insert into CuaHang_ChiNhanh
			values(1, @MaCuaHang, @DiaChi)

			print 'Dang ky thong tin thanh cong !!!'
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

--- Lap hop dong
create proc laphopdong
	@MaHopDong char(5),
	@MaSoThue char(10),
	@NgDaiDien char(5),
	@TGBatDau datetime, 
	@TGKetThuc datetime,
	@SoTK varchar(20),
	@NganHang nvarchar(50),
	@ChiNhanhNH nvarchar(50),
	@PhiKichHoat int
as
begin transaction
	begin try
		if @MaHopDong is not null and  @MaSoThue is not null and @NgDaiDien is not null
		--- and not @TGBatDau = '' and not @TGKetThuc = '' and @SoTK is not null and not @NganHang = '' and not @ChiNhanhNH = '' and not @PhiKichHoat = '' and not @PhiHoaHong = ''
		begin
			if exists (select *  from HopDong hd where hd.MaHopDong = @MaHopDong)
			begin
				print 'Ma hop dong da ton tai'
				rollback transaction
				return
			end
			if not exists (select * from ThongTinDaiDien dd where dd.MaNgDaiDien = @NgDaiDien)
			begin
				PRINT 'Ng dai dien ' + @NgDaiDien + ' khong ton tai'
				rollback transaction
				return
			end
			if @TGBatDau > @TGKetThuc
			begin
				PRINT 'Thoi gian khong hop le'
				rollback transaction
				return
			end
			if @PhiKichHoat < 1000000
			begin
				print 'Phi kick hoat khong hop le'
				rollback transaction
				return
			end
			begin
				PRINT 'Thoi gian khong hop le'
				rollback transaction
				return
			end
			insert into HopDong
			values(@MaHopDong, @MaSoThue, @NgDaiDien, @TGBatDau, @TGKetThuc, @SoTK, @NganHang, @ChiNhanhNH, @PhiKichHoat)
			print 'Tao hop dong thanh cong !!!'
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

--- Quan ly cua hang(_chinhanh)
create proc quanly_cuahang
	@ChiNhanh int,
	@CuaHang char(5),
	@DiaChi nvarchar(100)
as
begin transaction
	begin try
		if @ChiNhanh is not null and @CuaHang is not null
		begin
			if exists (select * from CuaHang_ChiNhanh ch where ch.CuaHang = @CuaHang)
			begin
				if exists (select * from CuaHang_ChiNhanh ch where ch.ChiNhanh = @ChiNhanh)
				begin
					UPDATE CuaHang_ChiNhanh SET DiaChi = @DiaChi
					where ChiNhanh = @ChiNhanh and CuaHang = @CuaHang
					print 'Cap nhat cua hang thanh cong'
				end
				else
				begin
					insert CuaHang_ChiNhanh
					values(@ChiNhanh, @CuaHang, @DiaChi)
					print 'Them chi nhanh thanh cong'
				end
			end
			else
			begin
				print 'Cua hang chua duoc dang ky tren he thong'
				rollback transaction
				return
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

--- Quan ly thuc don
create proc them_sua_thucdon
	@MaMon char(5),
	@TenMon nvarchar(80),
	@MaCH char(5),
	@MieuTaMon nvarchar(100),
	@Gia int,
	@TinhTrang nvarchar(30)
as
begin transaction
	begin try
		if @MaMon is not null and @TenMon is not null and @MaCH is not null and @Gia is not null
		begin
			if exists(select * from ThucDon td where td.MaMon = @MaMon and td.MaCH = @MaCH)
			begin
				UPDATE ThucDon SET TenMon = @TenMon, MieuTaMon = @MieuTaMon, Gia = @Gia, TinhTrang = @TinhTrang
				where MaMon = @MaMon and MaCH = @MaCH
				print 'Cap nhat cua hang thanh cong'
			end
			if exists(select * from ThucDon td where td.MaCH = @MaCH and td.MaMon != @MaMon)
			begin
				INSERT INTO ThucDon
				VALUES(@MaMon, @TenMon, @MaCH, @MieuTaMon, @Gia, @TinhTrang)
				print 'Them thuc don thanh cong'
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		return
		rollback transaction
	end catch
commit transaction
go

create proc xoa_thucdon
	@MaMon char(5),
	@TenMon nvarchar(80),
	@MaCH char(5)
as
begin transaction
	begin try
		if @MaMon is not null and @TenMon is not null and @MaCH is not null
		begin
			if exists(select * from ThucDon td where td.MaMon = @MaMon and td.MaCH = @MaCH and td.TenMon = @TenMon)
			begin
				DELETE FROM ThucDon
				where MaMon = @MaMon and MaCH = @MaCH and TenMon = @TenMon
				print 'Cap nhat cua hang thanh cong'
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

-------PHAN HE TAI XE---------
--- Dang ky thanh vien
drop proc dangky_taixe
create proc dangky_taixe
	@matx char(3),
	@tentx char(30),
	@ngaysinh date,
	@cccd char(12),
	@sdt char(10),
	@diachi char(20),
	@email varchar(50),
	@biensoxe char(5),
	@khuvuc char(20),
	@sotk char(10),
	@phithue int,
	@output int output
as
	begin transaction
		begin try
			if @matx is not null and not @tentx = '' and not @ngaysinh = '' and not @cccd = '' and not @sdt = '' and not @diachi = '' and not @biensoxe = '' and not @khuvuc = '' and not @sotk = '' and not @phithue = ''
			begin
				if exists(select * from TaiXe tx where tx.matx = @matx)
				begin
					PRINT 'Ma tai xe ' + @matx + ' da ton tai'
					rollback transaction
					return 0
				end
				insert into TaiXe
				values(@matx, @tentx, @ngaysinh, @cccd, @sdt, @diachi,@email, @biensoxe, @khuvuc, @sotk, @phithue, @matx)
				print 'Dang ky tai xe thanh cong !!!'
			end
			else
			begin
				PRINT 'Thong tin khong duoc rong'
				rollback transaction
				return 0
			end
		end try
		begin catch
			print 'Loi'
			rollback transaction
			return 0;
		end catch
	commit transaction
	return 1
go
grant execute on dangky_taixe to public

--- Tiep nhan va xu ly don hang
create proc xem_donhang
	@KhuVuc nvarchar(50) -- truyen vao khu vuc cua tai xe de hien thi don hang trong khu vuc do
as
begin transaction
	begin try
		if @KhuVuc is not null
		begin
			select * from DonHang dh where dh.DCGiaoHang = @KhuVuc
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

drop proc chon_donhang
create proc chon_donhang
	@output int output,
	@MaDonHang char(5),
	@MaTX char(5)
as
begin transaction
	begin try
		if @MaDonHang is not null and @MaTX is not null
		begin
			if not exists(select * from TaiXe tx where tx.MaTX = @MaTX)
			begin
				print 'Ma tai xe khong hop le'
				set @output = 0
				rollback transaction
				return
			end
			if exists(select * from ChiTietGiaoHang gh where gh.MaDonHang = @MaDonHang)
			begin
				print 'Don hang da duoc nhan boi tai xe khac'
				set @output = 0
				rollback transaction
				return
			end
			if exists(select * from DonHang dh where dh.MaDonHang = @MaDonHang and dh.TinhTrang = 'Dang xu ly')
			begin
				insert into ChiTietGiaoHang
				values(@MaDonHang, @MaTX, 'Da nhan')
				print 'Da nhan don hang: ' + @MaDonHang
				update DonHang set TinhTrang = 'Chap nhan'
				where MaDonHang = @MaDonHang
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			set @output = 0
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
	set @output = 1
commit transaction
go
grant execute on chon_donhang to TAIXE
go

create proc capnhat_tinhtrang
	@MaDonHang char(5),
	@MaTX char(5),
	@TinhTrangGiaoHang nvarchar(30),
	@output int output
as
begin transaction
	set @output = 1
	begin try
		if @MaDonHang is not null and @MaTX is not null and @TinhTrangGiaoHang is not null
		begin
			if not exists(select * from TaiXe tx where tx.MaTX = @MaTX)
			begin
				print 'Ma tai xe khong hop le'
				set @output = 0
				rollback transaction
				return
			end
			if not exists(select * from DonHang dh where dh.MaDonHang = @MaDonHang)
			begin
				print 'Don hang khong ton tai'
				set @output = -1
				rollback transaction
				return
			end
			if @TinhTrangGiaoHang not in ('Da nhan', 'Dang giao', 'Hoan thanh')
			begin
				print 'Tinh trang giao hang khong hop le'
				set @output = -2
				rollback transaction
				return
			end
			if exists(select * from DonHang dh where dh.MaDonHang = @MaDonHang and dh.TinhTrang = 'Chap nhan')
			begin
				update ChiTietGiaoHang set TinhTrangGiaoHang = @TinhTrangGiaoHang
				where MaDonHang = @MaDonHang and MaTX = @MaTX
				print 'Tinh trang don hang ' + @MaDonHang + ' duoc doi thanh ' + @TinhTrangGiaoHang
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			set @output = -4
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go
grant execute on capnhat_tinhtrang to TAIXE
go

--- Theo doi thu nhap
create proc thunhap_taixe
	@MaTX char(5)
as
begin transaction
	begin try
		if @MaTX is not null
		begin
			if not exists(select * from TaiXe tx where tx.MaTX = @MaTX)
			begin
				print 'Ma tai xe khong hop le'
				rollback transaction
				return
			end
			if exists(select * from ChiTietGiaoHang gh where gh.MaTX = @MaTX)
			begin
				select dh.PhiVanChuyen
				from DonHang dh
				where dh.MaDonHang in (select gh.MaDonHang from ChiTietGiaoHang gh where gh.MaTX = @MaTX and gh.TinhTrangGiaoHang = 'Hoan thanh')
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

declare @output int
exec capnhat_tinhtrang 'DH002','TX001', 'Dang giao', @output
go

--------PHAN HE KHACH HANG----------
--- Dang ky khach hang
create proc dangky_khachhang
	@MaKH char(5),
	@TenKH nvarchar(50),
	@NgaySinh date,
	@SDT varchar(11),
	@DiaChi nvarchar(100),
	@Email varchar(50)
as
begin transaction
	begin try
		if @MaKH is not null and @TenKH is not null and @SDT is not null and @Email is not null
		begin
			if exists( select * from KhachHang kh where kh.MaKH = @MaKH)
			begin
				PRINT 'Ma khach hang ' + @MaKH + ' da ton tai'
				rollback transaction
				return
			end
			else
			begin
				insert into KhachHang
				values(@MaKH, @TenKH, @NgaySinh, @SDT, @DiaChi, @Email)
				print 'Dang ky thong tin thanh cong !!!'
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

--- Dat hang
create proc xem_thucdon
	@MaCuaHang char(5),
	@TenCuaHang nvarchar(50)
as
begin transaction
	begin try
		if @MaCuaHang is not null or @TenCuaHang is not null
		begin
			if exists(select * from ThongTinDoiTac dt where dt.MaCuaHang = @MaCuaHang and dt.TenCuaHang = @TenCuaHang) or exists (select * from ThongTinDoiTac dt where dt.MaCuaHang = @MaCuaHang and @TenCuaHang = null)
			begin
				select *
				from ThucDon td
				where td.MaCH = @MaCuaHang
			end
			if exists(select * from ThongTinDoiTac dt where @MaCuaHang = null and dt.TenCuaHang = @TenCuaHang)
			begin
				select *
				from ThucDon td
				where td.MaCH = (select dt.MaCuaHang from ThongTinDoiTac dt where dt.TenCuaHang = @TenCuaHang)
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
	end catch
commit transaction
go

-------PHAN HE NHAN VIEN--------
--- Duyet hop dong
drop proc Sp_NV_DuyetHopDong
go
create PROC Sp_NV_DuyetHopDong
	@MaHopDong char(5),
	@MaNV char(5),	
	@TinhTrang varchar(30),
	@output int output
AS
BEGIN TRAN
set @output = 1
	BEGIN TRY
		if @MaHopDong is not null and @MaNV is not null and @TinhTrang is not null
		begin
			IF NOT EXISTS (SELECT * FROM HopDong where @MaHopDong = MaHopDong)
			BEGIN
				PRINT ' Hop dong khong Ton Tai'
				set @output = 0
				ROLLBACK TRAN
				RETURN 0
			END
			IF NOT EXISTS (SELECT * FROM NhanVien WHERE @MaNV = MaNV)
			BEGIN
				PRINT 'Nhan vien khong Ton Tai'
				set @output = 2
				ROLLBACK TRAN
				RETURN
			END
			IF @TinhTrang NOT IN ('Chua xac nhan', 'Da xac nhan')
			BEGIN
				PRINT 'Tinh trang khong hop le'
				set @output = 4
				ROLLBACK TRAN
				RETURN
			END
				waitfor delay '00:00:04'
			IF EXISTS (SELECT * FROM XacNhanHopDong WHERE MaHD = @MaHopDong and MaNV is not null)
			begin
				print 'Hop dong da duoc xac nhan boi nhan vien khac'
				set @output = 5
				rollback tran
				return
			end
			
			declare @MaCH char(5)
			set @MaCH = (select MaCuaHang from ThongTinDoiTac where NgDaiDien = (select NgDaiDien from HopDong where MaHopDong = @MaHopDong))
			IF EXISTS (SELECT * FROM XacNhanHopDong WHERE MaHD = @MaHopDong and MaNV is null)
			BEGIN
				waitfor delay '00:00:02'
				UPDATE XacNhanHopDong with(xlock)
				SET MaNV = @MaNV, TinhTrang = @TinhTrang 
				WHERE MaHD = @MaHopDong
				print 'Da cap nhat tinh trang thanh cong'
			END
			else
			begin
				INSERT INTO XacNhanHopDong
				VALUES(@MaHopDong, @MaCH, @MaNV, @TinhTrang)
				print 'Da cap nhat tinh trang thanh cong'
			end
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			set @output = 6
			rollback transaction
			return
		end
	end try
	begin catch
		print 'Loi'
		set @output = 7
		rollback transaction
		return
	end catch
commit transaction
go
grant execute ON Sp_NV_DuyetHopDong TO NHANVIEN
GO

-----------------PROC TRANH CHAP---------------------
create proc GiaHanHopDong_1
	@soThang  int,
	@MaHD varchar(5)
as
begin tran
	begin try
	-- B1: Kiem tra hop dong co ton tai khong
	if not exists (select * 
			FROM HopDong
			WHERE MaHopDong = @MaHD)
	begin
		print N' Hop dong khong ton tai'
		rollback tran
		return 0
	end
	-- B2: Kiem tra thoi gian gia han lon hon 0
	if @soThang <=0
	begin
		print N'Thoi gian gia han khong hop le'
		rollback tran
		return 0
	end

	-- B3: Lay thong tin thoi gian ket thuc 1 hop dong
	declare @TGKetThuc datetime
	set @TGKetThuc = (select TGKetThuc from HopDong with(xlock) where MaHopDong = @MaHD)
	waitfor delay '00:00:10'
	-- B4: Chinh sua thoi gian het han hop dong
	update HopDong SET TGKetThuc = DATEADD(month,@soThang,@TGKetThuc)
	WHERE MaHopDong = @MaHD
	end try

	begin catch
		print N'Loi he thong, khong gia han duoc hop dong'
	end catch

commit tran
return 1
go

create proc GiaHanHopDong_2
	@soThang  int,
	@MaHD varchar(5)
as
begin tran
	begin try
	-- B1: Kiem tra hop dong co ton tai khong
	if not exists (select * 
			FROM HopDong
			WHERE MaHopDong = @MaHD)
	begin
		print N' Hop dong khong ton tai'
		rollback tran
		return 0
	end
	-- B2: Kiem tra thoi gian gia han lon hon 0
	if @soThang <=0
	begin
		print N'Thoi gian gia han khong hop le'
		rollback tran
		return 0
	end

	-- B3: Lay thong tin thoi gian ket thuc 1 hop dong
	declare @TGKetThuc datetime
	set @TGKetThuc = (select TGKetThuc from HopDong where MaHopDong = @MaHD)
	-- B4: Chinh sua thoi gian het han hop dong
	update HopDong SET TGKetThuc = DATEADD(month,@soThang,@TGKetThuc)
	WHERE MaHopDong = @MaHD
	end try

	begin catch
		print N'Loi he thong, khong gia han duoc hop dong'
	end catch

commit tran
return 1
go

--drop proc GiaHanHopDong_1
--drop proc GiaHanHopDong_2

create proc UpdateTinhTrangHD_1
	@MaHD varchar(5)
as
begin tran
	begin try
	-- B1: Kiem tra hop dong co ton tai khong
	if not exists (select * 
			FROM HopDong
			WHERE MaHopDong = @MaHD)
	begin
		print N' Hop dong khong ton tai'
		rollback tran
		return 0
	end
	-- B2: Kiem tra tinh trang hop dong da xac nhan chua, neu roi thi khong cap nhat
	declare @TinhTrang nvarchar(50)
	set @TinhTrang = (select TinhTrang from XacNhanHopDong with(xlock) where MaHD = @MaHD)
	if @TinhTrang = 'Da xac nhan'
	begin
		print N'Hop dong da duoc xac nhan'
		rollback tran
		return 0
	end
	waitfor delay '00:00:05'
	-- B3: Chinh sua thoi gian het han hop dong
	set @TinhTrang = 'Da xac nhan'
	update XacNhanHopDong SET TinhTrang = @TinhTrang
	WHERE MaHD = @MaHD
	end try

	begin catch
		print N'Loi he thong, khong the cap nhat tinh trang hop dong'
	end catch

commit tran
return 1
go

create proc UpdateTinhTrangHD_2
	@MaHD varchar(5)
as
begin tran
	begin try
	-- B1: Kiem tra hop dong co ton tai khong
	if not exists (select * 
			FROM HopDong
			WHERE MaHopDong = @MaHD)
	begin
		print N' Hop dong khong ton tai'
		rollback tran
		return 0
	end
	-- B2: Kiem tra tinh trang hop dong da xac nhan chua, neu roi thi khong cap nhat
	declare @TinhTrang nvarchar(50)
	set @TinhTrang = (select TinhTrang from XacNhanHopDong where MaHD = @MaHD)
	if @TinhTrang = 'Da xac nhan'
	begin
		print N'Hop dong da duoc xac nhan'
		rollback tran
		return 0
	end
	-- B3: Cap nhat tinh trang hop dong
	set @TinhTrang = 'Dang xu ly'
	update XacNhanHopDong SET TinhTrang = @TinhTrang
	WHERE MaHD = @MaHD
	end try

	begin catch
		print N'Loi he thong, khong the cap nhat tinh trang hop dong'
	end catch

commit tran
return 1
go

--drop proc UpdateTinhTrangHD_1
--drop proc UpdateTinhTrangHD_2

create proc sp_themMonAn
	@MaMon char(5),
	@TenMon nvarchar(80),
	@MaCH char(5),
	@MieuTa nvarchar(100),
	@Gia int,
	@TinhTrang nvarchar(30)
as
begin tran
	-- thay đổi isolation level thanh read committed de them exclusive lock khi ghi
	set transaction isolation level read committed
	begin try
		-- kiểm tra tồn tại món ăn hay chưa
		if exists (select * from ThucDon where MaMon = @MaMon and MaCH = @MaCH)
		begin
			print ('Mon an da ton tai')
			rollback tran
			return 0
		end
		
		--Thêm món mới vào thực đơn
		insert into ThucDon
		values (@MaMon,@TenMon,@MaCH,@MieuTa,@Gia,@TinhTrang)
		waitfor delay '00:00:10'
		
	end try
	begin catch
		print ('Loi')
		rollback tran
		return 0
	end catch
commit tran
return 1
go

-- xem thực đơn
create proc sp_xemThucDon
as
begin tran
	-- đọc bảng
	select * from ThucDon
	
commit tran
return 1
go

CREATE PROC TAIXE_XAC_NHAN_GIAO_HANG(@MA_TX CHAR(5), @MA_DH CHAR(5))
AS
BEGIN TRAN
	IF NOT EXISTS(SELECT * 
			FROM ChiTietGiaoHang WITH (NOLOCK)
			WHERE @MA_DH = MaDonHang )
		BEGIN
			PRINT N'Ma don hang khong ton tai'
			ROLLBACK TRAN
			RETURN 0
		END
	IF NOT EXISTS(SELECT * 
		FROM TaiXe
		WHERE @MA_TX = MaTX)
	BEGIN
		PRINT N'Ma tai xe khong ton tai'
		ROLLBACK TRAN
		RETURN 0
	END
	WAITFOR DELAY '00:00:05'
	IF EXISTS (SELECT * 
		FROM ChiTietGiaoHang WITH (NOLOCK)
		WHERE @MA_DH = MaDonHang AND MaTX IS NOT NULL)
		BEGIN	
			PRINT N'Don hang da co tai xe khac nhan!'
			ROLLBACK TRAN
			RETURN
		END
	UPDATE ChiTietGiaoHang WITH (XLOCK)
	SET TinhTrangGiaoHang = 'Da nhan', MaTX = @MA_TX
	WHERE @MA_DH = MaDonHang
PRINT N'Xac nhan giao hang thanh cong'
COMMIT TRAN
RETURN 1
GO

-- NHAN VIEN: XAC NHAN HOP DONG
CREATE PROC NHANVIEN_XACNHANHOPDONG(@MA_NV CHAR(5), @MA_HD CHAR(5))
AS
BEGIN TRAN
	IF NOT EXISTS(SELECT * 
			FROM XacNhanHopDong WITH (NOLOCK)
			WHERE @MA_HD = MaHD)
		BEGIN
			PRINT N'Ma hop dong khong ton tai'
			ROLLBACK TRAN
			RETURN 0
		END
	IF NOT EXISTS(SELECT * 
		FROM NhanVien
		WHERE @MA_NV = MaNV)
	BEGIN
		PRINT N'Ma nhan vien khong ton tai'
		ROLLBACK TRAN
		RETURN 0
	END
	WAITFOR DELAY '00:00:05'
	IF EXISTS (SELECT * 
		FROM XacNhanHopDong WITH (NOLOCK)
		WHERE @MA_HD = MaHD AND TinhTrang = 'Da xac nhan')
	BEGIN
		PRINT N'Hop dong da duoc xac nhan roi, khong the xac nhan lai!'
		ROLLBACK TRAN
		RETURN 0
	END
	UPDATE XacNhanHopDong WITH (XLOCK)
	SET MaNV = @MA_NV, TinhTrang = 'Da xac nhan'
	WHERE @MA_HD = MaHD
PRINT N'Xac nhan hop dong thanh cong'
COMMIT TRAN
RETURN 1
GO

--Đổi mật khẩu tài khoản nhân viên (do Admin lam)
CREATE PROC NV_Doi_MatKhau
	@MaTK char(5),
	@MatKhau VARCHAR(30)
AS
BEGIN TRAN
	BEGIN TRY
	--kiểm tra mã nhân viên có tồn tại hay không
	IF NOT EXISTS (SELECT * 
				FROM TaiKhoan
				WHERE MaTK = @MaTK)
	BEGIN
		PRINT N' Tai khoan khong ton tai'
		ROLLBACK TRAN
		RETURN 0
	END	

	-- xử lí Update mật khẩu
	UPDATE TaiKhoan
	SET MatKhau = @MatKhau
	WHERE MaTK = @MaTK
	END TRY
	BEGIN CATCH
		PRINT N'Loi'
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO

--Lấy thông tin tài khoản nhân viên
CREATE PROC NV_LayTongTinTK
	@TenDangNhap VARCHAR(30),
	@MatKhau VARCHAR(30)
AS
-- Thiet lap muc co lap Repeatable Read de ngan chan Unrepeatable Read
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY		
	DECLARE @MaTK char(5)
	SET @MaTK = 'NULL'

	-- xử lí lấy thông tin mã tai khoan
	SET @MaTK = (SELECT A.MaTK          
                FROM TaiKhoan A, NhanVien NV 
                WHERE A.TenDangNhap = @TenDangNhap
                AND A.MatKhau = @MatKhau 
                AND A.MaTK = NV.MaTK)

	--Test 
	WAITFOR DELAY '0:0:5'

	--kiểm tra tài khoản có tồn tại hay không
	IF (@MaTK = 'NULL')
	BEGIN
		PRINT N'Tai khoan khong ton tai'
		ROLLBACK TRAN
		RETURN 0
	END	

	-- xử lí lấy thông tin
	SELECT A.TenDangNhap, A.MatKhau, NV.TenNV, NV.DiaChi, NV.SDT, NV.Email, A.MaTK          
                FROM TaiKhoan A, NhanVien NV 
                WHERE A.TenDangNhap = @TenDangNhap
                AND A.MatKhau = @MatKhau
                AND A.MaTK = NV.MaTK
	END TRY
	BEGIN CATCH
		PRINT N'Loi'
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO

-- XEM CHI TIET 1 MON AN HIEN TAI DANG CO BAN TRONG 1 CUA HANG
-- NEU MON AN KHONG BAN (HET HANG HOAC TAM NGUNG) THI KHONG XEM DUOC THONG TIN
CREATE PROC XemChiTiet_MonAn(@MaCH char(5), @MaMon CHAR(5))
AS
-- Thiet lap muc co lap Repeatable Read de ngan chan Unrepeatable Read
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * 
				FROM ThucDon
				WHERE MaMon = @MaMon AND MaCH = @MaCH)
			BEGIN
				PRINT N'Mon an khong ton tai'
				ROLLBACK TRAN
				RETURN 0
			END
		IF NOT EXISTS(SELECT * 
			FROM ThucDon
			WHERE MaMon = @MaMon AND MaCH = @MaCH and TinhTrang = N'Co ban')
		BEGIN
			PRINT N'Mon an hien tai khong ban'
			ROLLBACK TRAN
			RETURN 0
		END
		WAITFOR DELAY '00:00:05'
		SELECT TD.TenMon, TD.Gia, TD.MieuTaMon, TD.TinhTrang
		FROM ThucDon TD 
		WHERE TD.MaMon = @MaMon AND TD.MaCH = @MaCH and TinhTrang = N'Co ban'
	END TRY
	BEGIN CATCH
		PRINT N'Loi'
		ROLLBACK TRAN
		RETURN 0
	END CATCH
PRINT N'Xuat thuc don thanh cong'
COMMIT TRAN
RETURN 1
GO

-- Cap nhat mon an trong thuc don 
CREATE PROC CapNhat_ThucDon(@MaMon CHAR(5), @Gia INT, @TinhTrang NVARCHAR(30))
AS
BEGIN TRAN
	BEGIN TRY
		-- Kiem tra mon an ton tai
		IF NOT EXISTS(SELECT * 
				FROM ThucDon
				WHERE MaMon= @MaMon)
			BEGIN
				PRINT N'Mon an nay khong ton tai trong thuc don'
				ROLLBACK TRAN
				RETURN 0
			END
		-- Kiem tra thong tin co bi trung hay khong
		IF EXISTS(SELECT * 
				FROM ThucDon
				WHERE MaMon = @MaMon AND Gia = @Gia AND TinhTrang = @TinhTrang)
			BEGIN
				PRINT N'Thong tin moi phai khac so voi ban dau'
				ROLLBACK TRAN
				RETURN 0
			END
		-- Cap nhat thuc don
		UPDATE ThucDon
		SET Gia = @Gia, TinhTrang = @TinhTrang
		WHERE MaMon = @MaMon
	END TRY
	BEGIN CATCH
		PRINT N'Loi'
		ROLLBACK TRAN
		RETURN 0
	END CATCH
PRINT N'Cap nhat mon an thanh cong'
COMMIT TRAN
RETURN 1
GO

-PROCEDURE DOI TAC THEM MON VAO THUC DON
CREATE PROC sp_DT_ThemMonVaoThucDon
	@MaMon char(5),
	@TenMon nvarchar(80),
	@MaCH char(5),
	@MieuTaMon nvarchar(100),
	@Gia int,
	@TinhTrang nvarchar(30)
as
begin transaction
	begin try
		--Kiem tra thong tin co rong hay khong
		if @MaMon is not null and @TenMon is not null and @MaCH is not null and @Gia is not null
		begin
			--Kiem tra ma cua hang
			if exists(select * from ThucDon td where td.MaCH != @MaCH)
			begin
				PRINT 'Ma cua hang khong ton tai'
				rollback transaction
				return 0
			end
			
			--Kiem tra ma mon co bi trung hay khong
			if exists(select * from ThucDon td where td.MaMon = @MaMon)
			begin
				PRINT 'Ma mon da ton tai'
				rollback transaction
				return 0
			end
			
			--Kiem tra gia co hop le khong
			if @Gia <= 0
			begin
				PRINT 'Gia cua mon an phai > 0'
				rollback transaction
				return 0
			end
			
			--Kiem tra TinhTrang co hop le khong
			if @TinhTrang NOT IN ('Co ban', 'Het hang', 'Tam ngung')
			begin
				PRINT 'Tinh trang mon khong hop le'
				rollback transaction
				return 0
			end


			INSERT INTO ThucDon
			VALUES(@MaMon, @TenMon, @MaCH, @MieuTaMon, @Gia, @TinhTrang)
			print 'Them thuc don thanh cong'
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return 0
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
		return 0
	end catch
commit transaction
return 1
go


--PROCEDURE khach hang xem thuc don cua cua hang
CREATE PROC sp_KH_XemDSThucDon
	@MaCH char(5)
as 
SET TRAN ISOLATION LEVEL SERIALIZABLE
begin transaction
	BEGIN TRY
		--Kiem tra thong tin co rong hay khong
		if @MaCH is not null
		begin
			--Kiem tra ma cua hang
			if exists(select * from ThucDon td where td.MaCH != @MaCH)
			begin
				PRINT 'Ma cua hang khong ton tai'
				rollback transaction
				return 0
			end

			SELECT MaMon, TenMon, MaCH, MieuTaMon, Gia, TinhTrang FROM ThucDon td where td.MaCH = @MaCH
		end
		WAITFOR DELAY '0:0:30'
	end try
	begin catch
		print 'Loi'
		rollback transaction
		RETURN 0
	end catch
commit transaction
return 1
GO

--PROCEDURE DOI TAC THEM MON VAO THUC DON
CREATE PROC sp_DT_LapHopDong
	@MaHopDong char(5),
	@MaSoThue char(10),
	@NgDaiDien char(5),
	@TGBatDau datetime, 
	@TGKetThuc datetime,
	@SoTK varchar(20),
	@NganHang nvarchar(50),
	@ChiNhanhNH nvarchar(50),
	@PhiKichHoat int,
	@PhiHoaHong int
as
begin transaction
	begin try
		if @MaHopDong is not null and  @MaSoThue is not null and @NgDaiDien is not null
		--- and not @TGBatDau = '' and not @TGKetThuc = '' and @SoTK is not null and not @NganHang = '' and not @ChiNhanhNH = '' and not @PhiKichHoat = '' and not @PhiHoaHong = ''
		begin
			if exists (select *  from HopDong hd where hd.MaHopDong = @MaHopDong)
			begin
				print 'Ma hop dong da ton tai'
				rollback transaction
				return 0
			end
			if not exists (select * from ThongTinDaiDien dd where dd.MaNgDaiDien = @NgDaiDien)
			begin
				PRINT 'Ng dai dien ' + @NgDaiDien + ' khong ton tai'
				rollback transaction
				return 0
			end
			if @TGBatDau > @TGKetThuc
			begin
				PRINT 'Thoi gian khong hop le'
				rollback transaction
				return 0
			end
			if @PhiKichHoat < 1000000
			begin
				print 'Phi kick hoat khong hop le'
				rollback transaction
				return 0
			end
			begin
				PRINT 'Thoi gian khong hop le'
				rollback transaction
				return 0
			end
			insert into HopDong
			values(@MaHopDong, @MaSoThue, @NgDaiDien, @TGBatDau, @TGKetThuc, @SoTK, @NganHang, @ChiNhanhNH, @PhiKichHoat, @PhiHoaHong)
			print 'Tao hop dong thanh cong !!!'
		end
		else
		begin
			PRINT 'Thong tin khong duoc rong'
			rollback transaction
			return 0
		end
	end try
	begin catch
		print 'Loi'
		rollback transaction
		return 0
	end catch
commit transaction
return 1
go

--PROCEDURE nhan vien xem thuc don cua cua hang
CREATE PROC sp_NV_XemDSHopDong
as 
SET TRAN ISOLATION LEVEL SERIALIZABLE
begin transaction
	BEGIN TRY
		--Kiem tra danh sach hop dong khac rong
		if not exists(select * from HopDong)
		begin
			PRINT 'Khong co hop dong trong danh sachi'
			rollback transaction
			return 0
		end

		SELECT * FROM HopDong 
		WAITFOR DELAY '0:0:30'
	end try
	begin catch
		print 'Loi'
		rollback transaction
		RETURN 0
	end catch
commit transaction
return 1
GO