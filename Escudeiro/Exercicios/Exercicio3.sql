-- Feito no postgres
-- Usuario que gastaram mais de mil reais no ano de 2021
select 
	iu.username as nome_usuario, 
	count(p.id) as quantidade_de_compras,
	sum(p.value) as valor_gasto_total,
	avg(p.value::numeric) as media_gasto, 
	count(p.value) FILTER(WHERE p.value > money(500)) AS compras_individuais_acima_500
from credit_card cc  
inner join card c on c.id = cc.card_id 
inner join purchase p on p.card_id  = c.id 
inner join investment_user iu on iu.id  = c.user_id 
where p."year" = 2021
	and p.status = 'payed'
	and p.deleted_at is null
group by iu.username