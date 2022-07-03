use devils_burger;
drop table tb_cardapio;
create table tb_cardapio (
	idproduto int primary key identity(1,1),
	nomeproduto varchar(50) not null,
	tipo varchar(15) not null,
	preco decimal(4, 2) not null,
	diretorio_foto varchar(255),
	vendidos int DEFAULT(0)
);
select * from tb_cardapio;