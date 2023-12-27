
  create table Product
  (ProductId int primary key,
  ProductName varchar(50),
  Price decimal(10,2),
  Quantity int);

 insert into Product values
(1,'Laptop',65000,3),
(2,'keyboard',500,10),
(3,'mouse',300,10),
(4,'Display',20000,5),
(5,'Fax',5000,3),
(6,'Printer',8000,6);

select * from Product

DECLARE 
@ProductName varchar(50),
@Price decimal;

DECLARE cursor2 CURSOR
FOR SELECT
ProductName, Price
FROM Product;

OPEN cursor2;

FETCH NEXT FROM cursor2 INTO
@ProductName ,
@Price;

WHILE @@FETCH_STATUS = 0
BEGIN
PRINT @ProductName + ' ' + CAST(@Price as Varchar(50))
FETCH NEXT FROM cursor2 INTO
@ProductName,
@Price;

END;

CLOSE cursor2;

DEALLOCATE cursor2;