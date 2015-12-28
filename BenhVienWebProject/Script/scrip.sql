
--drop database DangKyKhamBenhOnline
create database DangKyKhamBenhOnline
on primary
(
	name=dulieu,
	filename='d:\DangKyKhamBenhOnline.mdf',
	size=10,
	filegrowth=1
)
log on
(
	name=Logfile,
	filename='d:\DangKyKhamBenhOnline_log.mdf',
	size=1,
	maxsize=10,filegrowth=1
)
go 
use DangKyKhamBenhOnline

create table Khoa
(
	Ma int primary key identity(1,1) not null,
	Ten nvarchar(20) not null
)
create table TaiKhoan
(
	Ma int primary key identity(1,1) not null,
	Ten nvarchar(20) not null,
	MatKhau nvarchar(20),
	Loai nvarchar(10)
)

create table BacSi
(

	Ma int primary key identity(1,1) not null,
	Ten nvarchar(20) not null,
	NgaySinh datetime ,
	DiaChi nvarchar(20),
	MaKhoa int not null references Khoa(Ma),
	MaTaiKhoan int not null references TaiKhoan(Ma)

)

create table LichTruc
(

	MaBacSi int references BacSi(Ma) not null,
	Ngay datetime ,
	GioBatDau varchar(10),
	GioKetThuc varchar(10),
	Phong nvarchar(10)
	primary key (MaBacSi,Ngay,GioBatDau)
)
create table BenhNhan
(

	Ma int primary key identity(1,1) not null,
	Ten nvarchar(20) not null,
	NgaySinh datetime ,
	DiaChi nvarchar(20),
	Phai nvarchar(20)
	
)

create table PhieuDangKy
(

	Ma int primary key identity(1,1) not null,
	Ngay datetime ,
	TrieuChung nvarchar(100),
	MaBenhNhan int not null references BenhNhan(Ma) 

)

create table ThamSo
(

	Ma int primary key identity(1,1) not null,
	MoTa nvarchar(100),
	GiaTri int  

)
create table NguoiLon
(

	MaBenhNhan int not null references BenhNhan (Ma),
	Email nvarchar(100),
	DienThoai int,
	MaTaiKhoan int not null references TaiKhoan(Ma)
	primary key (MaBenhNhan)

)

create table TreEm
(
	MaBenhNhan int not null references BenhNhan (Ma),
	MaNguoiLon int not null references NguoiLon (MaBenhNhan)
	primary key (MaBenhNhan,MaNguoiLon)
)





insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Ngoc Thanh','2-2-1985','Da Nang', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Pham Kim Lien','6-10-2000','Binh Duong', 'Nu')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Tran Minh','1-3-1981','TP HCM', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Giang Le Thu','7-7-2001','TP HCM', 'Nu')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Tran Van Long','3-6-1978','Binh Duong', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Thi Thuy','5-2-2002','Dong Nai', 'Nu')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Ngoc Thuc','2-3-1985','Long An', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Pham Ngoc Lan','6-3-2003','Binh Duong', 'Nu')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Van Han','1-4-1981','TP HCM', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Le Thi My Loan','5-7-2002','TP HCM', 'Nu')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Tran Van Linh','3-11-1978','Binh Duong', 'Nam')
insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai) values(N'Nguyen Thi Lai','5-12-2000','Dong Nai', 'Nu')



insert into Khoa(Ten) values (N'Than Kinh')
insert into Khoa(Ten) values (N'Tim Mach')
insert into Khoa(Ten) values (N'Nhi')
insert into Khoa(Ten) values (N'Cap Cuu')
insert into Khoa(Ten) values (N'San')
insert into Khoa(Ten) values (N'Ngoai')
insert into Khoa(Ten) values (N'Noi')

insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Ngoc Son','Thanh','Bac si')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Ngoc Yen','Thanh','Bac si')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Van Dong','Thanh','Bac si')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Tran Ngoc Thao','Thanh','Bac si')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Minh Tuan','Thanh','Bac si')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Ngoc Thanh','Thanh','Benh nhan')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Pham Kim Lien','Lien','Benh nhan')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Tran Minh','Thanh','Banh nhan')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Giang Le Thu','Thanh','Benh nhan')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Tran Van long','Thanh','Benh nhan')
insert into TaiKhoan(Ten, MatKhau, Loai) values (N'Nguyen Thi Thuy','Thanh','Benh nhan')

insert into ThamSo(MoTa, GiaTRi) values (N'So luong dang ky toi da',100)
insert into ThamSo(MoTa, GiaTRi) values (N'So Luong dang ky tai kham toi da',50)

