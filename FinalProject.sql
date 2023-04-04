create database FinalProject
use FinalProject

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

create table MenuDataTable
(
	dishID varchar(8) not null,
	dishPicture varchar(100) not null,
    dishName nvarchar(50) not null,
    dishDescription nvarchar(500) not null,
    dishQuantity int not null default 0,
    primary key(dishID)
)

create procedure ProcMenuData
	@dishPicture varchar(100),
    @dishName nvarchar(50),
    @dishDescription nvarchar(500),
    @dishQuantity int
as
begin
    declare @dishID varchar(8) = '';
    declare @alphabet varchar(62) = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
	
    while len(@dishID) < 8
    begin
        set @dishID = @dishID + substring(@alphabet, cast(rand() * len(@alphabet) as int), 1);
		if (select count(*) from MenuDataTable where dishID = @dishID) != 0
			set @dishID = '';
    end;

    insert into MenuDataTable
    values (@dishID, @dishPicture, @dishName, @dishDescription, @dishQuantity);
end;

exec ProcMenuData 'https://cf.shopee.vn/file/d81610a333292a3fef2096c52e67d57a', N'Gà chiên nước mắm', N'Sự giòn từ gà chiên kết hợp vị nước mắm mặn ngọt', 10

select * from MenuDataTable

exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/Wed(R).jpg?v=46kppg', N'Khoai Tây Múi Cau', N'Khoai tây chiên cắt múi cau đậm vị', 99
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/2-lava-taro.jpg?v=46kppg', N'Viên Khoai Môn Kim Sa', N'Viên khoai môn chiên giòn nhân phô mai', 15
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/2-Hash-Browns.jpg?v=46kppg', N'Bánh Khoai Tây Chiên', N'Khoai tây chiên bánh tròn', 10
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/D1-new.jpg?v=46kppg', N'Comnbo Đùi Gà Rán', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 20
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/D3-new.jpg?v=46kppg', N'Combo Mỳ ý', N'Combo kết hợp 1 mì ý + 2 bánh khoai tây + 1 pepsi ', 10
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Hash-Browns-C.jpg?v=46kppg', N'Combo Hash Browns', N'Combo kết hợp 2 bánh khoai tây + 2 miếng gà rán + 1 pepsi', 14
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/1-Fried-Chicken.jpg?v=46kppg', N'1 Miếng Gà Rán Viên', N'Viên gà rán tròn không cay', 20
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/2-Fried-Chicken.jpg?v=46kppg', N'2 Miếng Gà Rán Đùi', N'Combo 2 đùi gà chiên giòn truyền thống', 30
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/3-Fried-Chicken.jpg?v=46kppg', N'3 Miếng Gà Rán Đùi', N'Combo 3 đùi gà chiên giòn truyền thống', 15
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/6-Fried-Chicken-new.jpg?v=46kppg', N'6 Miếng Gà Rán Đùi', N'Combo 6 đùi gà chiên giòn truyền thống', 37
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/BJ.jpg?v=46kppg', N'1 Miếng Đùi Gà Quay', N'Đùi gà quay giấy bạc ngọt nước', 27
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/MOD-PHI-LE-GA-QUAY.jpg?v=46kppg', N'1 Miếng Phi-lê Gà Quay', N'Phi-lê gà quay giấy bạc ngọt nước', 36
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/3-HW.jpg?v=46kppg', N'3 Cánh Gà Hot Wings', N'3 Cảnh gà chiên giòn', 69
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/5-HW.jpg?v=46kppg', N'5 Cánh Gà Hot Wings', N'5 Cánh gà chiên giòn', 50
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/3_Nuggests.jpg?v=46kppg', N'3 Miếng Gà Nuggets', N'3 Gà Miếng Nuggets', 213
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Burger-Zinger.jpg?v=46kppg', N'Burger Zinger', N'Burger kim chi kẹp miếng gà Zinger ', 10
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Burger-Shrimp.jpg?v=46kppg', N'Burger Tôm', N'Burger kẹp tôm', 20
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Burger-Flava.jpg?v=46kppg', N'Burger Gà Quay Flava', N'Burger kẹp miếng gà Flava', 15
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/SALAD-HAT-GA-VIEN.jpg?v=46kppg', N'Salad Pop', N'Salad kèm hạt gà viên popcorn', 30
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/SALAD-HAT.jpg?v=46kppg', N'Salad Hạt', N'Salad cà chua hạt bắp, điều, đậu phồng', 26
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/6-Chewy-Cheese.jpg?v=46kppg', N'6 Phô Mai Viên', N'6 Viên chiên giòn nhân phô mai', 123
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/3-Mashies-Vegie.jpg?v=46kppg', N'3 Mashies Nhân Rau Củ', N'3 Viên chiên mashies nhân rau củ', 14
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Pepsi-Can.jpg?v=46kppg', N'Pepsi Lon', N'1 Phép', 123
exec ProcMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/7Up-Can.jpg?v=46kppg', N'7Up Lon', N'Pepsi Black Lime Lon', 110