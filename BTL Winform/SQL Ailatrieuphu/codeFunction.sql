use Ailatrieuphu
go

alter function DemSoLuongMaTK(@Taikhoan varchar(30) , @Matkhau varchar(50))
returns int
as 
	begin
		declare @Count int
			select  @Count = Count(MaTK)
			from tblTaikhoan 
			where Taikhoan = @Taikhoan and Matkhau = @Matkhau
		return @Count
	end
go
select dbo.DemSoLuongMaTK('Quang','1412')
create function DemSoLuongTaiKhoan(@Taikhoan varchar(20))
returns int
as 
	begin
		declare @Count int
			select  @Count = Count(Taikhoan) from tblTaikhoan where Taikhoan = @Taikhoan
		return @Count
	end
go

select dbo.DemSoLuongTaiKhoan('Quang')

alter proc TaoTaiKhoanMoi(@MaTK varchar(10) , @Taikhoan varchar(20) , @Matkhau varchar(50) , @TenND nvarchar(30) , @Gioitinh bit , @Sdt varchar(15) , @Email varchar(30), @Trangthai bit , @Chunang int)
as
begin
	insert into tblTaikhoan values (@MaTK , @Taikhoan , @Matkhau , @TenND , @Gioitinh , @Sdt , @Email , @Trangthai , @Chunang)
end


Alter Function ThongTinNguoiDung(@Taikhoan varchar(10))
returns @BangTT table
(
	Taikhoan varchar(20),
	Matkhau varchar(50),
	TenNguoiDung nvarchar(30),
	GioiTinh bit ,
	Sodienthoai varchar(15),
	Email varchar(30),
	Tienthuong varchar(20),
	TrangThai bit
)
as
begin
	insert into @BangTT
	select Taikhoan , Matkhau , TenNguoiDung , GioiTinh, Sodienthoai, Email , Tienthuong , Trangthai
	from tblTaikhoan inner join tblNguoiChoi on tblTaikhoan.MaTK = tblNguoiChoi.MaTK
	where tblTaikhoan.Taikhoan = @Taikhoan
	return
end

select * from ThongTinNguoiDung('TK001')

select * from tblTaikhoan
delete tblTaikhoan where MaTK = 'TK009'

Alter proc CapNhapThongTin(@MaTK varchar(10) , @Taikhoan varchar(20) , @Matkhau varchar(50) , @TenND nvarchar(30) , @Gioitinh bit , @Sdt varchar(15) , @Email varchar(30))
as
begin
	declare @MatkhauMD5	varchar(50)
	Update tblTaikhoan set Taikhoan = @Taikhoan , @MatkhauMD5 = CONVERT(varchar(50), HashBytes('MD5', @Matkhau),2) , TenNguoiDung = @TenND , GioiTinh = @Gioitinh , 
	Sodienthoai = @Sdt ,Email = @Email where MaTK = @MaTK
end

-- EXEC CapNhapThongTin ma , tk , mk , ten , gt , sdt , email
create function LayMaTaiKhoan(@TenTK varchar(20))
returns varchar(10)
as
begin
	declare @MaTK varchar(10)
	select @MaTK = MaTK from tblTaikhoan where Taikhoan = @TenTK
	return @MaTK
end

select dbo.LayMaTaiKhoan('Quang')

insert into tblNguoiChoi values ('NC002','TK002','1000','10 15 5 3 6','15')
insert into tblNguoiChoi values ('NC003','TK003','1000','10 15 5 3 6','15')

select * from tblTaikhoan
select * from tblNguoiChoi
select tblNguoiChoi.LichSuchoi 
from tblNguoiChoi inner join tblTaikhoan on tblNguoiChoi.MaTK = tblTaikhoan.MaTK
where tblTaikhoan.MaTK = 'TK001'

alter function ChucNangNguoiDung(@Taikhoan varchar(50) , @Matkhau varchar(50))
returns int 
as
	begin
		declare @Number int
		--declare @Count int
		select @Number = Chucnang from tblTaikhoan where Taikhoan = @Taikhoan and Matkhau = @Matkhau
		return @Number
	end

select dbo.ChucNangNguoiDung('Quangabc','1412')

--EXEC TaoTaiKhoanMoi 'TK003','kid','1234',N'kaito kid','1','09999','kid@gmail.com','0','0'

