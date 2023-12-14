* Introduction to SQL Server WHERE clause

When you use the SELECT statement to query data against a table, you get all the rows of that table, which is unnecessary because the application may only process a set of rows at the time.

*To get the rows from the table that satisfy one or more conditions, you use the WHERE clause as follows:

syntax: 

SELECT
    select_list
FROM
    table_name
WHERE
    search_condition;


*Ex 1- 

* A. Finding rows by using a simple equality

SELECT price
FROM product
WHERE price = 300;

select * from product


*Ex 2- 

* Finding rows by using a simple equality

SELECT price, productName
FROM product
WHERE 
price = 300,
productName = 'Laptop';

select * from product

-------------------------------

* SQL Server WHERE - match two conditions

* B. Finding rows by using a comparison operator

*EX -

SELECT * FROM product
WHERE price > 4000 and
quantity > 4;

---------------------------------------------------

* SQL Server WHERE - comparison operators

* C. Finding rows that meet any of two conditions

*EX-

select * from product
where price > 4000 or
quantity > 4;

---------------------------------------------------

* SQL Server WHERE - match any of two conditions

Note that the OR operator combined the predicates.

* D. Finding rows with the value between two values

*EX 1-

create table YearDateMont
(Year_From varchar(50), Year_To varchar(50))

insert into YearDateMont values
(2000,2023),
(2004,2020),
(2005,2021),
(1992,1999),
(2002,2015)

select * from YearDateMont

select Year_From from YearDateMont where Year_From between '2000' and '2023'

select * from YearDateMont

--------------------------------------------------------------------

* SQL Server WHERE - between operator

* EX 2 -

create table attendance
(RollNo int, Name varchar(20), DOB date)

insert into attendance values
(1,'trishala','2001-09-21'),
(2,'chetan','2001-10-07'),
(3,'sujit','2001-12-29'),
(4,'lucky','2002-12-06'),
(5,'mayuri','2001-12-14');

select * from attendance

select DOB from attendance where DOB between '2001-10-27' and '2002-12-06'

-------------------------------------------------------------

* E . Finding rows that have a value in a list of values
query to show those records whose rno is not in 1 , 3 and 5

* Sol -

create table attendance
(RollNo int, Name varchar(20), DOB date)

insert into attendance values
(1,'trishala','2001-09-21'),
(2,'chetan','2001-10-07'),
(3,'sujit','2001-12-29'),
(4,'lucky','2002-12-06'),
(5,'mayuri','2001-12-14');

select * from attendance

select RollNo from attendance where RollNo not in (1,3,5) 

------------------------------------------------------------

* F. Finding rows that have a value in a list of values
query to show those records whose rno in 1 , 3 and 5

* Sol -

*Ex- 2

create table attendance
(RollNo int, Name varchar(20), DOB date)

insert into attendance values
(1,'trishala','2001-09-21'),
(2,'chetan','2001-10-07'),
(3,'sujit','2001-12-29'),
(4,'lucky','2002-12-06'),
(5,'mayuri','2001-12-14');

select * from attendance

select RollNo from attendance where RollNo in (1,3,5) 

----------------------------------------------------------------

* SQL Server WHERE - IN operator

* G. Finding rows whose values contain a string

* sol -

create table attendance
(RollNo int, Name varchar(20), DOB date)

insert into attendance values
(1,'trishala','2001-09-21'),
(2,'chetan','2001-10-07'),
(3,'sujit','2001-12-29'),
(4,'lucky','2002-12-06'),
(5,'mayuri','2001-12-14');

select * from attendance

select Name from attendance where Name like ('%sha%')

select Name from attendance where Name like ('s%t')

select Name from attendance where Name like ('c%t%n')







