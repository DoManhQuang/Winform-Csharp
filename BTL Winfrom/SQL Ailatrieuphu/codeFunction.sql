create function DemSoLuongMaTK(@Taikhoan varchar(30) , @Matkhau varchar(30))
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

alter proc TaoTaiKhoanMoi(@MaTK varchar(10) , @Taikhoan varchar(20) , @Matkhau varchar(20) , @TenND nvarchar(30) , @Gioitinh bit , @Sdt varchar(15) , @Email varchar(30), @Trangthai bit)
as
begin
	insert into tblTaikhoan values (@MaTK , @Taikhoan , @Matkhau , @TenND , @Gioitinh , @Sdt , @Email , @Trangthai)
end

EXEC TaoTaiKhoanMoi 'TK008','Long1','1412','Duy Long','1','0999999','Long@123','1'

select * from tblTaikhoan

Alter Function ThongTinNguoiDung(@Taikhoan varchar(10))
returns @BangTT table
(
	Taikhoan varchar(20),
	Matkhau varchar(20),
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

create proc CapNhapThongTin(@MaTK varchar(10) , @Taikhoan varchar(20) , @Matkhau varchar(20) , @TenND nvarchar(30) , @Gioitinh bit , @Sdt varchar(15) , @Email varchar(30))
as
begin
	Update tblTaikhoan set Taikhoan = @Taikhoan , Matkhau = @Matkhau , TenNguoiDung = @TenND , GioiTinh = @Gioitinh , 
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