create table Vender_group 
(group_id int identity primary Key,
group_name varchar(50) not null);

create table Vender_table
(vender_id int,
vender_name varchar(50) not null,
group_id int not null);

select * from Vender_group
select * from Vender_table