create table TableProductGSTDetails
(Product_GST_ID int primary key,
GST_Detail_Name varchar(500),
CGST Decimal,
SGST Decimal,
IGST Decimal);


create table TableProductCategory
(Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_GST_ID int
constraint FK foreign key (Product_GST_ID)
references TableProductGSTDetails (Product_GST_ID));


create table TableProduct
(ProductID int primary key,
ProductTypeID int,
Product_Name varchar(500));


Create table TableInvoiceDetails
(Invoice_Detail_ID int,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int
constraint FK2 foreign key (Product_Category_ID)
references TableProductCategory (Product_Category_ID) ,
ProductID int
constraint FK1 foreign key (ProductID)
References TableProduct(ProductID),
Residential_Type_ID int,
Invoice_Date Datetime,
Quantity Decimal,
Price Decimal,
CGST Decimal,
SGST Decimal,
IGST Decimal,
CGST_Value Decimal,
SGST_Value Decimal,
IGST_Value Decimal,
Total_Amount Decimal);


insert into TableProductGSTDetails values(1,'Keyboard',50,100,110);
insert into TableProductGSTDetails values(2,'Mouse',50,100,110);
insert into TableProductGSTDetails values(3,'Laptop',50,100,110);
insert into TableProductGSTDetails values(4,'Monitor',50,100,110);
insert into TableProductGSTDetails values(5,'Printer',50,100,110);


insert into TableProductCategory values(11,'Keyboard',1);
insert into TableProductCategory values(12,'Mouse',2);
insert into TableProductCategory values(13,'Laptop',3);
insert into TableProductCategory values(14,'Monitor',4);
insert into TableProductCategory values(15,'Printer',5);


insert into TableProduct Values (101,1001,'Keyboard');
insert into TableProduct Values (102,1002,'Mouse');
insert into TableProduct Values (103,1003,'Laptop');
insert into TableProduct Values (104,1004,'Monitor');
insert into TableProduct Values (105,1005,'Printer');


insert into TableInvoiceDetails values(501,'Lucky',1234567890,11,101,999,'2023-12-29',1,500,5,10,11,505,5010,5110,5800);
insert into TableInvoiceDetails values(502,'Chetan',1234567890,12,102,888,'2023-12-24',1,300,5,10,11,305,5010,5011,5500);
insert into TableInvoiceDetails values(503,'David',1234567890,13,103,777,'2023-12-21',1,65000,5,10,11,65005,65010,5101,65600);
insert into TableInvoiceDetails values(504,'Sujit',1234567890,14,104,666,'2023-12-25',1,3000,5,10,11,3005,5010,5110,5500);
insert into TableInvoiceDetails values(505,'David',1234567890,15,105,555,'2023-12-26',1,5000,5,10,11,5005,50100,511,5500);


select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails

