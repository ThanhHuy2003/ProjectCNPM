drop database if exists FinalProject
go
create database FinalProject
go
use FinalProject
go

Create table Province(
    provinceID int identity,
    provinceName nvarchar(500) unique,
	primary key(ProvinceID)
)
go

insert into Province(provinceName) values
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
go

create table LoginData
(
    userID varchar(8) not null,
    fullName nvarchar(500) not null,
    emailAddress varchar(500) not null,
    contactAddress nvarchar(500) not null,
	phoneNumber varchar(10) not null,
    userName varchar(500) not null unique,
    userPassword varchar(500) not null,
	userRole varchar(500) not null default 'user',
    primary key(userID)
)
go

alter table LoginData add constraint fk_LoginData_provinceName_Province foreign key(contactAddress) references Province(provinceName)
go

create procedure InsertUserLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'UID00001'
	select @maxUserID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'UID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'UID' + @maxUserID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword) values (@newUserID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword)
end
go

create procedure InsertAdminLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newAdminID char(8)
	declare @maxAdminID varchar(500)
	set @newAdminID = 'AID00001'
	select @maxAdminID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'AID'
	if (cast(@maxAdminID as int) > cast(substring(@newAdminID, 4, 8) as int))
	begin
		while (len(@maxAdminID) < 5)
		begin
			set @maxAdminID = '0' + @maxAdminID
		end
		set @newAdminID = 'AID' + @maxAdminID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword, userRole) values (@newAdminID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword, 'admin')
end
go

exec InsertUserLoginData N'Vương Thanh Huy', 'vuongthanhhuy@gmail.com', N'Trà Vinh', '08546377748', 'vuonggthanhhhuyy', 'vuongthanhhuy2003'
exec InsertUserLoginData N'Nguyễn Thành Nhật Tân', 'nguyenthanhnhattan@gmail.com', N'Trà Vinh', '0898495911', 'nguyennthanhhnhatttann', 'nguyenthanhnhattan2003'
exec InsertAdminLoginData N'Phùng Thị Thủy Tiên', 'phungthithuytien@gmail.com', N'Đắk Nông', '0868429676', 'phunggthiithuyytienn', 'phungthithuytien2003'
exec InsertAdminLoginData N'Nguyễn Trung Dũng', 'nguyentrungdung@gmail.com', N'Nghệ An', '0377485395', 'nguyenntrunggdungg', 'nguyentrungdung2003'
exec InsertUserLoginData N'Vương Thanh Huy', 'vuongthanhhuy@gmail.com', N'Trà Vinh', '08546377748', 'vuonggthanhhhuyyy', 'vuongthanhhuy2003'
exec InsertUserLoginData N'Nguyễn Thành Nhật Tân', 'nguyenthanhnhattan@gmail.com', N'Trà Vinh', '0898495911', 'nguyennthanhhnhatttannn', 'nguyenthanhnhattan2003'
exec InsertAdminLoginData N'Phùng Thị Thủy Tiên', 'phungthithuytien@gmail.com', N'Đắk Nông', '0868429676', 'phunggthiithuyytiennn', 'phungthithuytien2003'
exec InsertAdminLoginData N'Nguyễn Trung Dũng', 'nguyentrungdung@gmail.com', N'Nghệ An', '0377485395', 'nguyenntrunggdunggg', 'nguyentrungdung2003'
go

create table MenuData
(
	dishID varchar(8) not null,
	dishPicture varchar(500) not null,
    dishName nvarchar(500) not null,
    dishDescription nvarchar(500) not null,
    dishQuantity int not null,
	dishType varchar(500) not null,
    primary key(dishID)
)
go

create procedure InsertMenuData
    @dishPicture varchar(500),
    @dishName nvarchar(500),
    @dishDescription nvarchar(500),
    @dishQuantity int,
	@dishType varchar(500)
as
begin
    declare @newDishID char(8)
	declare @maxDishID varchar(500)
	set @newDishID = 'DID00001'
	select @maxDishID = cast(max(cast(substring(dishID, 4, 8) as int)) + 1 as varchar) from MenuData
	if (cast(@maxDishID as int) > cast(substring(@newDishID, 4, 8) as int))
	begin
		while (len(@maxDishID) < 5)
		begin
			set @maxDishID = '0' + @maxDishID
		end
		set @newDishID = 'DID' + @maxDishID 
	end
    insert into MenuData(dishID, dishPicture, dishName, dishDescription, dishQuantity, dishType) values (@newDishID, @dishPicture, @dishName, @dishDescription, @dishQuantity, @dishType)
end
go

exec InsertMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/Wed(R).jpg?v=46kppg', N'Khoai Tây Múi Cau', N'Khoai tây chiên cắt múi cau đậm vị', 99, 'food'
exec InsertMenuData 'https://static.kfcvietnam.com.vn/images/items/lg/D1-new.jpg?v=46kppg', N'Comnbo Đùi Gà Rán', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 20, 'combo'
exec InsertMenuData 'https://static.kfcvietnam.com.vn/images/items/xs/Pepsi-Can.jpg?v=46kppg', N'Pepsi Lon', N'Nước ngọt có gas', 123, 'drink'
go

create table PromotionData
(
	promotionID varchar(8) not null,
	promotionPicture varchar(500) not null,
    promotionName nvarchar(500) not null,
    promotionDescription nvarchar(500) not null,
    promotionDate datetime not null,
	promotionPercent int not null,
    primary key(promotionID)
)
go

create procedure InsertPromotionData
    @promotionPicture varchar(500),
    @promotionName nvarchar(500),
    @promotionDescription nvarchar(500),
    @promotionDate datetime,
	@promotionPercent int
