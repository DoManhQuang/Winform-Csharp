Create database Ailatrieuphu
on primary ( name = 'Ailatrieuphu_dat' , filename = 'G:\Project Winforms\BTL Winform\SQL Ailatrieuphu\Ailatrieuphu_dat.mdf', size = 5mb , maxsize = 20 mb , filegrowth = 20% )
log on ( name = 'Ailatrieuphu_log' , filename = 'G:\Project Winforms\BTL Winform\SQL Ailatrieuphu\Ailatrieuphu_dat.ldf', size = 1mb , maxsize = 10 mb , filegrowth = 20% )
go
use Ailatrieuphu
go

create table tblTaikhoan
(
	MaTK varchar(10) primary key, 
	Taikhoan varchar(20) not null,
	Matkhau varchar(20) not null,
	TenNguoiDung nvarchar(30) not null,
	GioiTinh bit not null,
	Sodienthoai varchar(15) not null,
	Email varchar(30) not null,
	Trangthai bit not null, -- trạng thại đã kích hoạt hay chưa
	Chucnang int not null,
)
go
create table tblQuanlyvien
(
	MaQLV varchar(10) primary key,
	MaTK varchar(10)  not null,
	Chucvu varchar(20) not null,
	constraint FK_tblQLV foreign key (MaTK) references tblTaikhoan(MaTK)
	on update cascade on delete cascade
)
go

create table tblKyThuatVien
(
	MaKTV varchar(10) primary key,
	MaQLV varchar(10) not null,
	MaTK varchar(10)  not null,
	Vaitro  nvarchar(20) not null,
	constraint FK1_tblKTV foreign key (MaTK) references tblTaikhoan(MaTK)
	on update cascade on delete cascade,
	constraint FK2_tblKTV foreign key (MaQLV) references tblQuanlyvien(MaQLV)
)
go

create table tblNguoiChoi
(
	MaNC varchar(10) primary key,
	MaTK varchar(10)  not null,
	Tienthuong varchar(20) not null,
	LichSuchoi text not null, -- lưu các điểm số trong các lần chơi
	KQtotnhat int not null, -- điểm số lần tốt nhất
	constraint FK_tblNC foreign key (MaTK) references tblTaikhoan(MaTK)
	on update cascade on delete cascade,
)
go

create table tblCauhoi
(
	MaCH varchar(10) primary key,
	MaKTV varchar(10) not null,
	TenCH nvarchar(50) not null,
	Dapan nvarchar(100) not null, -- các đáp án của câu hỏi
	Dapandung nvarchar(20) not null, -- đáp án đúng
	Dokho int not null, -- độ khó của câu hỏi theo mức độ tăng dần là 1 - 2 -3
	Trogiupxoa nvarchar(70) not null, -- trợ giúp xóa đáp án sai 50:50
	Trogiuptuvan nvarchar(30) not null, -- trợ giúp của chuyên gia tư vấn
	constraint FK_tblCauhoi foreign key (MaKTV) references tblKyThuatVien(MaKTV)
	on update cascade on delete cascade,
)
go

insert into tblTaikhoan values ('TK001','Quang','1412',N'Mạnh Quang',1,'0888888','Quang@vns.com',1)
insert into tblNguoiChoi values('NC001','TK001','100000','5 10 9 11','11')


select Taikhoan , Matkhau , TenNguoiDung , GioiTinh, Sodienthoai, Email , Tienthuong from tblTaikhoan inner join tblNguoiChoi on tblTaikhoan.MaTK = tblNguoiChoi.MaTK where tblTaikhoan.MaTK = 'TK001'

select Count(Trangthai) from tblTaikhoan where Taikhoan = 'Quang' and Matkhau = '1412'