create table TableNation
(
NationID int primary key ,
NationName varchar(500) );

insert into TableNation values (1,'India');
insert into TableNation values (2,'Unites State');
insert into TableNation values (3,'Pakistan');

create table TableState
(StateID int primary Key ,
NationID int foreign key references TableNation (NationID),
StateName varchar(500));

insert into TableState values (50,1,'Maharashtra');
insert into TableState values (51,1,'Gujarat');
insert into TableState values (52,2,'America');
insert into TableState values (53,3,'lahore');
insert into TableState values (54,3,'Afganstan');


create table TableCity
(CityID int,
StateID int foreign key references TableState (StateID),
CityName varchar(500))

insert into TableCity values (201,50,'Nagpur');
insert into TableCity values (202,50,'Bhandara');
insert into TableCity values (203,51,'rajkot');
insert into TableCity values (204,52,'us');
insert into TableCity values (205,53,'lh');
insert into TableCity values (206,54,'af');




select * from TableNation
select * from TableState
select * from TableCity


create table TableCourseRegDetail
(CourseRegID int identity (101,1) primary key,
CategoryInd int,
FullName varchar(1500),
GenderInd int)

create table TableRegAddress
(RegAddressID int identity (501,1) ,
CourseRegID int foreign key references TableCourseRegDetail (CourseRegID),
NationID int foreign key references TableNation (NationID),
StateID int,
CityID int);

create table TableFeeDetail
(FeeID int identity (901,1),
CourseRegID int foreign key references TableCourseRegDetail (CourseRegID),
TotalAmount decimal (18,2),
MinPer decimal (18,2),
PaidAmount decimal (18,2),
BalAmount decimal (18,2),
PaidDate datetime
)

select * from TableCourseRegDetail order by CourseRegID
select * from TableRegAddress order by RegAddressID
select * from TableFeeDetail order by FeeID

drop table  TableFeeDetail 
drop table  TableRegAddress 
drop table TableCourseRegDetail 


drop table TableCity
drop table TableState
drop table TableNation



