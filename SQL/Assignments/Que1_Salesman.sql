* Que 1 - Write a SQL statement to display all the information of all salesmen.   

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

select * from Salesman