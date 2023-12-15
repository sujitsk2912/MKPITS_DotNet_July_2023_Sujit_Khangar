*Que 11 - From the following table, write a SQL query to find the Nobel Prize 
winners in 'Physics' since the year 1950. Return winner.

*sol - 

insert into Winner values 
(1950,'Physics','Louis Neel','France','Scientist'),
(1970,'Physics','Hannes Alfven','Sweden','Scientist'),
(1970,'Physics','Louis Neel','France','Scientist'),
(1972,'Chemistry','Luis Federico Leloir','France','Scientist'),
(1970,'Physiology','Ulf von Euler','Sweden','Scientist'),
(1973,'Physiology','Bernard Katz','Germany','Scientist'),
(1971,'Literature','Aleksandr Solzhenits','Russia','Linguist'),
(1970,'Economics','Paul Samuelson','USA','Scientist'),
(1950,'Physics','Louis Neel','France','Scientist');

select * from Winner

select Winners from winner where years = 1950 and Subject = 'Physics' order by Winners

