Introduction to SQL Server SELECT TOP

The SELECT TOP clause allows you to limit the number of rows or percentage of rows returned in a query result set.

Because the order of rows stored in a table is unspecified, the SELECT TOP statement is always used in conjunction with the ORDER BY clause. Therefore, the result set is limited to the first N number of ordered rows.

*The following shows the syntax of the TOP clause with the SELECT statement:

syntax: 

SELECT TOP (expression) [PERCENT]
    [WITH TIES]
FROM 
    table_name
ORDER BY 
    column_name;


*Ex -

insert into product values
(4,'Display','20000',5),
(5,'Fax','5000',3),
(6,'Printer','8000',6);

select * from product

SELECT  TOP 3 productName, Price FROM product
ORDER BY
price DESC

select * from product

--------------------------------------------------

*SQL Server SELECT TOP - top ten most expensive products

2. Using TOP to return a percentage of rows

The following example uses PERCENT to specify the number of products returned in the 
result set. The production.products table has 321 rows, therefore, 
one percent of 321 is a fraction value ( 3.21), SQL Server rounds it up to the 
next whole number which is four ( 4) in this case.

*Ex - 

SELECT  TOP 3 PERCENT productName, Price 
FROM product
ORDER BY
price DESC

-----------------------------------------------------------------
