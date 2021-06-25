-- Utilizado postgres
-- Utilizado tabela do exercicio 1

with recursive cte as (
	select iu.id , iu.username, iu.id_refer_friend, 1 as "level"
	from investment_user iu
	where iu.id_refer_friend is null
union all 
	select iu.id , iu.username, iu.id_refer_friend, query.level + 1 as "level"
	from investment_user iu
	inner join cte query on query.id = iu.id_refer_friend 
)
select * from cte