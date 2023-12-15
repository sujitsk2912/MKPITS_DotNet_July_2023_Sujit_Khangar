-- on delete cascade is delete table from parent table (i.e orders) which orderid is selected

create table orders
(orderid int identity primary key,
odrerDate date not null, customerId int not null);

create table order_Details
(orderid int not null, productName varchar(50) not null, quanity int not null,
price int not null,
constraint FK2 foreign key (orderId)
references orders(orderId)
on delete cascade)

insert into orders values ('2023-12-15',102)
insert into orders values ('2023-12-18',203)

insert into order_Details values(1,'keyboard',5,500)
insert into order_Details values(2,'Mouse',3,400)
insert into order_Details values(1,'display',7,1000)
insert into order_Details values(2,'display',7,1000)
insert into order_Details values(1,'mouse',7,400)

select * from orders
select * from order_Details

delete from orders where orderid = 1

select * from orders
select * from order_Details

drop table orders
drop table order_Details


