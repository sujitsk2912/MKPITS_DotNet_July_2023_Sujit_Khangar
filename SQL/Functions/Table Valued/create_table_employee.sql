create table Employee
(EmpId int, EmpName varchar(20),Contact bigint,Email varchar(20),Department varchar(20),City varchar(20), Salary int); 

insert into Employee values
(1,'Sagar',1234567890,'xyz@gmail.com','Civil','Nagpur',15000),
(2,'Suraj',1234567890,'xyz@gmail.com','Mechanical','Delhi',20000),
(3,'raj',1234567890,'xyz@gmail.com','Electronics','Mumbai',25000),
(4,'Roshan',1234567890,'xyz@gmail.com','Civil','Delhi',13000),
(5,'Bhushan',1234567890,'xyz@gmail.com','Electronics','Nagpur',20000);

select * from Employee

create function f1()
returns table 
as
return( select * from Employee)

select * from f1()