as
begin
    declare @newPromotionID char(8)
	declare @maxPromotionID varchar(500)
	set @newPromotionID = 'PID00001'
	select @maxPromotionID = cast(max(cast(substring(promotionID, 4, 8) as int)) + 1 as varchar) from PromotionData
	if (cast(@maxPromotionID as int) > cast(substring(@newPromotionID, 4, 8) as int))
	begin
		while (len(@maxPromotionID) < 5)
		begin
			set @maxPromotionID = '0' + @maxPromotionID
		end
		set @newPromotionID = 'PID' + @maxPromotionID 
	end
    insert into PromotionData(promotionID, promotionPicture, promotionName, promotionDescription, promotionDate, promotionPercent) values (@newPromotionID, @promotionPicture, @promotionName, @promotionDescription, @promotionDate, @promotionPercent)
end
go

exec InsertPromotionData 'https://static.kfcvietnam.com.vn/images/items/lg/GaOcQue.jpg?v=41MdE4', N'Nhập mã COMBO1 giảm ngay 50%', N'Áp dụng từ ngày 03/05/2023 đến ngày 30/05/2023', '2023-05-30', 50
exec InsertPromotionData 'https://static.kfcvietnam.com.vn/images/items/lg/2-lava-taro.jpg?v=41MdE4', N'Nhập mã COMBO2 giảm ngay 70%', N'Áp dụng từ ngày 03/05/2023 đến ngày 30/05/2023', '2023-05-30', 70
exec InsertPromotionData 'https://static.kfcvietnam.com.vn/images/items/lg/1-gahoangkim.jpg?v=41MdE4', N'Nhập mã COMBO3 giảm ngay 30%', N'Áp dụng từ ngày 03/05/2023 đến ngày 30/05/2023', '2023-05-30', 30
go

create table StoreAddress
(
	storeID varchar(8) not null,
	storePicture varchar(500) not null,
    storeName nvarchar(500) not null,
    storeDescription nvarchar(500) not null,
    storeTime nvarchar(500) not null,
    primary key(storeID)
)
go

create procedure InsertStoreAddress
    @storePicture varchar(500),
    @storeName nvarchar(500),
    @storeDescription nvarchar(500),
    @storeTime nvarchar(500)
as
begin
    declare @newStoreID char(8)
	declare @maxStoreID varchar(500)
	set @newStoreID = 'SID00001'
	select @maxStoreID = cast(max(cast(substring(storeID, 4, 8) as int)) + 1 as varchar) from StoreAddress
	if (cast(@maxStoreID as int) > cast(substring(@newStoreID, 4, 8) as int))
	begin
		while (len(@maxStoreID) < 5)
		begin
			set @maxStoreID = '0' + @maxStoreID
		end
		set @newStoreID = 'SID' + @maxStoreID 
	end
    insert into StoreAddress(storeID, storePicture, storeName, storeDescription, storeTime) values (@newStoreID, @storePicture, @storeName, @storeDescription, @storeTime)
end
go

exec InsertStoreAddress 'https://www.lotteria.vn/grs-static/images/lotteria_logo.svg', N'Cửa hàng HTDT1', N'119 Nguyễn Thị Thập, Tân Phú, Quận 7, Hồ Chí Minh', N'7:00 - 19:00'
exec InsertStoreAddress 'https://www.lotteria.vn/grs-static/images/lotteria_logo.svg', N'Cửa hàng HTDT2', N'118 Nguyễn Thị Thập, Tân Phú, Quận 7, Hồ Chí Minh', N'7:00 - 19:00'
exec InsertStoreAddress 'https://www.lotteria.vn/grs-static/images/lotteria_logo.svg', N'Cửa hàng HTDT3', N'117 Nguyễn Thị Thập, Tân Phú, Quận 7, Hồ Chí Minh', N'7:00 - 19:00'
go

create table NotificationData
(
	notificationID varchar(8) not null,
	notificationPicture varchar(500) not null,
    notificationName nvarchar(500) not null,
    notificationDescription nvarchar(500) not null,
    notificationDate datetime not null,
    primary key(notificationID)
)
go

create procedure InsertNotificationData
    @notificationPicture varchar(500),
    @notificationName nvarchar(500),
    @notificationDescription nvarchar(500),
    @notificationDate datetime
as
begin
    declare @newnNotificationID char(8)
	declare @maxNotificationID varchar(500)
	set @newnNotificationID = 'NID00001'
	select @maxNotificationID = cast(max(cast(substring(notificationID, 4, 8) as int)) + 1 as varchar) from NotificationData
	if (cast(@maxNotificationID as int) > cast(substring(@newnNotificationID, 4, 8) as int))
	begin
		while (len(@maxNotificationID) < 5)
		begin
			set @maxNotificationID = '0' + @maxNotificationID
		end
		set @newnNotificationID = 'NID' + @maxNotificationID 
	end
    insert into NotificationData(notificationID, notificationPicture, notificationName, notificationDescription, notificationDate) values (@newnNotificationID, @notificationPicture, @notificationName, @notificationDescription, @notificationDate)
end
go

exec InsertNotificationData 'https://static.kfcvietnam.com.vn/images/category/lg/COMBO%20NHOM.jpg?v=41MdE4', N'Thông báo món ăn mới ra', N'Món gà rán nóng giòn cùng mùa hè nóng nực', '2023-05-07'
exec InsertNotificationData 'https://static.kfcvietnam.com.vn/images/category/lg/TRANG%20MIENG.jpg?v=41MdE4', N'Thông báo món nước mới ra', N'Món nước tươi mát cùng mùa hè nhiệt huyết', '2023-05-07'
go

-- Thiếu bảng lịch sử giao dịch --

select * from LoginData
select * from MenuData
select * from NotificationData
select * from PromotionData
select * from Province
select * from StoreAddress