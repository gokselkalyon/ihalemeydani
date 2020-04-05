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