use devils_burger
create table tb_pedidos (
	id int primary key identity(1,1),
	id_garcom int,
	id_mesa int,
	valor_total numeric(5, 2) not null,
	situacao varchar(20) not null DEFAULT('A Fazer'),
	nome_pedido varchar(50) not null,
	observacoes varchar(255),
	idcliente int,
	adicionado datetime default(getdate()),
	alterado datetime default(getdate())
)