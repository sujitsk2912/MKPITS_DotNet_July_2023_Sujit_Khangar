create database FendahlMT2

create table TableProductGSTDetails
(Product_GST_ID int primary key,
GST_Detail_Name varchar(500),
CGST decimal(18,2),
SGST decimal (18,2),
IGSt decimal(18,2));

insert into TableProductGSTDetails values (5001,'Ac and Fridge',14,14,14);
insert into TableProductGSTDetails values (5002,'Computer',9,9,9);
insert into TableProductGSTDetails values (5003,'Printer',8,8,8);
insert into TableProductGSTDetails values (5004,'Mobile',6,6,6);


create table TableProductCategory
(Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_GST_ID int foreign key references TableProductGSTDetails (Product_GST_ID) );

insert into TableProductCategory values (1001,'Ac and Fridge',5001);
insert into TableProductCategory values (1002,'Cumputers',5002);
insert into TableProductCategory values (1003,'Printer',5003);
insert into TableProductCategory values (1004,'Mobile',5004);


create table TableProduct
(ProductID int identity (401,1) primary key,
ProductName varchar(500),
Product_Category_ID int foreign key references TableProductCategory (Product_Category_ID),
ProductPrice decimal (18,2));

insert into TableProduct values ('Apple',1004,80000);
insert into TableProduct values ('Lenovo',1004,40000);
insert into TableProduct values ('LG',1003,20000);
insert into TableProduct values ('Huwai',1003,10000);
insert into TableProduct values ('Asus',1002,150000);
insert into TableProduct values ('Mac',1002,90000);
insert into TableProduct values ('Samsung',1001,30000);
insert into TableProduct values ('Panasonic',1001,25000);

create table TableInvoiceDetails
(Invoice_Detail_ID int,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int foreign key references TableProductCategory (Product_Category_ID),
Product_ID int foreign key references TableProduct (ProductID),
Residential_Type_ID int,
Invoice_Date datetime,
Quantity decimal (18,2),
Price decimal (18,2),
CGST decimal (18,2),
SGST decimal (18,2),
IGST decimal (18,2),
CGST_Value decimal (18,2),
SGST_Value decimal (18,2),
IGST_Value decimal (18,2),
Total_Amount decimal (18,2))



select * from TableProductCategory
select * from TableProductGSTDetails
select * from TableProduct


select * from TableInvoiceDetails


drop table TableProduct
drop table TableProductCategory
drop table TableProductGSTDetails