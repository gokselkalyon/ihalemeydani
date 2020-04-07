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