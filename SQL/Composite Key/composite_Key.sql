Composite Key:

A composite key is made by the combination of two or more columns in a table that can be used to uniquely identify each row in the table when the columns are combined uniqueness of a row is guaranteed, but when it is taken individually it does not guarantee uniqueness, or it can also be understood as a primary key made by the combination of two or more attributes to uniquely identify every row in a table. 

Note: 

 A composite key can also be made by the combination of more than one candidate key.
A composite key cannot be null.


*EX - 

create table Student1
(RollNo int,
Name varchar(50),
Class int ,
Section varchar(10),
Mobile bigint,
primary key (RollNo,Mobile));

insert into Student1 values
(1,'Sujit',12,'A',9579120646),
(1,'Sujit',12,'A',7499970761),
(2,'Trish',12,'A',1234567890),
(3,'Chetan',12,'A',1234512345),
(4,'Lucky',12,'A',54332154321),
(4,'Lucky',12,'A',9876543210);

select * from Student1




