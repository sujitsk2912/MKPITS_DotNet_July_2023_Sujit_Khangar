A. SQL Server SELECT – retrieve some columns of a table example

* The following query finds the first name and last name of all customers:

SELECT
    first_name,
    last_name
FROM
    customers;


*Ex-

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');

select firstname from Students;

--------------------------------------

B. SQL Server SELECT – retrieve all columns from a table example

To get data from all table columns, you can specify all the columns in the select list. You can also use SELECT * as a shorthand to save some typing:

SELECT
    *
FROM
    customers;

*Ex-

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');

select * from Students;

-------------------------------------

C. SQL Server SELECT – sort the result set 

*Ex-

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');

select * from Students order by firstname

-------------------------------------------

in descending order

*Ex -

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');
 
select * from Students order by lastname desc

----------------------------------------------

in Ascending order

*Ex -

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');
 
select * from Students order by lastname asc

--------------------------------------------

select by columns in ascending order

*Ex- 

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');
 
select lastname from Students order by lastname asc

-----------------------------------------------------

select by columns in descending order

*Ex- 

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');
 
select firstname from Students order by firstname, lastname desc
--------------------------------------------

D. To filter rows based on one or more conditions, you use a WHERE clause as shown in the following example:

--query to find records whose name is Sahil

*Ex-

create table Students
(RollNo int primary key, firstname varchar(20), lastname varchar(20))

select * from Students

insert into Students values 
(1,'Sujit','Khangar'),
(2,'trishala','Khangar'),
(3,'Trishala','Bhisikar'),
(4,'Sahil','Mirase'),
(5,'Chetan','Raut');
 
select * from Students where firstname = 'Sahil'; 

------------------------------------------------