insert into BacSi(MaTaiKhoan, Ten, NgaySinh, DiaChi, MaKhoa) values (1, 'Nguyen Ngoc Son','5-10-1984', '160 Tran Hung Dao Q1',2)
insert into BacSi(MaTaiKhoan, Ten, NgaySinh, DiaChi, MaKhoa) values (2, 'Nguyen Ngoc Yen','12-10-1985', '215 Nguyen Van Cu Q5',1)
insert into BacSi(MaTaiKhoan, Ten, NgaySinh, DiaChi, MaKhoa) values (3, 'Nguyen Van Dong','1-1-1980', '112 Nguyen Trai Q1',2)
insert into BacSi(MaTaiKhoan, Ten, NgaySinh, DiaChi, MaKhoa) values (4, 'Tran Ngoc Thao','6-6-1981', '120 An Dung Vuong Q5',3)
insert into BacSi(MaTaiKhoan, Ten, NgaySinh, DiaChi, MaKhoa) values (5, 'Nguyen Minh Tuan','4-5-1984', '168 Tran Hung Dao Q1',4)

insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-6-2008','7h30','11h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-6-2008','7h30','11h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-6-2008','7h30','11h30','A12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-6-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-6-2008','13h30','16h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-7-2008','7h30','11h30','B10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-7-2008','7h30','11h30','B11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-7-2008','7h30','11h30','B12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-7-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-7-2008','13h30','16h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-8-2008','7h30','11h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-8-2008','7h30','11h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-8-2008','7h30','11h30','A12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-8-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-8-2008','13h30','16h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-9-2008','7h30','11h30','B10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-9-2008','7h30','11h30','B11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-9-2008','7h30','11h30','B12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-9-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-9-2008','13h30','16h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-10-2008','7h30','11h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-10-2008','7h30','11h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-10-2008','7h30','11h30','A12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-10-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-10-2008','13h30','16h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (5,'7-11-2008','7h30','11h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (4,'7-11-2008','7h30','11h30','A11')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (3,'7-11-2008','7h30','11h30','A12')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (2,'7-11-2008','13h30','16h30','A10')
insert into LichTruc(MaBacSi, Ngay, GioBatDau, GioKetThuc,Phong) values (1,'7-11-2008','13h30','16h30','A11')

insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-5-2008','Dau bung',1)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-5-2008','Kho tho',5)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-4-2008','Sot',3)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-4-2008','Dau lung',7)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-2-2008','Moi mat',5)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-3-2008','Viem xoang',9)
insert into PhieuDangKy(Ngay, TrieuChung, MaBenhNhan) values ('7-1-2008','Dau bao tu',1)

insert into NguoiLon(MaBenhNhan, MaTaiKhoan,Email,DienThoai) values (1,1,'hoalan@yahoo.com',0985176662)
insert into NguoiLon(MaBenhNhan, MaTaiKhoan,Email,DienThoai) values (3,3,'hoahong@yahoo.com',0972418636)
insert into NguoiLon(MaBenhNhan, MaTaiKhoan,Email,DienThoai) values (5,2,'hoamai@yahoo.com',0983179991)
insert into NguoiLon(MaBenhNhan, MaTaiKhoan,Email,DienThoai) values (7,4,'hoahue@yahoo.com',0982156362)
insert into NguoiLon(MaBenhNhan, MaTaiKhoan,Email,DienThoai) values (9,6,'hoamuoigio@yahoo.com',0955123456)


insert into TreEm(MaBenhNhan, MaNguoiLon) values (2,1)
insert into TreEm(MaBenhNhan, MaNguoiLon) values (4,3)
insert into TreEm(MaBenhNhan, MaNguoiLon) values (6,5)
insert into TreEm(MaBenhNhan, MaNguoiLon) values (8,7)
insert into TreEm(MaBenhNhan, MaNguoiLon) values (10,9)

----store==========

----1--xem thong tin BS trong 1 khoa
----2--xem chi tiet thong tin ca nhan BS co ma
----3--them thong tin 1 benh nhan ng lon
----4--them thong tin benh nhan la tre em
----5--DS cac khoa trong benh vien
----6--DS cac benh nhan dang ky trong 1 ngay
----7--DS BS truc trong 1 ngay
----8--xem lich truc 1 BS
----9--them thong tin Phieu dang ky
----10--them thong tin tai khoan
----11--dem SL benh nhan dang ky trong 1 ngay
--12--xem lich truc giua 2 ngay

--------21-7







----5--DS cac khoa trong benh vien
go
--drop proc sp_DanhSachKhoa
create proc sp_DanhSachKhoa
as
begin
	select * from Khoa
end

exec sp_DanhSachKhoa
--roi
----1--xem thong tin BS trong 1 khoa
go
create proc sp_ThongTinBacSiTrongKhoa @MaKhoa int
as
begin
	select *
	from BacSi
	where MaKhoa=1@MaKhoa
end
exec sp_ThongTinBacSiTrongKhoa 1
--roi
----2--xem chi tiet thong tin ca nhan BS co ma
go
create proc sp_ThongTinBacSiCoMa @maBS int
as
begin
	select *
	from BacSi
	where Ma=@maBS

	
