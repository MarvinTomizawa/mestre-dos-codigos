-- cartões do usuario
select 
	cc.id as id, 
	iu.id as id_usuario,
	iu.username as nome_usuario,
	cc."name" as nome_cartao, 
	c1.bank_name  as bank_name, 
	cc.created_at as created_at, 
	'Credito' as card_type
from credit_card cc 
inner join card c1 on c1.id  = cc.card_id 
inner join investment_user iu on iu.id  = c1.user_id 
where cc.deleted_at is null
and c1.deleted_at  is null
union
select 
	dc.id  as id,
	iu.id as id_usuario,
	iu.username as nome_usuario,
	dc."name" as nome_cartao, 
	c2.bank_name as bank_name,
	dc.created_at as created_at,
	'Debito' as card_type
from debit_card dc 
inner join card c2 on c2.id  = dc.card_id 
inner join investment_user iu on iu.id  = c2.user_id
where dc.deleted_at is null
and c2.deleted_at  is null

-- Cartões apenas de crédito
select 
	cc.id as id, 
	iu.id as id_usuario,
	iu.username as nome_usuario,
	cc."name" as nome_cartao, 
	c1.bank_name  as bank_name, 
	cc.created_at as created_at, 
	'Credito' as card_type
from credit_card cc 
inner join card c1 on c1.id  = cc.card_id 
inner join investment_user iu on iu.id  = c1.user_id 
left join debit_card dc on dc.card_id = c1.id 
where dc.id is null

-- Cartões apenas de crédito que também possuem opção de debito
select 
	cc.id as id, 
	iu.id as id_usuario,
	iu.username as nome_usuario,
	cc."name" as nome_cartao, 
	c1.bank_name  as bank_name, 
	cc.created_at as created_at, 
	'Credito' as card_type
from credit_card cc 
inner join card c1 on c1.id  = cc.card_id 
inner join investment_user iu on iu.id  = c1.user_id 
right join debit_card dc on dc.card_id = c1.id 

-- Dia que teve as pelo menos 1 registro em cada uma das 3 operações
select "day", "month", "year" from income 
intersect
select "day", "month", "year" from purchase 
intersect
select "day", "month", "year" from lending 

-- Dia que teve apenas compras
-- Tive que utilizar except em vez de minus por conta de estar utilizando postgres
select "day", "month", "year" from purchase
except
select "day", "month", "year" from income 
except
select "day", "month", "year" from lending