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
	Ten nvarchar(50) not null,
	NgaySinh datetime ,
	DiaChi nvarchar(50),
	Phai nvarchar(10)
	
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


