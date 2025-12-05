create database StoreX
use StoreX
create table Employee
(
	EmployeeID int identity(1,1) primary key, 
	EmployeeName nvarchar(100) not null,
	Birth date not null,
	Role varchar(15) not null,
	Salary decimal(10,2) not null,
	UserName varchar(25) not null,
	PasswordHash varbinary(64) not null,
	IsDeleted bit not null default 1
)
go
create table Customer
(
	CustomerID int identity(1,1) primary key,
	CustomerName nvarchar(100) not null,
	Address varchar(100) null,
	Phone varchar(15) not null,
	IsDeleted bit not null default 1
)
go
create table Category 
(
	CategoryId int identity(1,1) primary key,
	CategoryName nvarchar(100) not null,
	Description nvarchar(200) null,
)
go
create table Supplier 
(
	SupplierID int identity(1,1) primary key,
	SupplierName nvarchar(100) not null,
	Phone varchar(15) not null,
	Address nvarchar(100)
)
go	
create table Products 
(
	ProductID int identity(1,1) primary key,
	ProductName nvarchar(100) not null,
	CategoryID int not null,
	SupplierID int not null,
	Price decimal(10,2) not null,
	Stockquantity int not null,
	IsDeleted bit not null default 1
	constraint FK_Product_Category foreign key (CategoryID) references Category(CategoryID),
	constraint FK_Product_Supplier foreign key (SupplierID) references Supplier(SupplierID)
)
go
create table Orders 
(
	OrderID int identity(1,1) primary key,
	CustomerID int not null,
	EmployeeID int not null,
	OrderDate datetime not null,
	TotalAmount decimal(10,2),
	StatusPay varchar(15) not null,
	IsDeleted bit not null default 1
	constraint FK_Order_Customer foreign key(CustomerID) references Customer(CustomerID),
	constraint FK_Order_Employee foreign key(EmployeeID) references Employee(EmployeeID)
)
go 
create table OrderDetail
(
	OrderID int not null,
	ProductID int not null,
	Quantity int not null,
	UnitPrice decimal(10,2) not null,
	IsDeleted bit not null default 1
	Primary key (OrderID,ProductID)
)
go
alter table OrderDetail 
add constraint FK_OrderDetail_Order foreign key(OrderID) references Orders(OrderID)

alter table OrderDetail
add constraint FK_Product_OrderDetail foreign key(ProductID) references Products(ProductID)


insert into Customer (CustomerName,Address,Phone) values ('Employee 01','Thai Ha,Dong Da, HN','0987 452 310')
insert into Customer (CustomerName,Address,Phone) values ('Employee 02','Mai Dich,Cau Giay, HN','0916 803 742')
insert into Customer (CustomerName,Address,Phone) values ('Employee 03','Le Van Luong,Thanh Xuan, HN','0854 229 667')
insert into Customer (CustomerName,Address,Phone) values ('Employee 04','Hang Bong,Hoan Kiem, HN','0962 718 405')
insert into Customer (CustomerName,Address,Phone) values ('Employee 05','Phan Dinh Hung,Ba Dinh, HN','0903 564 128')
insert into Customer (CustomerName,Address,Phone) values ('Employee 06','Ton Duc Thang,Dong Da, HN','0889 347 950')



insert into Employee (EmployeeName,Birth,Role,Salary,UserName,PasswordHash)
values ('Pham Anh Duc','20060210','Admin',1000,'admin',HASHBYTES('SHA2_256','Admin@123'))

insert into Employee (EmployeeName,Birth,Role,Salary,UserName,PasswordHash)
values ('Staff 01','19990307','Staff',200,'staff01',HASHBYTES('SHA2_256','staff01pass'))

insert into Employee (EmployeeName,Birth,Role,Salary,UserName,PasswordHash)
values ('WareHouse Staff','','WareHouse',100,'WarehouseStaff00',HASHBYTES('SHA2_256','warehouse00pass'))

	
insert into Category (CategoryName,Description) values ('Electronics','smartphones, tablets, laptops, smart home devices,..')
insert into Category (CategoryName,Description) values ('Fashion','clothing, footwear, bags, fashion,..')
insert into Category (CategoryName,Description) values ('Health','vitamins, supplements, fitness equipment,..')
insert into Category (CategoryName,Description) values ('Home Appliances','rice cookers, blenders, electric stoves,..')


insert into Supplier (SupplierName,Phone,Address) values('The Gioi Di Dong','0902 123 456','20 Nguyen Van Cu Street, Ward 1, District 5, Ho Chi Minh')
insert into Supplier (SupplierName,Phone,Address) values('Sophie Paris Vietnam','0917 890 123','123 Le Duan Street, Ben Nghe Ward, District 1, Ho Chi Minh')
insert into Supplier (SupplierName,Phone,Address) values('Savimex','0983 567 890','45 Phan Dang Luu Street, Ward 5, Phu Nhuan District, Ho Chi Minh')

insert into Products (ProductName,CategoryID,SupplierID,Price,Stockquantity) values ('iphone',1,1,1205,10)
insert into Products (ProductName,CategoryID,SupplierID,Price,Stockquantity) values ('bag',2,2,545,4)
insert into Products (ProductName,CategoryID,SupplierID,Price,Stockquantity) values ('blender',4,1,50,13)

select p.ProductName,c.CategoryName,s.SupplierName,p.Price,p.Stockquantity
from Products p 
join Category c on p.CategoryID=c.CategoryId
join Supplier s on p.SupplierID=s.SupplierID
where p.IsDeleted =1 

Update Products set ProductName='Update Product',CategoryID='4',SupplierID='3',Price=99,Stockquantity=1
				Where ProductID=8
select o.OrderID,c.CustomerName,e.EmployeeName,o.OrderDate,o.TotalAmount,o.StatusPay
from Orders o
join Customer c on o.CustomerID=c.CustomerID
join Employee e on o.EmployeeID=e.EmployeeID
where o.IsDeleted =1

insert into Orders (CustomerID,EmployeeID,OrderDate,TotalAmount,StatusPay)
values ((Select CustomerID from Customer where CustomerName='Customer 01'),1,GETDATE(),100,'UnPaid')


select p.ProductName, od.Quantity, od.UnitPrice,od.Quantity * od.UnitPrice AS TotalAmount
from OrderDetail od
join Products p on od.ProductID=p.ProductID
join Orders o on od.OrderID=o.OrderID
where od.IsDeleted=1 and o.OrderID =1

insert into OrderDetail (OrderID,ProductID,Quantity,UnitPrice) values (1,9,1,(select Price from Products where ProductID=9))

update OrderDetail set Quantity=1,UnitPrice=(select Price from Products where ProductID=4)
where OrderID=1 and ProductID=4

