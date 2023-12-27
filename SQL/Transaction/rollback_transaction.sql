
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
  update product1 set productName = 'Pen' where productId = 3
  DELETE from product1 where productId = 6
  ROLLBACK TRANSACTION

    select * from product1;

