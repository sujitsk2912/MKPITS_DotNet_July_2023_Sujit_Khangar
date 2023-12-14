* Que 4- From the following table, write a SQL query to find the unique salespeople ID.
 Return salesman_id.   

 *sol -
 
create table Testdb.dbo.salesman1 
(ordNo int, purcAmt float, ordDate date, customerId numeric(18,0), salesmanId numeric(18,0))

insert into salesman1 values

(70001,150.5,'2012-10-05',3005,5002),
(70009,270.65 ,'2012-09-10',3001,5005),
(70002,65.26,'2012-10-05',3002,5001),
(70004,110.5,'2012-08-17',3009,5003),
(70007,948.5,'2012-09-10 ',3005,5002),
(70005,2400.6,'2012-07-27 ',3007,5001);

select * from Testdb.dbo.salesman1 

select distinct salesmanId from salesman1