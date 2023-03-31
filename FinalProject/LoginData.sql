create database LoginData 
use LoginData

create table LoginDataTable
(
    userID varchar(8) not null,
    fullName nvarchar(25) not null,
    emailAddress varchar(40) not null,
    contactAddress nvarchar(150) not null,
    userName varchar(15) not null unique,
    userPassword varchar(32) not null,
    primary key(userID)
)

create procedure ProcUserData
    @fullName nvarchar(25),
    @emailAddress varchar(40),
    @contactAddress nvarchar(150),
    @userName varchar(15),
    @userPassword varchar(32)
as
begin
    declare @userID varchar(8) = '';
    declare @alphabet varchar(62) = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
	
    while len(@userID) < 8
    begin
        set @userID = @userID + substring(@alphabet, cast(rand() * len(@alphabet) as int), 1);
		if (select count(*) from LoginDataTable where userID = @userID) != 0
			set @userID = '';
    end;

    insert into LoginDataTable(userID, fullName, emailAddress, contactAddress, userName, userPassword)
    values (@userID, @fullName, @emailAddress, @contactAddress, @userName, @userPassword);
end;

exec ProcUserData N'Nguyễn Thành Nhật Tân', 'nguyennthanhhnhatttann@gmail.com', N'Hồ Chí Minh', 'nguyenthanhnhattan', 'nguyennthanhhnhatttann'
exec ProcUserData N'Vương Thanh Huy', 'vuonggthanhhhuyy@gmail.com', N'Trà Vinh', 'vuongthanhhuy', 'vuonggthanhhhuyy'

select * from LoginDataTable

Create table Cities(
    ID int IDENTITY primary key,
    provinceName Nvarchar(50) unique
)

insert into Cities(provinceName) values
(N'(Contact address)'),
(N'An Giang'),
(N'Bà Rịa-Vũng Tàu'),
(N'Bạc Liêu'),
(N'Bắc Kạn'),
(N'Bắc Giang'),
(N'Bắc Ninh'),
(N'Bến Tre'),
(N'Bình Dương'),
(N'Bình Định'),
(N'Bình Phước'),
(N'Bình Thuận'),
(N'Cà Mau'),
(N'Cao Bằng'),
(N'Cần Thơ'),
(N'Đà Nẵng'),
(N'Đắk Lắk'),
(N'Đắk Nông'),
(N'Điện Biên'),
(N'Đồng Nai'),
(N'Đồng Tháp'),
(N'Gia Lai'),
(N'Hà Giang'),
(N'Hà Nam'),
(N'Hà Nội'),
(N'Hà Tây'),
(N'Hà Tĩnh'),
(N'Hải Dương'),
(N'Hải Phòng'),
(N'Hòa Bình'),
(N'Hồ Chí Minh'),
(N'Hậu Giang'),
(N'Hưng Yên'),
(N'Khánh Hòa'),
(N'Kiên Giang'),
(N'Kon Tum'),
(N'Lai Châu'),
(N'Lào Cai'),
(N'Lạng Sơn'),
(N'Lâm Đồng'),
(N'Long An'),
(N'Nam Định'),
(N'Nghệ An'),
(N'Ninh Bình'),
(N'Ninh Thuận'),
(N'Phú Thọ'),
(N'Phú Yên'),
(N'Quảng Bình'),
(N'Quảng Nam'),
(N'Quảng Ngãi'),
(N'Quảng Ninh'),
(N'Quảng Trị'),
(N'Sóc Trăng'),
(N'Sơn La'),
(N'Tây Ninh'),
(N'Thái Bình'),
(N'Thái Nguyên'),
(N'Thanh Hóa'),
(N'Thừa Thiên – Huế'),
(N'Tiền Giang'),
(N'Trà Vinh'),
(N'Tuyên Quang'),
(N'Vĩnh Long'),
(N'Vĩnh Phúc'),
(N'Yên Bái') 

select * from Cities