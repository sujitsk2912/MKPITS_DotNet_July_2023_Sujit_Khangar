* Introduction to SQL Server SELECT DISTINCT clause

Sometimes, you may want to get only distinct values in a specified column of a table. To do this, you use the SELECT DISTINCT clause as follows:

* A. DISTINCT one column example

syntax: 

SELECT DISTINCT
    column_name
FROM
    table_name;


*Ex -

insert into Students values
(6,'ram','ranjan'),
(7,'samir','kurkare'),
(8,'raj','wasnik'),
(9,'snehal','belkode'),
(10,'raj','teja');

select * from Students

select distinct firstname,lastname from students

-------------------------------------------------------

* The query returns only distinct values in the specified column. In other words, it removes the duplicate values in the column from the result set.

If you use multiple columns as follows:

* B. DISTINCT multiple column example

syntax: 

SELECT DISTINCT
	column_name1,
	column_name2 ,
	...
FROM
	table_name;


*Ex ->

insert into Students values
(6,'ram','ranjan'),
(7,'samir','kurkare'),
(8,'raj','wasnik'),
(9,'snehal','belkode'),
(10,'raj','teja');

select * from Students

select distinct firstname,lastname from students

---------------------------------------------------------------


