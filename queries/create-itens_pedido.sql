use devils_burger
create table tb_itens_pedido (
	id int identity(1,1) primary key,
	idpedido int,
	idproduto int,
	quantidade int,
	valor_unitario numeric(4, 2),
	valor_total numeric(6,2)
)