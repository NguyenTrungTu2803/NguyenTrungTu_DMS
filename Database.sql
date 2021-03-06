Create database DMS
go
use DMS
go

Create table NHANVIEN
(
  maNV int primary key not null,
  hoten varchar(100),
  matkhau varchar(100),
  email varchar(100),
  dienthoai varchar(50),
)
go

Create table PHONGBAN
(
	maphongban int primary key not null,
	tenphongban varchar(100)
)
go

Create table PHANQUYEN
(
	maquyen int primary key not null,
	manhanvien int,
	maphongban int,
	xem bit,
	sua bit,
	xoa bit,
	inan bit,
	export bit,
	import bit,
	Constraint fk_PQ_NV foreign key(manhanvien) references NHANVIEN(maNV)  ,
	Constraint fk_PQ_PB foreign key (maphongban) references PHONGBAN(maphongban)
)
go

Create table VANBANDI
(
	id_vanbandi int primary key not null,
	kyhieuvanban varchar(50),
	ngaybanhanh date,
	loaivanban varchar(50),
	trichyeu varchar(250),
	sovanban varchar(100),
	linhvuc varchar(50),
	dokhan varchar(50),
	soban varchar(10),
	sotrang varchar(10),
	filedinhkem varchar(250),
	nguoisoan varchar(100),
	nguoiky varchar(100),
	noinhan varchar(250),
	xuly Tinyint,
	quyenxem varchar(100),
	luu varchar(100),
	maNV int,
	constraint fk_VBDI_NV foreign key(maNV) references NHANVIEN(maNV)
)
GO
Create table VANBANDEN
(
	sovanbanden int primary key not null,
	kyhieuvanban varchar(50),
	ngayden date,
	ngaybanhanh date,
	coquan varchar(50),
	trichyeu varchar(250),
	linhvuc varchar(50),
	loaivanban varchar(50),
	dokhan varchar(50),
	domat varchar(50),
	filedinhkem varchar(250),
	xuly Tinyint,
	quyenxem varchar(100),
	lanhdaophancong varchar(50),
	ykienchidao text,
	ngaythuchien date,
	phongbanxulychinh varchar(100),
	phongbanphoihop varchar(100),
	hanxuly date,
	ngayxuly date,
	nguoixuly varchar(50),
	sovanbannam varchar(100),
	sotrang varchar(10),
	maNV int,
	constraint fk_VBD_NV foreign key(maNV) references NHANVIEN(maNV)
)
go
Create Table DANHMUC
(
	maDM int primary key not null,
	tendanhmuc varchar(255),
	loaidanhmuc int,
	trangthaidanhmuc tinyint,
	idvanbandi int,
	idvanbanden int,				
	constraint fk_DM_VBD foreign key(idvanbanden) references VANBANDEN(sovanbanden),
	constraint fk_DM_VBDI foreign key(idvanbandi) references VANBANDI(id_vanbandi)

)
go

Create table HOSO
(
	id_hoso int primary key not null,
	mahoso varchar(20),
	tieudehoso varchar(100),
	nguoilaphoso varchar(50),
	ngaybatdau date,
	ngayketthuc date,
	soto varchar(20),
	loaivanbandenhaydi Tinyint
)
go
create table  CHITIETHOSO
(
	id int primary key not null,
	idhoso int,
	maNV int,
	ngaybanhanh date,
	sokyhieuvanban varchar(20),
	trichyeuvanban varchar(250),
	loaivanbandenhaydi int,
	thutuvanban int,
	Constraint fk_CTHS_HS foreign key(idhoso) references HOSO(id_hoso), 
	Constraint fk_CTHS_NV foreign key(maNV) references NHANVIEN(maNV)
)
go



