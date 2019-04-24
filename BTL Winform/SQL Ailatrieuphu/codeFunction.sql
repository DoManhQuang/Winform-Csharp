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

insert into tblCauhoi values ('CH00100','KTV001','What is Dog ?',N'Chó Mèo Gà Vịt',N'A',1,'B C','A D')

update tblCauhoi set Dapandung = 'A' , Trogiuptuvan = 'A B'
select * from tblTaikhoan
select * from tblQuanlyvien
select * from tblKyThuatVien
select * from tblNguoiChoi
select * from tblCauhoi

alter function ThongTinCauHoi(@MaCH varchar(10))
returns @BangCH table
(
	TenCH nvarchar(50),
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
select * from dbo.ThongTinCauHoi('CH003')

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
select * from tblCauhoi
select * from tblTaikhoan

update tblTaikhoan set MaTK = 'TK00300001' where MaTK = 'TK003'

insert into tblTaikhoan values ('TK00100002','quang1412','0E4E946668CF2AFC4299B462B812CACA','quang',1,'099999','kid@gmail',1,1)

create function MaxMaTKTheoChucNang(@Chucnang int)
returns varchar(10)
as
begin
	declare @MaTK varchar(10)
	select top 1 @MaTK = MaTK from tblTaikhoan where Chucnang = @Chucnang order by MaTK desc
	return @MaTK
end

select dbo.MaxMaTKTheoChucNang('1')



insert into tblTaikhoan values ('TK00200002','Nhan','1234','Nhan',0,'088888','Nhan@gamil.com',1,2)

select * from tblTaikhoan
select * from tblKyThuatVien
select * from tblQuanlyvien
select * from tblNguoiChoi
select * from tblCauhoi

create function LayMaKTV(@Taikhoan varchar(10))
returns varchar(10)
as
	begin
		declare @MaTK varchar(10)
		declare @MaKTV varchar(10)
		select @MaTK = MaTK from tblTaikhoan where Taikhoan = @Taikhoan
		select @MaKTV = MaKTV from tblKyThuatVien where MaTK = @MaTK
		return @MaKTV
	end

select dbo.LayMaKTV('Nhan')
update tblTaikhoan set Chucnang = 3 where MaTK = 'TK00200001'

create function LayMaQLV(@Taikhoan varchar(10))
returns varchar(10)
as
	begin
		declare @MaTK varchar(10)
		declare @MaQLV varchar(10)
		select @MaTK = MaTK from tblTaikhoan where Taikhoan = @Taikhoan
		select @MaQLV = MaQLV from tblQuanlyvien where MaTK = @MaTK
		return @MaQLV
	end
select dbo.LayMaQLV('Long')

--delete tblCauhoi where MaCH = 'CH038'