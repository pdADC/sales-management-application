--Create new Database Store X
create database Store_X

--Notice of DB Store X usage
use Store_X

--create Employee table
create table Employee(
EmployeeID int,
EmployeeName varchar(100),
Position varchar(100),
AuthorityLevel int,
Username varchar(50),
Pass varchar(50)
)
--set constraints for the employee table
alter table Employee
alter column EmployeeID int not null

ALTER TABLE Employee
ALTER COLUMN EmployeeName VARCHAR(100) NOT NULL;

ALTER TABLE Employee
ALTER COLUMN Position VARCHAR(100) NOT NULL;

ALTER TABLE Employee
ALTER COLUMN AuthorityLevel INT NOT NULL;

ALTER TABLE Employee
ALTER COLUMN Username VARCHAR(50) NOT NULL;

ALTER TABLE Employee
ALTER COLUMN Pass VARCHAR(50) NOT NULL;

--set primary key for employee table
ALTER TABLE Employee
ADD CONSTRAINT PK_Employee PRIMARY KEY (EmployeeID);


create table Customer(
CustomerID int primary key, 
CustomerName varchar(100) not null,
Gender varchar (10) not null,
DateOfBirth date,
addr varchar(225) not null,
PhoneNum varchar(15) not null,
IsDeleted bit not null default 1
)

create table Category(
CategoryID int primary key,
CategoryName varchar(100) not null,
Category_Description varchar(225),
)

create table Supplier(
SupplierID int primary key,
SupplierName varchar(100) not null,
PhoneNumber varchar(15) not null,
addres varchar(100) not null,
)

create table Products(
ProductID int Primary key,
ProductName varchar(100) not null,
CategoryID int not null,
SupplierID int not null,
Price decimal(10,2) not null check(Price>0),
StockQuantity int not null,
IsDeleted bit not null default 1
)
create table Orders(
OrderID int identity(1,1) Primary key ,
EmployeeID int not null,
OrderDate date,
TotalAmount decimal(10,2) not null check (TotalAmount>=0),
Status varchar(50),
IsDeleted bit not null default 1
)

alter table Orders
add constraint FK_CustomerID_Orders foreign key(CustomerID) references Customer(CustomerID)

alter table Orders
add constraint FK_EmployeeID_Orders foreign key(EmployeeID) references Employee(EmployeeID)

alter table Products
add constraint FK_Category_Products foreign key(CategoryID) references Category(CategoryID)
alter table Products
add constraint FK_Supplier_Products foreign key(SupplierID) references Supplier(SupplierID)

create table OrderDetail(
OrderID int not null,
ProductID int not null,
Quantity int not null,
UnitPrice decimal(10,2) not null,
IsDeleted bit not null default 1
constraint PK_Order_Product primary key(OrderID,ProductID)
)
alter table OrderDetail
add constraint FK_Order_OrderDetail foreign key(OrderID) references Orders(OrderID)

alter table OrderDetail
add constraint FK_Product_OrderDetail foreign key(ProductID) references Products(ProductID)



create table Roles 
(
	RoleID int identity(1,1) primary key,  --id 
	RoleName varchar(50) not null unique	--Admin, staff, WareHouse
)
insert into Roles (RoleName) values ('Admin'), ('Staff'), ('WareHouse');

create table Users 
(
	UserID int identity(1,1) primary key,		--id user
	UserName varchar(50) not null unique,		-- user name 
	PasswordHash varbinary(64) not null,		--hash Password SHA2_256
	RoleID int not null,						--Foreign key to the Roles table
	FullName nvarchar(50),
	Email varchar(50),
	IsActive bit not null default 1,			--lock/suspend account (1-true; 0-false)
	CreateAt datetime default sysutcdatetime()	--Account creation time (UTC-universal time)
)
alter table Users 
add constraint Fk_User_Role foreign key (RoleID) references Roles(RoleID);

insert into Users (UserName,PasswordHash,RoleID,FullName,Email)
values 
(
	'admin',
	HASHBYTES('SHA2_256','Admin@123'),
	(select RoleID from Roles where RoleName ='Admin'),
	'quan tri he thong','admin@example.com'
)


CREATE PROCEDURE sp_Statistic
    @FromDate DATE,
    @ToDate   DATE,
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        OrderID,
        OrderDate,
        TotalAmount
    FROM Orders
    WHERE OrderDate BETWEEN @FromDate AND DATEADD(day, 1, @ToDate);

    -- Tổng số đơn
    SELECT COUNT(*) AS TotalOrders
    FROM Orders
    WHERE OrderDate BETWEEN @FromDate AND DATEADD(day, 1, @ToDate);

    -- Tổng doanh thu
    SELECT SUM(TotalAmount) AS TotalRevenue
    FROM Orders
    WHERE OrderDate BETWEEN @FromDate AND DATEADD(day, 1, @ToDate);
END     
GO

select OrderID,OrderDate,Customer,TotalAmount from Orders
where OrderDate between 
select * from Orders

CREATE PROCEDURE monthly_statistics
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT OrderID, OrderDate, CustomerName, TotalAmount
    FROM Orders
    WHERE MONTH(OrderDate) = @Month
      AND YEAR(OrderDate) = @Year
      AND IsDeleted=1
END
go

DROP PROCEDURE Dayly_Statistic;

CREATE PROCEDURE Dayly_statistics
    @Day INT,
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT OrderID, OrderDate, CustomerName, TotalAmount
    FROM Orders
    WHERE MONTH(OrderDate) = @Month
      AND YEAR(OrderDate) = @Year
      AND Day(OrderDate)=@Day
      AND IsDeleted=1
END
go

DROP PROCEDURE Dayly_statistics;

SELECT count(*) OrderID
    FROM Orders
    WHERE MONTH(OrderDate) = 11
      AND YEAR(OrderDate) = 2025        
      AND Day(OrderDate)=27
      AND IsDeleted=1