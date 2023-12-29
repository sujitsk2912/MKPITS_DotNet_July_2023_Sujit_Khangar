create table Customer_Details
(OrderId int,
OrderDate date,
CustId int,
ProductId int,
Rate decimal(10,2),
Quantity int,
City varchar(20),
State varchar(20)
primary key(OrderId,CustId,ProductId));

insert into Customer_Details values
(1,'2023-12-21',1001,101,50,5,'Nagpur','Maharashtra'),
(1,'2023-12-22',1001,102,60,10,'Nagpur','Maharashtra'),
(1,'2023-12-23',1001,103,70,5,'Nagpur','Maharashtra'),
(2,'2023-12-21',1002,101,50,5,'Mumbai','Maharashtra'),
(2,'2023-12-22',1002,102,60,10,'Mumbai','Maharashtra');

select * from Customer_Details

create table Cust 
(CustId int primary key,
City varchar(20),
State varchar(20),
OrderId int,
OrderDate date
);

insert into Cust values
(1001,'Nagpur','Maharashtra',1,'2023-12-21'),
(1002,'Mumbai','Maharashtra',2,'2023-12-21');

select * from Cust

create table State
(StateId int primary key,
State varchar(20));

insert into State values
(55,'Maharashtra'),
(56,'Maharashtra');

select * from State

create table City
(CityId int primary key,
City varchar(20),
StateId int);

insert into City values
(1,'Nagpur',55),
(2,'Mumbai',56);

select * from City

create table Product
(ProductId int primary key,
Rate decimal(10,2));

insert into Product values
(101,50),
(102,60),
(103,70);

select * from Product

SELECT * FROM Customer_Details
SELECT * FROM City
SELECT * FROM CUST
SELECT * FROM PRODUCT
SELECT * FROM STATE


<!--////////////////////////////////////////////////////////-->


create table Customer_Details
(OrderId int,
OrderDate date,
CustId int,
ProductId int,
Rate decimal(10,2),
Quantity int,
City varchar(20),
State varchar(20)
primary key(OrderId,CustId,ProductId));

insert into Customer_Details values
(1,'2023-12-21',101,1001,12,2,'Nagpur','Maharashtra'),
(1,'2023-12-21',101,1002,13,3,'Nagpur','Maharashtra'),
(1,'2023-12-21',101,1003,14,4,'Nagpur','Maharashtra'),
(2,'2023-12-22',102,1001,12,5,'Mumbai','Maharashtra'),
(2,'2023-12-22',102,1002,13,6,'Mumbai','Maharashtra');

select * from Customer_Details

create table Cust
(OrderId int,
OrderDate date,
CustId int,
City varchar(20),
State varchar(20)
primary key(OrderId,CustId));

insert into Cust values
(1,'2023-12-21',101,'Nagpur','Maharashtra'),
(2,'2023-12-22',102,'Nagpur','Maharashtra');

select * from Customer_Details
select * from Cust

create table Product
(OrderId int,
ProductId int,
Rate decimal (10,2),
Quantity int
primary key(OrderId,ProductId)
constraint Fk1 foreign key (OrderId)
references Cust (OrderId));

create table City_State
(OrderId int,
OrderDate Date,
CustId int ,
City Varchar(20),
primary key(OrderId,CustId));

insert into City_State values
(1,'2023-12-21',101,'Nagpur'),
(2,'2023-12-22',102,'Nagpur');

create table State
(CustId int primary key,
State varchar(20)
constraint fk3 foreign key (CustId)
references City_State (CustId));
