CREATE TABLE Customers1
                      (Customer_ID INT,
					  Customer_Name VARCHAR(100),
					  City VARCHAR(100),
					  Grade INT,
					  Salesman_ID INT)

INSERT INTO Customers1 VALUES(3002,'Nick Rimando','New York',100,5001),
                             (3007,'Brad Davis','New York',200,5001),
                             (3005,'Graham Zusi','California',200,5002),
                             (3008,'Julian Green','London',300,5002),
                             (3004,'Fabian Johnson','Paris',300,5006),
                             (3009,'Geoff Cameron','Berlin',100,5003),
                             (3003,'Jozy Altidor','Moscow',200,5007),
                             (3001,'Brad Guzan','London',NULL,5005)

SELECT * FROM Customers1
---------------------------------
CREATE TABLE Salesman1
                      (Salesman_ID INT,
					   Name VARCHAR(100),
					   City VARCHAR(100),
					   Commision FLOAT)
					  
INSERT INTO Salesman1 VALUES(5001,'james Hoog','New York',0.15),
                            (5002,'Nail Knite','Paris',0.13),
							(5005,'Pit Alex','London',0.11),
							(5006,'Mc Lyon','Paris',0.14),
							(5003,'Lauson Hen','San Jose', 0.12),
							(5007,'Paul Adam','Rome',0.13)

SELECT * FROM Salesman1
-----------------------------------------
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
--------------------------------------------
--Q18
SELECT * FROM Salesman1 a
WHERE EXISTS (SELECT * FROM Customers1 b WHERE a.Salesman_ID = b.Salesman_ID AND 1 < (SELECT COUNT (*) FROM Order2 WHERE Order2.Customer_ID = b.Customer_ID));