end
exec sp_ThongTinBacSiCoMa 1
--roi
---lay thong tin Khoa cua Khoa
---(co can lay thong tin TaiKhoan ?)
go
create proc sp_ThongTinKhoaCoMa @MaKhoa int
as
begin
	select *
	from Khoa
	where Ma=@MaKhoa

	
end
exec sp_ThongTinKhoaCoMa 1
--roi
----3--them thong tin 1 benh nhan ng lon
----them thong tin bang Benh Nhan
go
create proc sp_ThemThongTinBenhNhan @ten nvarchar(20), @ngaysinh datetime,
					 @diachi nvarchar(20), @phai nvarchar(20)

as
begin
	insert into BenhNhan(Ten,NgaySinh,DiaChi,Phai)
		values (@ten,@ngaysinh,@diachi,@phai)
end
--roi
exec sp_ThemThongTinBenhNhan N'Nguyen Thi Mai','5-12-1970','Lam Dong', 'Nu'

--chua--(co theo Ma?)
---lay thong tin Benh nhan moi them
go
create proc sp_ThongTinBenhNhan
as
begin
	select * from BenhNhan
end

exec sp_ThongTinBenhNhan
---them thong tin bang Nguoi Lon
go
create proc sp_ThemThongTinNguoiLon @maBN int, 
			@email nvarchar, @dienthoai int, @maTK int
as
begin
	insert into NguoiLon values (@maBN,@email,@dienthoai,@maTK)
end
--roi

----them thong tin tai khoan
---lay tai khoan theo ma
go
create proc sp_LayThongTinTK @MaTK int
as
begin
	select * from TaiKhoan where Ma=@MaTK
end
go
create proc sp_ThemTaiKhoan @ten nvarchar(20), @matkhau nvarchar(20), @loai nvarchar(20)
as
begin
	insert into TaiKhoan (Ten,MatKhau,Loai) values (@ten,@matkhau,@loai)
end
--roi


---lay Ma Tai Khoan moi them---chua

go
create proc sp_ThongTinTaiKhoan
as
begin
	select * from TaiKhoan
end

----4--them thong tin benh nhan la tre em
---lay thong tin Benh nhan
---lay thong tin nguoi lon co ma moi them
--chua
go
create proc sp_ThongTinNguoiLon
as
begin
	select * from NguoiLon
end

go
create proc sp_ThemTreEm @maBN int, @maNL int
as
begin
	insert into TreEm values (@maBN,@maNL) 
end
--roi

----6--DS cac benh nhan dang ky trong 1 ngay

---lay thong tin BN co Ma
go
create proc sp_ThongTinBenhNhanCoMa @maBN int
as
begin
	select *
	from BenhNhan
	where Ma=@maBN
end
--roi


go
create proc sp_DanhSachBenhNhanTheoNgay @ngay datetime
as
begin
	select *
	from PhieuDangKy
	where Ngay= '2008-07-05'@ngay
end
--roi

----7--DS BS truc trong 1 ngay
---lay ten BS co ma
go
create proc sp_ThongTinBS @ma int
as
begin
	select Ten
	from BacSi
	where ma= @ma
end

--roi
go
create proc sp_DanhSachBacSiTrucTrongNgay @ngay datetime
as
begin
	select *
	from LichTruc
	where Ngay= @ngay
end
exec sp_DanhSachBacSiTrucTrongNgay '7-6-2008'
--roi

----8--xem lich truc 1 BS trong ngay 
go
create proc sp_LichTrucBacSi @maBS int, @ngay datetime
as
begin
	select *
	from LichTruc
	where MaBacSi=@maBS and Ngay=@ngay
end
exec sp_LichTrucBacSi 1, '7-6-2008'
--roi


----9--them thong tin Phieu dang ky
go
create proc sp_ThemPhieuDangKy @ngay datetime, @trieuchung nvarchar(100), @maBN int
as
begin
	insert into PhieuDangKy (Ngay, TrieuChung, MaBenhNhan) values (@ngay,@trieuchung,@maBN)
end
--roi

--chua----11--dem SL benh nhan dang ky trong 1 ngay
go
create proc sp_DemSLBenhNhanDKTrongNgay @ngay datetime
as
begin
	select count(*) as SoLuong
	from PhieuDangKy
	where Ngay = @ngay
	
end


exec sp_DemSLBenhNhanDKTrongNgay '7-4-2008'





--11--xem lich truc giua 2 ngay
go
create proc sp_XemLichTrucGiua2Ngay @ngayBD datetime, @ngayKT datetime
as
begin
	select * 
	from LichTruc
	where Ngay between @ngayBD and @ngayKT
end

exec sp_XemLichTrucGiua2Ngay '2008-07-06','2008-07-15'