Update tblCauhoi set TenCH = 'What is Dog ?', Dokho = 1 where MaCH = 'CH00100'
select * from tblTaikhoan
insert into tblQuanlyvien values ('QLV001','TK002','CEO')
insert into tblKyThuatVien values ('KTV001','QLV001','TK003','Dev')

insert into tblCauhoi values ('CH00100','KTV001','What is Dog 1',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH00101','KTV001','What is Dog 2',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH00102','KTV001','What is Dog 3',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH00103','KTV001','What is Dog 4',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH00104','KTV001','What is Dog 5',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')

insert into tblCauhoi values ('CH00105','KTV001','What is Dog 6',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH00106','KTV001','What is Dog 7',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH00107','KTV001','What is Dog 8',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH00108','KTV001','What is Dog 9',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH00109','KTV001','What is Dog 10',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')

insert into tblCauhoi values ('CH0010010','KTV001','What is Dog 11',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')
insert into tblCauhoi values ('CH0010011','KTV001','What is Dog 12',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')
insert into tblCauhoi values ('CH0010012','KTV001','What is Dog 13',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')
insert into tblCauhoi values ('CH0010013','KTV001','What is Dog 14',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')
insert into tblCauhoi values ('CH0010014','KTV001','What is Dog 15',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')

insert into tblCauhoi values ('CH0010015','KTV001','What is Dog 16',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH0010016','KTV001','What is Dog 17',N'Chó Mèo Gà Vịt',N'A',1,'B C','A')
insert into tblCauhoi values ('CH0010017','KTV001','What is Dog 18',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH0010018','KTV001','What is Dog 19',N'Chó Mèo Gà Vịt',N'A',2,'B C','A')
insert into tblCauhoi values ('CH0010019','KTV001','What is Dog 20',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')
insert into tblCauhoi values ('CH0010020','KTV001','What is Dog 0',N'Chó Mèo Gà Vịt',N'A',3,'B C','A')

update tblCauhoi set Dapandung = 'A' , Trogiuptuvan = 'A B'
select * from tblTaikhoan
select * from tblQuanlyvien
select * from tblKyThuatVien
select * from tblNguoiChoi
select * from tblCauhoi

create function ThongTinCauHoi(@MaCH varchar(10))
returns @BangCH table
(
	TenCH varchar(50),
	Dapan nvarchar(100),
	Dapandung nvarchar(20),
	Trogiuptuvan nvarchar(20),
	Trogiupxoa nvarchar(20)
)
as
	begin
		insert into @BangCH
		select TenCH , Dapan , Dapandung , Trogiuptuvan , Trogiupxoa from tblCauhoi where MaCH = @MaCH
		return
	end
go
select * from dbo.ThongTinCauHoi('CH00100')

create view RanDomMaCauHoiDe
as
select top(5) MaCH from tblCauhoi where Dokho = '1' order by NEWID()
go
create view RanDomMaCauHoiVua
as
select top(5) MaCH from tblCauhoi where Dokho = '2' order by NEWID()
go
create view RanDomMaCauHoiKho
as
select top(5) MaCH from tblCauhoi where Dokho = '3' order by NEWID()
go

select * from RanDomMaCauHoiDe ; select * from RanDomMaCauHoiVua ; select * from RanDomMaCauHoiKho

alter proc CapNhapKetQuaChoiGame(@Taikhoan varchar(10), @Cauhoi varchar(50) , @tienThuong varchar(20))
as
begin
	declare @lichSu varchar(50)
	declare @Kqtot int
	declare @MaTK varchar(10)
	select @lichSu = LichSuchoi , @Kqtot = KQtotnhat, @MaTK = tblTaikhoan.MaTK from tblNguoiChoi inner join tblTaikhoan on tblTaikhoan.MaTK = tblNguoiChoi.MaTK where Taikhoan = @Taikhoan
	if(CAST(@Cauhoi AS INT) < @Kqtot)
		update tblNguoiChoi set Tienthuong = CAST((CAST(Tienthuong AS int) + CAST(@tienThuong AS int)) AS varchar(20)), 
		LichSuchoi = @lichSu + ' ' + @Cauhoi where MaTK = @MaTK
	else
		update tblNguoiChoi set Tienthuong = CAST((CAST(Tienthuong AS int) + CAST(@tienThuong AS int)) AS varchar(20)), 
		LichSuchoi = @lichSu + ' ' + @Cauhoi , KQtotnhat = @Cauhoi  where MaTK = @MaTK	
end

EXEC CapNhapKetQuaChoiGame 'Quang','15','150000'
select * from tblNguoiChoi

 