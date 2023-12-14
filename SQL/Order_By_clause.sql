* Introduction to the SQL Server ORDER BY clause

When you use the SELECT statement to query data from a table, the order of rows in the result set is not guaranteed. It means that SQL Server can return a result set with an unspecified order of rows.


The only way for you to guarantee that the rows in the result set are sorted is to use the ORDER BY clause.
The following illustrates the ORDER BY clause syntax:

syntax: 

SELECT
    select_list
FROM
    table_name
ORDER BY

*Ex - 

SELECT * FROM Students
ORDER BY firstname

----------------------------------------

ASC | DESC (Ascending | Descending)

The following statement sorts the customer list by the first name in ascending order:

* A. Sort a result set by one column in ascending order

*Ex - 

SELECT * FROM Students
ORDER BY firstname ASC 

-----------------------------------------------------

* B. Sort a result set by one column in Descending order

*Ex - 

SELECT * FROM Students
ORDER firstname DESC

----------------------------------------------------

*SQL Server ORDER BY - sort by two columns

* C. Sort a result set by multiple columns and different orders

*Ex -

SELECT firstname , lastname 
FROM students
ORDER BY
firstname ASC,
lastname DESC

---------------------------------------------------------

*SQL Server ORDER BY - sort by two columns in differnt orders
*D . Sort a result set by a column that is not in the select list

It is possible to sort the result set by a column that does not appear on the select list.

*Ex - 

SELECT firstname , lastname 
FROM students
ORDER BY
RollNo DESC

---------------------------------------------

*E. Sort a result set by an expression

The LEN() function returns the number of characters of a string.
The following statement uses the LEN() function in the ORDER BY clause to retrieve 
a customer list sorted by the length of the first name.

SELECT firstname , lastname 
FROM students
ORDER BY
LEN(firstname) DESC

------------------------

