create table Vender_group
(group_id int identity primary Key,
group_name varchar(50) not null);

create table Vender_table
(vender_id int,
vender_name varchar(50) not null,
group_id int not null);

insert into Vender_group values ('Product1')
insert into Vender_group values ('Product2')
insert into Vender_group values ('Product3')

insert into Vender_table values('ProductID1',1)
insert into Vender_table values('ProductID2',2)
insert into Vender_table values('ProductID3',3)
insert into Vender_table values('ProductID4',4)

select * from Vender_group
select * from Vender_table
