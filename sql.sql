///////// salih ençevik ////////
create table UserType
(
	Id int identity primary key,
	Name nvarchar(50),
	IsDeleted bit
)
create table City
(
	Id int identity primary key,
	Name nvarchar(50),
	IsDeleted bit
)
go
create table Town
(
	Id int identity primary key,
	Name nvarchar(50),
	IsDeleted bit,
	CityId int
	Constraint FK_TownId_CityId foreign key (CityId) references City(Id)
)
go
create table [User]
(
	Id int identity primary key,
	Name nvarchar(50),
	Surname nvarchar(50),
	Adress nvarchar(200),
	CompanyName nvarchar(50),
	Email nvarchar(100),
	Password nvarchar(20),
	IdentityNo nvarchar(11),
	Phone nvarchar(11),
	IsDeleted bit,
	TownId int,
	UserTypeId int,
	Constraint FK_UserId_TownId foreign key (TownId) references Town(Id),
	Constraint FK_UserId_UserTypeId foreign key (UserTypeId) references UserType(Id)
)
///////// salih ençevik son ////////////


--------------///Furkan Veritabanı [Araç Özellikleri] \\\-----------------
use Ihale1
Go
/*Aracların Marka olacak*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarBrand')
Create Table CarBrand
(
	CarBrandId Int Identity,
	CarBrandName Nvarchar(100) Not Null,
	Constraint PK_CarBrand_CarBrandId Primary Key(CarBrandId)
)
Go
/*Aracların Modelleri olacak*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarMake')
Create Table CarMake
(
	CarMakeId Int Identity,
	CarMakeName Nvarchar(50),
	CarBrandId Int,
	Constraint PK_CarMake_CarMakeId Primary Key(CarMakeId),
	Constraint FK_CarMake_CarBrandId Foreign Key (CarBrandId) References CarBrand(CarBrandId)
)
Go
/*Burada vites tiplerini tutacağım*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='GearType')
Create Table GearType
(
	GearTypeId Int Identity,
	GearTypeName Nvarchar(50),
	Constraint PK_GearType_GearTypeId Primary Key(GearTypeId)
)
Go
/*Burada yakıt tiplerini tutacağım*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='FuelType')
Create Table FuelType
(
	FuelTypeId Int Identity,
	FuelTypeName Nvarchar(50),
	Constraint PK_FuelType_FuelTypeId Primary Key(FuelTypeId)
)
Go
/*Burada araba renklerini tutacağım*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Color')
Create Table Color
(
	ColorId Int Identity,
	ColorName Nvarchar(50),
	ColorValue Nvarchar(40),
	Constraint PK_Color_ColorId Primary Key(ColorId)
)
Go
/*Burada araba segmentlerini tutacağım*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Segment')
Create Table Segment
(
	SegmentId Int Identity,
	SegmentName Nvarchar(50),
	Constraint PK_Segment_SegmentId Primary Key(SegmentId)
)
Go
/*Burada aracın teknik özelliklerini tutacağım marka model motor hacmi vs*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarTechnicalDetails')
Create Table CarTechnicalDetails
(
	CarTechnicalDetailId Int Identity,
	CarMakeId Int,
	GearTypeId Int,
	EngineDisplacement int,
	Mileage int,
	LicancePlate Nvarchar(8),
	FuelTypeId Int,
	HP Int,
	registrationDate Date,
	CarVersion Nvarchar(50),
	ColorId Int,
	VIN Nvarchar(17), /*VIN:Şasİ No 17 Karakterden oluşur.*/
	SegmentId Int,
	Constraint PK_CarTechnicalDetails_CarTechnicalDetailId Primary Key(CarTechnicalDetailId),
	Constraint FK_CarTechnicalDetails_CarMakeId Foreign Key (CarMakeId) References CarMake(CarMakeId),
	Constraint FK_CarTechnicalDetails_GearTypeId Foreign Key (GearTypeId) References GearType(GearTypeId),
	Constraint FK_CarTechnicalDetails_FuelTypeId Foreign Key (FuelTypeId) References FuelType(FuelTypeId),
	Constraint FK_CarTechnicalDetails_ColorId Foreign Key (ColorId) References Color(ColorId),
	Constraint FK_CarTechnicalDetails_SegmentId Foreign Key (SegmentId) References Segment(SegmentId)
)
Go
/*Burada aracın teknik ve donanimsal tablolarını bağlyıcağım ve fotoğraflarını burada tutacağım.*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarDetail')
Create Table CarDetail
(
	CarDetailId Int Identity,
	CarTechnicalId Int,
	CarHardwareId Int,
	Constraint PK_CarDetail_CarDetailsId Primary Key(CarDetailId),
	Constraint FK_CarDetail_CarTechnicalId Foreign Key (CarTechnicalId) References CarTechnicalDetails(CarTechnicalDetailId),
)
Go
/*Burada aracın donanımsal çzelliklerini tutacağım abs 4x4 vs.*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarHardwareDetails')
Create Table CarHardwareDetails
(
	CarHardwareDetailsId Int Identity,
	HardwareDetail Nvarchar(50),
	CarDetailId Int,
	Constraint PK_CarDetails_CarDetailsId Primary Key(CarHardwareDetailsId),
	Constraint FK_CarHardwareDetails_CarDetailId Foreign Key (CarDetailId) References CarDetail(CarDetailId)
)
Go
/*Burada araçların fotoğraf yollarını tutacağım.*/
If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Images')
Create Table Images
(
	İmagesId Int Identity,
	CarId Int,
	İmage Nvarchar(100),
	Constraint PK_Images_İmagesId Primary Key(İmagesId),
	Constraint FK_Images_CarDetail Foreign Key (CarId) References Cardetail(CarDetailId)
)
Go


--------------///Furkan SON \\\-----------------
