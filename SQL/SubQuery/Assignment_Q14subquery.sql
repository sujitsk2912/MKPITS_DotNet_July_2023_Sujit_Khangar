CREATE TABLE Order2
                    (Order_No INT,
				    Purch_Amount FLOAT,
					Order_Date DATE,
					Customer_ID INT,
					Salesman_ID INT)

INSERT INTO Order2 VALUES(70001,150.5,'2012-10-05',3005,5002),
                         (70009,270.65,'2012-09-10',3001,5005),
						 (70002,65.26,'2012-10-05',3002,5001),
						 (70004,110.5,'2012-08-17',3009,5003),
						 (70007,948.5,'2012-09-10',3005,5002),
						 (70005,2400.6,'2012-07-27',3007,5001),
						 (70008,5760,'2012-09-10',3002,5001),
						 (70010,1983.43,'2012-10-10',3004,5006),
						 (70003,2480.4,'2012-10-10',3009,5003),
						 (70012,250.45,'2012-06-27',3008,5002),
						 (70011,75.29,'2012-08-17',3003,5007),
						 (70013,3045.6,'2012-04-25',3002,5001)

SELECT * FROM Order2
-------------------------
--Q14
SELECT Order_Date , SUM (Purch_Amount) FROM Order2 a 
GROUP BY Order_Date 
HAVING SUM (Purch_Amount) > (SELECT 1000.00 + MAX(Purch_Amount) FROM Order2 b WHERE a.Order_Date = b.Order_Date);
