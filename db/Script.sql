insert into trades(Value,IdSector,IdCategory)
values
	(2000000,2,null),
	(400000,1,null),
	(500000,1,null),
	(3000000,1,null)

update t
set t.idcategory = case 
					when t.Value < 1000000 and t.IdSector = 1 then 1
					when t.Value > 1000000 and t.IdSector = 1 then 2
					when t.Value > 1000000 and t.IdSector = 2 then 3
				   end
from trades t

select t.value,s.Name Sector,c.Name Category
from trades t
join sectors s on s.id = t.idsector
join categories c on c.id = t.idcategory
order by c.Id