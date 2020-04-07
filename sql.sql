----///////// salih ençevik //////// 
create table Claim
(
	Id int identity primary key,
	Text nvarchar(50)
)
go
create table Role
(
	Id int identity primary key,
	Name nvarchar(50)
)
go
create table RoleClaim
(
	Id int identity primary key,
	RoleId int,
	ClaimId int
	Constraint FK_RoleClaimId_RoleId foreign key (RoleId) references Role(Id),
	Constraint FK_RoleClaimId_ClaimId foreign key (ClaimId) references Claim(Id)
)

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
go
create table UserRole
(
	Id int identity primary key,
	UserId int,
	RoleId int
	Constraint FK_UserRoleId_RoleId foreign key (RoleId) references Role(Id),
	Constraint FK_UserRoleId_UserId foreign key (UserId) references [User](Id)
)
----////////////////// salih ençevik son //////////// 


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
////////muhammed goksel kalyon /////////
CREATE TABLE CURRENCY
(
    ID INT IDENTITY PRIMARY KEY,
    NAME NVARCHAR(10) DEFAULT 'TL'
)
GO
CREATE TABLE AMOUNT_OF_INCREASE
(
    ID INT IDENTITY PRIMARY KEY,
    CURRENCY_ID INT,
    MAX_PRICE MONEY,
    MIN_PRICE MONEY,
    INCREASE_PRICE MONEY,
    DATE_OF_UPDATE DATE DEFAULT GETDATE(),
    UPDATED_PERSON_ID INT
)
GO
CREATE TABLE auction
(
    ID INT IDENTITY PRIMARY KEY,
    PRODUCT_ID INT,///acık artırmaya eklenecek ürün
    ACUTION_DATE DATE DEFAULT GETDATE(),/// ACIK ARTIRMA TARIHI
    USER_ID INT, //ACIK ARTIRMAYI YAPACAK OLAN 
    ACUTION_SALES_TIME INT,///SANIYE CINSINSEN YAPILAN SON TEKLIFTEN SONRA BAŞKA TEKLİF GELMEZ İSE BİTME SÜRESİ
    AMOUNT_OF_INCREASE_ID INT,
    DATE_OF_UPDATE DATE DEFAULT GETDATE(),
    UPDATED_PERSON_ID INT
)
GO
CREATE TABLE PRICEBOT
(
    ID INT IDENTITY PRIMARY KEY,
    CarDetail_ID INT,
    ORT_FIYAT MONEY,
    DATE_OF_UPDATE DATE DEFAULT GETDATE()
)
go
IF OBJECT_ID('company_type','u') is not null drop table company_type
go
create table company_type
(
	Id int identity primary key,
	[type_name] nvarchar(100),
	DATE_OF_UPDATE DATE DEFAULT GETDATE()
)
go
	IF OBJECT_ID('city','u') is not null drop table city
go
	create table city
	(
		plate_code int primary key,
		city_name nvarchar(50),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('county','u') is not null drop table county
go
	create table county
	(
		Id int identity primary key,
		plate_code int foreign key references city(plate_code),
		county_name nvarchar(50),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('country','u') is not null drop table country
go
	create table country
	(
		Id int identity primary key,
		[country plate sign] nvarchar(10),
		[country_name] nvarchar(100),
		Country_name_EN nvarchar(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('[Tax Administration]','u') is not null drop table [Tax Administration]
go
	create table [Tax Administration]
	(
		Id int identity primary key,
		[Tax_Administration_name] nvarchar(150),
		city int foreign key references city(plate_code),
		[Tax_Administration_code] nvarchar(55),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('company','u') is not null drop table company
go
	create table company
	(
		Id int identity primary key,
		company_type int foreign key references company_type(Id),
		company_name nvarchar(200),
		city int foreign key references city(plate_code),
		[Tax Administration] int foreign key references [Tax Administration](Id),
		county int foreign key references county(Id),
		country int foreign key references country(Id),
		Tax_number nvarchar(55),--tckn vkn no
		company_address nvarchar(200),
		tel nvarchar(11),
		ticaret_sicil_no nvarchar(15),
		mersis_no nvarchar(15),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
go
	IF OBJECT_ID('employee_position','u') is not null drop table employee_position
go
	create table employee_position
	(
		id int identity primary key,
		position nvarchar(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('employees','u') is not null drop table employees
go
	create table employees
	(
		id int identity primary key,
		employee_name nvarchar(100),
		employee_lastname nvarchar(100),
		employee_TC nvarchar(11),
		salary money,--maaþý
		employee_position int foreign key references employee_position(id),-- çalýþanýn pozisyonu 
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('discountcart','u') is not null drop table discountcart
go
	create table discountcart
	(
		Id int identity primary key,
		[type_name] nvarchar(15),
		code nvarchar(11),
		statu bit default 1,
		figure nvarchar(55),
		currency int foreign key references currency(Id),
		[value] int,
		Formula int,
		Ekleyen_Kullanici int foreign key references Users(Id),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('payment_plan','u') is not null drop table payment_plan
go
	create table payment_plan
	(
		Id int identity primary key,
		code int,
		explanation nvarchar(100),
		discount int foreign key references discountcart(Id),
		statu bit default 1,
		Ekleyen_Kullanici int foreign key references Users(Id),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('E_invoice_type','u') is not null drop table E_invoice_type
go
	create table senaryo
	(
		Id int identity primary key,
		senaryo nvarchar(20),--e-fatura temel,e-fatura ticari,e-fatura ihracat,e-fatura yolcu beraber
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	create table E_invoice_type
	(
		id int identity primary key,
		E_invoice_type_name nvarchar(20),--Satış,...
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	create table odeme_yontemi
	(
		id int identity primary key,
		yontem nvarchar(15),-- kredi kartı,...
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('bank','u') is not null drop table bank
go
	create table bank
	(
		Id int identity primary key,
		bank_name nvarchar(50),
		explanation nvarchar(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
go
	IF OBJECT_ID('natification','u') is not null drop table natification
go
	create table natification
	(
		id int identity primary key,
		explanation nvarchar(250),
		zaman date default getdate(),
		ekleyenkullanici int foreign key references users(Id)
	)
GO
	CREATE TABLE E_INVOICE
	(
		ID INT IDENTITY PRIMARY KEY,
		senaryo_id int,
		company_id int,
		E_invoice_type_id int,
		odeme_yontemi_id int,
		[user_id] int,
		INVOICE_NO NVARCHAR(50),
		INVOICE_DATE DATE DEFAULT GETDATE(),
		SATISKANALI NVARCHAR(50),--SİTENİN ADI N11,HEPSIBURADA,...
		CarDetail_ID INT,
		MIKTAR INT,
		BIRIM_FIYATI MONEY,
		KDV INT,
		TOPLAM MONEY,
		FATURA_TOPLAM MONEY,
		TOPLAM_ISKONTO MONEY,
		TOPLAM_KDV MONEY,
		KDV_DAHIL_TOPLAM_TUTAR MONEY,
		ODENECEK_TUTAR MONEY,
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	CREATE TABLE SOLD_PRODUCT
	(
		ID INT IDENTITY PRIMARY KEY,
		CarDetail_ID INT,
		E_INVOICE_ID INT,
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
////////muhammed goksel kalyon son//////
