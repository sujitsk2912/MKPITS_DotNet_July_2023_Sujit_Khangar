*Que 2 - Write a SQL statement to display specific columns like name and commission for all the salesmen.    

* sol -

create table Salesman
(salesman_id int, name varchar(50), city varchar(50), commision float)

insert into Salesman values
(5001 ,'James Hoog','New York ',0.12),
(5002,'Nail Knite','Paris    ',0.23),
(5005,'Pit Alex','London   ',0.43),
(5006,'Mc Lyon','Paris    ',0.32),
(5007,'Paul Adam','Rome     ',0.87),
(5003,'Lauson Hen','San Jose ',0.15);

select name, commision from Salesman order by name , commision
 