*Que - create  a cursor to display records from customer table whose custdid  > 3

*Sol - 


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

select * from Product1

DECLARE 
@ProductId int,
@ProductName varchar(50),
@Price decimal,
@Quantity int;

DECLARE cursor2 CURSOR
FOR SELECT ProductId,ProductName, Price, Quantity FROM Product WHERE ProductId > 3;

OPEN cursor2;

FETCH NEXT FROM cursor2 INTO
@ProductId,
@ProductName ,
@Price,
@Quantity;

WHILE @@FETCH_STATUS = 0
BEGIN
PRINT CAST (@ProductId as varchar) + ' ' + @ProductName + ' ' + CAST(@Price as Varchar) + ' '+ CAST (@Quantity as varchar)
FETCH NEXT FROM cursor2 INTO
@ProductId,
@ProductName ,
@Price,
@Quantity;

END;

CLOSE cursor2;

DEALLOCATE cursor2;