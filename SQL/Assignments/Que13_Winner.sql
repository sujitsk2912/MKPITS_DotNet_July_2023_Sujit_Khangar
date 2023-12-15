*Que 13 - Write a SQL query to show all details of the Physics 
winners after 1972 of Louis Neel and Ulf von Euler 

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

select years, Winners, Subject, Country from winner where years between  1965 and 1975 and Subject = 'Chemistry' order by years, Winners, Subject, Country
                                

select * from Winner where years > 1972 or Winners = 'Louis Neel' and Winners = 'Ulf von Euler';