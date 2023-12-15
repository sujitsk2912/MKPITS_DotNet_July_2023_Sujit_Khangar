*Que 10 - create table Winner 
(years int , Subject varchar(20), Winners varchar(20), Country varchar(20), Category varchar(20))

*sol - 

insert into Winner values
(1970,'Physics','Hannes Alfven','Sweden','Scientist'),
(1970,'Physics','Louis Neel','France','Scientist'),
(1972,'Chemistry','Luis Federico Leloir','France','Scientist'),
(1970,'Physiology','Ulf von Euler','Sweden','Scientist'),
(1973,'Physiology','Bernard Katz','Germany','Scientist'),
(1971,'Literature','Aleksandr Solzhenits','Russia','Linguist'),
(1970,'Economics','Paul Samuelson','USA','Scientist');

select * from Winner

select years, Subject from winner where winners = 'Bernard Katz' order by years, Subject

