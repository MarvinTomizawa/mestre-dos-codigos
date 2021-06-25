SELECT 
	vendedor.nome as nome_vendedor, 
	cliente.nome  as nome_cliente,
	count(vendas.id) as quantidade_vendas,
	sum(vendas.totalvenda) as valor_total_vendido
FROM vendedor vendedor
inner join vendas vendas on vendedor.id  = vendas.vendedorID 
inner join cliente cliente on cliente.id  = vendas.clienteID 
group by vendedor.nome, cliente.nome 
order by vendedor.nome