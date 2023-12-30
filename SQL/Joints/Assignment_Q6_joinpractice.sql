CREATE TABLE EMPLOYEES
                      (EMPLOYEE_ID INT,
					   FIRST_NAME VARCHAR(100),
					   LAST_NAME VARCHAR(100),
					   EMAIL VARCHAR(100),
					   PHONE_NO VARCHAR(100),
					   HIRE_DATE DATE,
					   JOB_ID VARCHAR(100),
					   SALARY DECIMAL(10,2),
					   COMMISSION_PCT DECIMAL(10,2),
					   MANAGER_ID INT,
					   DEPARTMENT_ID INT)

INSERT INTO EMPLOYEES VALUES(100,'Steven','King','SKING','515.123.4567','2003-06-17','AD_PRES',24000,0,0,90)
INSERT INTO EMPLOYEES VALUES(101,'Neena','Kochhar','NKOCHHAR','515.123.4568','2005-09-21','AD_VP',17000,0,100,90),
                            (102,'Lex','De Haan','LDEHAAN','515.123.4569','2001-01-13','AD_VP',17000,0,100,90),
							(103,'Alexander','Hunold','AHUNOLD','590.423.4567','2006-01-03','IT_PROG',9000,0,102,60),
							(104,'Bruce','Ernst','BERNST','590.423.4568','2007-05-21','IT_PROG',6000,0,103,60),
							(105,'David','Austin','DAUSTIN','590.423.4569','2005-06-25','IT_PROG',4800,0,103,60),
							(106,'Valli','Pataballa','VPATABAL','590.423.4560','2006-02-05','IT_PROG',4800,0,103,60)

--Q6
SELECT * FROM Departments
SELECT * FROM EMPLOYEES

SELECT E.FIRST_NAME,E.LAST_NAME, D.DEPARTMENT_ID,D.DEPARTMENT_NAME FROM EMPLOYEES E
RIGHT OUTER JOIN Departments D
ON E.DEPARTMENT_ID=D.DEPARTMENT_ID;