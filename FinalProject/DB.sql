create database FinalProject
GO
use FinalProject
GO
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
Select * from LoginDataTable
GO
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
GO
exec ProcUserData N'Nguyễn Thành Nhật Tân', 'nguyennthanhhnhatttann@gmail.com', N'Hồ Chí Minh', 'nguyenthanhnhattan', 'nguyennthanhhnhatttann'
exec ProcUserData N'Vương Thanh Huy', 'vuonggthanhhhuyy@gmail.com', N'Trà Vinh', 'vuongthanhhuy', 'vuonggthanhhhuyy'

select * from LoginDataTable
GO
Create table Cities(
    ID int IDENTITY primary key,
    provinceName Nvarchar(50) unique
)
GO
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
GO
create table MenuDataTable
(
	dishID varchar(8) not null,
	dishPicture varchar(100) not null,
    dishName nvarchar(50) not null,
    dishDescription nvarchar(500) not null,
    dishQuantity int not null default 0,
    primary key(dishID)
)
GO
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
GO
create table PromotionDataTable
(
	promotionID varchar(8) unique,
	promotionPicture varchar(5000) not null,
    promotionName nvarchar(50) not null,
    promotionDescription nvarchar(500) not null,
    primary key(promotionID)
)
GO

drop table PromotionDataTable

CREATE PROCEDURE InsertPromotionData
    @promotionPicture varchar(5000),
    @promotionName nvarchar(50),
    @promotionDescription nvarchar(500)
AS
BEGIN
    DECLARE @newID varchar(8)
    SET @newID = 'P'

    -- Generate a random 6-digit number
    DECLARE @randomNumber int = CAST(RAND() * 900000 + 100000 AS int)
    SET @newID = @newID + CAST(@randomNumber AS varchar(6))

    -- Insert the new row with the generated ID
    INSERT INTO PromotionDataTable (promotionID, promotionPicture, promotionName, promotionDescription)
    VALUES (@newID, @promotionPicture, @promotionName, @promotionDescription)
END



drop procedure InsertPromotionData


EXEC dbo.InsertPromotionData 'http://example.com/promo.jpg', 'New Promotion', 'Get 10% off your order!'

EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/super-delicious-burger-instagram-post-design-template_202595-494.jpg',
							N'Siêu sale cuối tháng cho sinh viên nghèo',
							N'Sale 50% từ ngày này qua tháng nọ'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-vector/culinary-instagram-post-collection-with-photo_52683-25659.jpg?w=740&t=st=1680278614~exp=1680279214~hmac=66e4fe57cbfe5480b458b2f8993c1b6280f33346c81893c99596433fc4eb2c0f', 
							'New Promotion 2', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-banner-post-template_202595-356.jpg?w=740&t=st=1680278686~exp=1680279286~hmac=02ffc4c2809a0322c570e8888d56318fe05c78fec1f1f24b6ca40e59f2f345d1', 
							'New Promotion 3', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-banner-post-template_202595-340.jpg?w=740&t=st=1680278731~exp=1680279331~hmac=bf793233f01d39d755edb06c6385e0786503d76fe73afcdaca19174f9a61ba6d', 
							'New Promotion 4', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-post-template_120329-1434.jpg?w=740&t=st=1680282367~exp=1680282967~hmac=5cd0c3e1b976e722e8886890c36558cc4ca421b7479cb1fe63c3e96e22c8716a', 
							'New Promotion 5', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-banner-template_120329-1748.jpg?w=740&t=st=1680282453~exp=1680283053~hmac=8aa996354e66f4cf50278a094775055001e907493e59aefea2785a31bfa24f66', 
							'New Promotion 6', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-promotion-banner-post-design-template_202595-274.jpg?w=740&t=st=1680282471~exp=1680283071~hmac=82858393a5bbd64f661d6f62e8b313c10a86fdb5bc5d4b486476d78e6f1ef45b', 
							'New Promotion 7', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-banner-template_106176-1304.jpg?w=740&t=st=1680282478~exp=1680283078~hmac=73cae22dccae409d340fda1184055a55253ba96678951bcc6481ca18046140dd', 
							'New Promotion 8', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-banner-template_120329-1752.jpg?w=740&t=st=1680282490~exp=1680283090~hmac=afafa8903bcf5182bca16e494952faa36a89722618e7d430031ad374b1822ff3', 
							'New Promotion 9', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-promotion-instagram-banner-post-design-template_202595-477.jpg?w=740&t=st=1680282597~exp=1680283197~hmac=c2f997bb3c94bbf956a7048f56722f9c5686243f8e8bf40ccf3d4e8339b0ac3e', 
							'New Promotion 10', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/premium-vector/online-food-promotion-with-mobile-square-banner-template_257571-196.jpg?w=1380', 
							'New Promotion 11', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-promotion-instagram-banner-post-design-template_202595-473.jpg?w=740&t=st=1680282704~exp=1680283304~hmac=e93c3df629e834b5d0dcb05bad3cd1b6af0bc598a704140418de6a7ae0531504', 
							'New Promotion 12', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/premium-psd/template-food-menu-social-media-post_202595-183.jpg?w=740', 
							'New Promotion 13', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-banner-template_120329-1732.jpg?w=740&t=st=1680282719~exp=1680283319~hmac=90adc50e73981e22687834e594db859299aec31640ce76cb8c00547d230adb30', 
							'New Promotion 14', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/premium-vector/special-menu-social-media-post-template_403076-78.jpg?w=1380', 
							'New Promotion 15', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/restaurant-food-menu-social-media-post_202595-497.jpg?w=740&t=st=1680282736~exp=1680283336~hmac=91aae6476ebc4a25e93ca6aa85515b1eeb2d49bb221eb0c1925648c42badadcf', 
							'New Promotion 16', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-menu-restaurant-social-media-banner-template_120329-1660.jpg?w=740&t=st=1680282747~exp=1680283347~hmac=d87021c6da2e5da47d633b65c4b8d0b0cbd028cfcc43131e059e82081dc7390a', 
							'New Promotion 17', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-psd/food-social-media-promotion-instagram-banner-post-design-template_202595-308.jpg?w=740&t=st=1680282754~exp=1680283354~hmac=0aa4b125ec2582c88af773ea473795b4f087414bc13f59271e38b10f56992a83', 
							'New Promotion 18', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-vector/brunch-square-flyer-template_23-2148815195.jpg?w=740&t=st=1680282761~exp=1680283361~hmac=de0938e45820b3eb62b7375c7d191c1bfd2b0515f24a854fbb62b5dd64482296', 
							'New Promotion 19', 
							'Get 10% off your order!'
EXEC dbo.InsertPromotionData 'https://img.freepik.com/free-vector/american-food-flyer-vertical_23-2148751796.jpg?w=740&t=st=1680282773~exp=1680283373~hmac=abe9412f765b88d13d81b51fba9e199faf3429090c85466ed5cadbac5cf80791', 
							'New Promotion 20', 
							'Get 10% off your order!'
select * from PromotionDataTable
