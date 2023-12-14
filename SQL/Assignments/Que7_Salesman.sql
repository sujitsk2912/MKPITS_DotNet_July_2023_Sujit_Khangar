*Que 7 - From the following table, write a SQL query to find the orders, 
which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt. 

*sol -

create table salesman1 
(ordNo int, purcAmt float, ordDate date, customerId numeric(18,0), salesmanId numeric(18,0))

insert into salesman1 values

(70001,150.5,'2012-10-05',3005,5002),
(70009,270.65 ,'2012-09-10',3001,5005),
(70002,65.26,'2012-10-05',3002,5001),
(70004,110.5,'2012-08-17',3009,5003),
(70007,948.5,'2012-09-10 ',3005,5002),
(70005,2400.6,'2012-07-27 ',3007,5001);

select * from salesman1 

select salesmanId, ordNo, ordDate, purcAmt from salesman1 where salesmanId = 5001 order by salesmanId, ordNo, ordDate, purcAmt;