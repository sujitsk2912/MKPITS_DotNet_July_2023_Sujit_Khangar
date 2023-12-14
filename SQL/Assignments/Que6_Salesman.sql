      * Que 6 - From the following table, write a SQL query to find those customers whose
        grade is 200. Return customer_id, cust_name, city, grade, salesman_id.
       
       *sol -
       
       create table customer1
	   (customerId int, name varchar(50), city varchar(50), grade int, salesmanId int)
	   
	   insert into customer1 values
	   (3002,'Nick Rimando','New York',100,5001),
       (3007,'Brad Davis','New York',200,5001),
       (3005,'Graham Zusi','California',200,5002),
       (3008,'Julian Green','London',300,5002),
       (3004,'Fabian Johnson','Paris',300,5006),
       (3009,'Geoff Cameron','Berlin',100,5003),
       (3003,'Jozy Altidor','Moscow',200,5007);

	   select * from customer1 where grade = 200;
