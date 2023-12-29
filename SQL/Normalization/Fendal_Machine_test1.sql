Create table TableCourseRegDetail
(CourseRegID int primary key,
CategoryInd int,
FullName varchar(1500),
GenderInd int);

Create table TableNation
(NationID int primary key,
NationName varchar(500));

create table TableState
(StateID int primary key,
NationID int,
StateName varchar(500)
constraint FK1 foreign key (NationID)
references TableNation (NationID));

create table TableCity
(CityID int,
StateID int,
CityName varchar(500)
constraint Fk2 foreign Key (StateID)
references TableState (StateID));

Create table TableRegAddress
(RegAddressID int,
CourseregID int 
constraint FK3 foreign key (CourseRegID)
references TableCourseRegDetail(CourseRegID),
NationID int,
StateID int,
CityID int
constraint FK foreign key (NationID)
references TableNation(NationID));

Create table TableFeeDetail
(FeeID int,
CourseRegID int,
TotalAmount Decimal,
MinPer Decimal,
PaidAmount Decimal,
BalAmount Decimal,
PaidDate DateTime,
constraint FK4 foreign key (CourseRegID)
references TableCourseRegDetail(CourseRegID));


insert into TableCourseRegDetail values(101,1,'Sujit Khangar',1);
insert into TableCourseRegDetail values(102,2,'Lucky Tambe',2);
insert into TableCourseRegDetail values(103,3,'Chetan Raut',3);
insert into TableCourseRegDetail values(104,4,'David Kothe',4);
insert into TableCourseRegDetail values(105,5,'Sarang Prajapati',5);


insert into TableNation values(91,'India');
insert into TableNation values(132,'Uk');
insert into TableNation values(94,'Dubai');
insert into TableNation values(45,'Japan');
insert into TableNation values(86,'Italy');


insert into TableState values(111,91,'Maharashtra');
insert into TableState values(321,91,'Gujarat');
insert into TableState values(54,45,'Nepal');
insert into TableState values(76,132,'England');
insert into TableState values(23,86,'Rus');


insert into TableCity values(01,111,'Nagpur');
insert into TableCity values(02,111,'Bhandara');
insert into TableCity values(03,321,'Rajasthan');
insert into TableCity values(04,76,'Ney work');
insert into TableCity values(05,54,'katmandu');


insert into TableRegAddress values(12,101,91,111,2);
insert into TableRegAddress values(13,102,91,321,3);
insert into TableRegAddress values(14,103,45,54,5);
insert into TableRegAddress values(15,104,132,76,4);
insert into TableRegAddress values(16,105,91,111,1);


insert into TableFeeDetail values(1001,101,65000,50000,50000,15000,'2023-12-29');
insert into TableFeeDetail values(1002,102,65000,40000,40000,25000,'2023-12-24');
insert into TableFeeDetail values(1003,103,65000,34000,34000,31000,'2023-12-22');
insert into TableFeeDetail values(1004,104,65000,61000,61000,4000,'2023-12-28');
insert into TableFeeDetail values(1005,105,65000,64000,64000,1000,'2023-12-25');



select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail

