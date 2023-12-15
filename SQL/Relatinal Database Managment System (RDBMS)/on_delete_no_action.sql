-- on delete no action is delete similar rows from child table (i.e order_details) which orderid is selected

create table orders
(orderid int identity primary key,
odrerDate date not null, customerId int not null);

create table order_Details
(orderid int not null , productName varchar(50) not null, quanity int not null,
price int not null,
constraint FK2 foreign key (orderId)
references orders(orderId)
on delete NO ACTION)

insert into orders values ('2023-12-15',102)
insert into orders values ('2023-12-18',203)

insert into order_Details values(1,'keyboard',5,500)
insert into order_Details values(2,'Mouse',3,400)
insert into order_Details values(1,'display',7,1000)
insert into order_Details values(2,'display',7,1000)
insert into order_Details values(1,'mouse',7,400)

select * from orders
select * from order_Details

delete from order_Details where orderid = 1

select * from orders
select * from order_Details

drop table orders
drop table order_Details


