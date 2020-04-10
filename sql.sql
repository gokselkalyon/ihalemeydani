CREATE DATABASE IHALEDB
GO
USE IHALEDB
GO
	IF OBJECT_ID('country','u') is not null DROP TABLE country
	CREATE TABLE country
	(
		Id INT IDENTITY PRIMARY KEY,
		[country plate sign] NVARCHAR(10),
		[country_name] NVARCHAR(100),
		Country_name_EN NVARCHAR(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	CREATE TABLE city
	(
		plate_code INT PRIMARY KEY,
		city_name NVARCHAR(50),
        country_id INT FOREIGN KEY REFERENCES country(Id),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('county','u') is not null DROP TABLE county
GO
	CREATE TABLE county
	(
		Id INT IDENTITY PRIMARY KEY,
		city_id INT FOREIGN KEY REFERENCES city(plate_code),
		county_name NVARCHAR(50),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
    CREATE TABLE Claim
    (
    	Id INT IDENTITY PRIMARY KEY,
    	Text NVARCHAR(50)
    )
GO
    CREATE TABLE Role
    (
    	Id INT IDENTITY PRIMARY KEY,
    	Name NVARCHAR(50)
    )
GO
    CREATE TABLE RoleClaim
    (
    	Id INT IDENTITY PRIMARY KEY,
    	RoleId INT,
    	ClaimId INT
    )
GO
    CREATE TABLE UserType
    (
    	Id INT IDENTITY PRIMARY KEY,
    	[Name] NVARCHAR(50),
    	IsDeleted bit
    )
GO
    CREATE TABLE [User]
    (
    	Id INT IDENTITY PRIMARY KEY,
    	[Name] NVARCHAR(50),
    	Surname NVARCHAR(50),
    	Adress NVARCHAR(200),
    	CompanyName NVARCHAR(50),
    	Email NVARCHAR(100),
    	[Password] NVARCHAR(20),
    	IdentityNo NVARCHAR(11),
    	Phone NVARCHAR(11),
    	IsDeleted bit,
    	city_id INT FOREIGN KEY REFERENCES city(plate_code),
    	UserType_Id INT,
    )
GO
    CREATE TABLE UserRole
    (
    	Id INT IDENTITY PRIMARY KEY,
    	[User_Id] INT,
    	Role_Id INT
    )
GO
    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarBrand')
GO
    CREATE TABLE CarBrand
    (
    	CarBrandId INT IDENTITY PRIMARY KEY,
    	CarBrandName NVARCHAR(100) Not Null
    )
Go
/*Aracların Modelleri olacak*/
    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarMake')
    CREATE TABLE CarMake
    (
    	CarMakeId INT IDENTITY PRIMARY KEY,
    	CarMakeName NVARCHAR(50),
    	CarBrandId INT
    )
GO
/*Burada vites tiplerini tutacağım*/
    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='GearType')
    CREATE TABLE GearType
    (
    	GearTypeId INT IDENTITY PRIMARY KEY,
    	GearTypeName NVARCHAR(50)
    )
GO
/*Burada yakıt tiplerini tutacağım*/
    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='FuelType')
    CREATE TABLE FuelType
    (
    	FuelTypeId INT IDENTITY PRIMARY KEY,
    	FuelTypeName NVARCHAR(50)
    )
GO
/*Burada araba renklerini tutacağım*/
    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Color')
    CREATE TABLE Color
    (
    	ColorId INT IDENTITY PRIMARY KEY,
    	ColorName NVARCHAR(50),
    	ColorValue NVARCHAR(40)
    )
GO

/*Burada araba segmentlerini tutacağım*/

    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Segment')
    CREATE TABLE Segment
    (
    	SegmentId INT IDENTITY PRIMARY KEY,
    	SegmentName NVARCHAR(50)
    )
GO

/*Burada aracın teknik özelliklerini tutacağım marka model motor hacmi vs*/

    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarTechnicalDetails')
    CREATE TABLE CarTechnicalDetails
    (
    	CarTechnicalDetailId INT IDENTITY PRIMARY KEY,
    	CarMakeId INT,
    	GearTypeId INT,
    	EngineDisplacement INT,
    	Mileage INT,
    	LicancePlate NVARCHAR(8),
    	FuelTypeId INT FOREIGN KEY REFERENCES FuelType(FuelTypeId),
    	HP INT,
    	registrationDate Date,
    	CarVersion NVARCHAR(50),
    	ColorId INT FOREIGN KEY REFERENCES Color(ColorId),
    	VIN NVARCHAR(17), /*VIN:Şasİ No 17 Karakterden oluşur.*/
    	SegmentId INT FOREIGN KEY REFERENCES Segment(SegmentId)
    )
GO
/*Burada aracın donanımsal çzelliklerini tutacağım abs 4x4 vs.*/

    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarHardwareDetails')
    CREATE TABLE CarHardwareDetails
    (
    	CarHardwareDetailsId INT IDENTITY PRIMARY KEY,
    	HardwareDetail NVARCHAR(50),
    	CarDetailId INT
    )
GO
/*Burada aracın teknik ve donanimsal tablolarını bağlyıcağım ve fotoğraflarını burada tutacağım.*/

    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='CarDetail')
    CREATE TABLE CarDetail
    (
    	CarDetailId INT IDENTITY PRIMARY KEY,
    	CarTechnicalId INT FOREIGN KEY REFERENCES CarTechnicalDetails(CarTechnicalDetailId),
    	CarHardwareId INT  FOREIGN KEY REFERENCES CarHardwareDetails(CarHardwareDetailsId)
    )
GO

/*Burada araçların fotoğraf yollarını tutacağım.*/

    If Not Exists (Select * from INFORMATION_SCHEMA.TABLES Where TABLE_NAME='Images')
    CREATE TABLE Images
    (
    	İmagesId INT IDENTITY PRIMARY KEY,
    	CarId INT FOREIGN KEY REFERENCES CarDetail(CarDetailId),
    	İmage NVARCHAR(100)
    )
GO
    CREATE TABLE CURRENCY
    (
        ID INT IDENTITY PRIMARY KEY,
        NAME NVARCHAR(10) DEFAULT 'TL'
    )
GO
    CREATE TABLE AMOUNT_OF_INCREASE
    (
        ID INT IDENTITY PRIMARY KEY,
        CURRENCY_ID INT FOREIGN KEY REFERENCES CURRENCY(ID),
        MAX_PRICE MONEY,
        MIN_PRICE MONEY,
        INCREASE_PRICE MONEY,
        DATE_OF_UPDATE DATE DEFAULT GETDATE(),
        UPDATED_PERSON_ID INT FOREIGN KEY REFERENCES [User](Id)
    )
GO
    CREATE TABLE auction
    (
        ID INT IDENTITY PRIMARY KEY,
        PRODUCT_ID INT FOREIGN KEY REFERENCES CarDetail(CarDetailId),--///acık artırmaya eklenecek ürün
        ACUTION_DATE DATE DEFAULT GETDATE(),--/// ACIK ARTIRMA TARIHI
        [USER_ID] INT FOREIGN KEY REFERENCES [User](Id),-- //ACIK ARTIRMAYI YAPACAK OLAN 
        ACUTION_SALES_TIME INT,--///SANIYE CINSINSEN YAPILAN SON TEKLIFTEN SONRA BAŞKA TEKLİF GELMEZ İSE BİTME SÜRESİ
        AMOUNT_OF_INCREASE_ID INT FOREIGN KEY REFERENCES AMOUNT_OF_INCREASE(ID),
        DATE_OF_UPDATE DATE DEFAULT GETDATE(),
        UPDATED_PERSON_ID INT FOREIGN KEY REFERENCES [User](Id)
    )
GO
    CREATE TABLE PRICEBOT
    (
        ID INT IDENTITY PRIMARY KEY,
        CarDetail_ID INT FOREIGN KEY REFERENCES CarDetail(CarDetailId),
        ORT_FIYAT MONEY,
        DATE_OF_UPDATE DATE DEFAULT GETDATE()
    )
GO
    IF OBJECT_ID('company_type','u') is not null drop TABLE company_type
GO
    CREATE TABLE company_type
    (
    	Id INT IDENTITY PRIMARY KEY,
    	[type_name] NVARCHAR(100),
    	DATE_OF_UPDATE DATE DEFAULT GETDATE()
    )
GO
	IF OBJECT_ID('[Tax_Administration]','u') is not null drop TABLE [Tax_Administration]
GO
	CREATE TABLE [Tax_Administration]
	(
		Id INT IDENTITY PRIMARY KEY,
		[Tax_Administration_name] NVARCHAR(150),
		city_id INT FOREIGN KEY REFERENCES city(plate_code),
		[Tax_Administration_code] NVARCHAR(55),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('company','u') is not null drop TABLE company
GO
	CREATE TABLE company
	(
		Id INT IDENTITY PRIMARY KEY,
		company_type INT foreign key references company_type(Id),
		company_name NVARCHAR(200),
		city_id INT foreign key references city(plate_code),
		[Tax_Administration] INT foreign key references [Tax Administration](Id),
		county_id INT foreign key references county(Id),
		country_id INT foreign key references country(Id),
		Tax_number NVARCHAR(55),--tckn vkn no
		company_address NVARCHAR(200),
		tel NVARCHAR(11),
		ticaret_sicil_no NVARCHAR(15),
		mersis_no NVARCHAR(15),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('employee_position','u') is not null drop TABLE employee_position
GO
	CREATE TABLE employee_position
	(
		id INT IDENTITY PRIMARY KEY,
		position NVARCHAR(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('employees','u') is not null drop TABLE employees
GO
	CREATE TABLE employees
	(
		id INT IDENTITY PRIMARY KEY,
		employee_name NVARCHAR(100),
		employee_lastname NVARCHAR(100),
		employee_TC NVARCHAR(11),
		salary money,--maaþý
		employee_position_id INT FOREIGN KEY REFERENCES employee_position(id),-- çalýþanýn pozisyonu 
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('discountcart','u') is not null drop table discountcart
GO
	CREATE TABLE discountcart
	(
		Id INT IDENTITY PRIMARY KEY,
		[type_name] NVARCHAR(15),
		code NVARCHAR(11),
		statu bit default 1,
		figure NVARCHAR(55),
		currency_id INT foreign key references currency(Id),
		[value] INT,
		Formula INT,
		Ekleyen_Kullanici INT FOREIGN KEY REFERENCES [User](Id),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('payment_plan','u') is not null drop table payment_plan
GO
	CREATE TABLE payment_plan
	(
		Id INT IDENTITY PRIMARY KEY,
		code INT,
		explanation NVARCHAR(100),
		discount_id INT foreign key references discountcart(Id),
		statu bit default 1,
		Ekleyen_Kullanici INT FOREIGN KEY REFERENCES [User](Id),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('E_invoice_type','u') is not null drop table E_invoice_type
GO
	CREATE TABLE senaryo
	(
		Id INT IDENTITY PRIMARY KEY,
		senaryo NVARCHAR(20),--e-fatura temel,e-fatura ticari,e-fatura ihracat,e-fatura yolcu beraber
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	CREATE TABLE E_invoice_type
	(
		id INT IDENTITY PRIMARY KEY,
		E_invoice_type_name NVARCHAR(20),--Satış,...
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	CREATE TABLE odeme_yontemi
	(
		id INT IDENTITY PRIMARY KEY,
		yontem NVARCHAR(15),-- kredi kartı,...
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('bank','u') is not null drop TABLE bank
GO
	CREATE TABLE bank
	(
		Id INT IDENTITY PRIMARY KEY,
		bank_name NVARCHAR(50),
		explanation NVARCHAR(100),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	IF OBJECT_ID('natification','u') is not null drop TABLE natification
GO
	CREATE TABLE natification
	(
		id INT IDENTITY PRIMARY KEY,
		explanation NVARCHAR(250),
		zaman date default getdate(),
		ekleyenkullanici_id INT FOREIGN KEY REFERENCES [User](Id)
	)
GO
	CREATE TABLE E_INVOICE
	(
		ID INT IDENTITY PRIMARY KEY,
		senaryo_id INT FOREIGN KEY REFERENCES senaryo(Id),
		company_id INT FOREIGN KEY REFERENCES company(Id),
		E_invoice_type_id INT FOREIGN KEY REFERENCES E_invoice_type(id),
		odeme_yontemi_id INT FOREIGN KEY REFERENCES odeme_yontemi(id),
		[user_id] INT FOREIGN KEY REFERENCES [User](Id),
		INVOICE_NO NVARCHAR(50),
		INVOICE_DATE DATE DEFAULT GETDATE(),
		SATISKANALI NVARCHAR(50),--SİTENİN ADI N11,HEPSIBURADA,...
		CarDetail_ID INT FOREIGN KEY REFERENCES CarDetail(CarDetailId),
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
		CarDetail_ID INT FOREIGN KEY REFERENCES CarDetail(CarDetailId),
		E_INVOICE_ID INT FOREIGN KEY REFERENCES E_INVOICE(ID),
		DATE_OF_UPDATE DATE DEFAULT GETDATE()
	)
GO
	CREATE TABLE title
    (
        title_id INT primary key identity,
        title_name NVARCHAR(50),
    )
GO
    CREATE TABLE tag
    (
        tag_id INT primary key identity,
        tag_name NVARCHAR(50)
    )
GO
    CREATE TABLE media
    (
    	id INT identity primary key,
    	image_name NVARCHAR(50),-- xiaomi m6
    	image_subtitle NVARCHAR(100),-- telefon
    	image_title NVARCHAR(50),--
    	image_path NVARCHAR(100)
    )
GO
    CREATE TABLE submit
    (
        submit_id INT primary key identity,
        media_id INT FOREIGN KEY REFERENCES media(id),
        submit_article NVARCHAR(1000),
    )
GO
    CREATE TABLE Post
    (
        Post_id INT primary key identity,
        content_id INT FOREIGN KEY REFERENCES submit(submit_id),
        users_id INT FOREIGN KEY REFERENCES [User](Id),
        Post_date date default getdate()
    )
GO

    CREATE TABLE tag_post
    (
        tag_post_id INT primary key identity,
        Post_id INT FOREIGN KEY REFERENCES Post(Post_id),
        tag_id INT FOREIGN KEY REFERENCES tag(tag_id)
    )
GO
    CREATE TABLE [log]
    (
    	Id INT IDENTITY PRIMARY KEY,
    	[action_table] NVARCHAR(100) NOT NULL,--DEĞİŞİKLİLİK YAPILAN TABLO
    	[action_name] NVARCHAR(20) NOT NULL,--YAPILAN EYLEMİN ADI UPDATE,..
    	[user_id] INT FOREIGN KEY REFERENCES [User](Id),
    	date_of DATE DEFAULT GETDATE(),
    )
GO
Create Table Icon
(
	Id int identity primary key,
	[Name] varchar(75)
)
Go
Create Table Menu
(
	Id int identity primary key,
	[Name] varchar(75),
	IconId int,
	[Description] text null,
	MenuId int Default 0
	Constraint FK_MenuIcon Foreign Key (IconId) References Icon(Id)  
)
Go
Create Table SocialMedya
(
	Id int identity primary key,
	[Name] varchar(75),
	IconId int,
	Constraint FK_SocialIcon Foreign Key (IconId) References Icon(Id)  
)
Go
Create Table GeneralDesign
(
	Id int identity primary key,
	Header text,
	Nav text,
	Article text,
	Section text,
	Aside text,
	Footer text
)

