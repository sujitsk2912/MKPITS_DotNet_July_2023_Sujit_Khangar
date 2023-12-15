
create table orders
(orderid int identity primary key,
odrerDate date not null, customerId int not null);

create table order_Details
(orderid int, productName varchar(50) not null, quanity int not null,
price int not null,
constraint FK2 foreign key (orderId)
references orders(orderId))

insert into orders values ('2023-12-15',102)
insert into orders values ('2023-12-18',203)

insert into order_Details values(1,'keyboard',5,500)
insert into order_Details values(2,'Mouse',3,400)
insert into order_Details values(1,'display',7,1000)


select * from orders
select * from order_Details

