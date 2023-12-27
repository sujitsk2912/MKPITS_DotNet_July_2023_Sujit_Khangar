
  create table Product1
  (ProductId int primary key,
  ProductName varchar(50),
  Price decimal(10,2),
  Quantity int);

 insert into Product1 values
(1,'Laptop',65000,3),
(2,'keyboard',500,10),
(3,'mouse',300,10),
(4,'Display',20000,5),
(5,'Fax',5000,3),
(6,'Printer',8000,6);

  select * from product1;

  BEGIN TRANSACTION
  insert into product1 values
  (7,'Television',4000,20)
  update product1 set productName = 'Oven' where productId = 5
  COMMIT TRANSACTION

    select * from product1;


