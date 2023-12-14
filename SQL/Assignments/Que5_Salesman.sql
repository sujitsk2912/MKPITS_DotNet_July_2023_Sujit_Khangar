*Que 5 - From the following table, write a SQL query to find the salespeople who lives in 
the City of 'Paris'. Return salespersons name, city. 

*sol - 

create table Salesman
(salesman_id int, name varchar(50), city varchar(50), commision float)

insert into Salesman values
(5001 ,'James Hoog','New York',0.12),
(5002,'Nail Knite','Paris',0.23),
(5005,'Pit Alex','London',0.43),
(5006,'Mc Lyon','Paris',0.32),
(5007,'Paul Adam','Rome',0.87),
(5003,'Lauson Hen','San Jose',0.15);

select city, name from Salesman where city = 'Paris' order by name;