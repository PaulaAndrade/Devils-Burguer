use devils_burger
create table tb_clientes( 
    cpf varchar(14) not null primary key, 
    nome varchar(60) not null, 
    data_nascimento date, 
    celular varchar(14) not null, 
    telefone varchar(14), 
    email varchar(60) not null, 
    cep varchar(9) not null,
    bairro varchar(30), 
    cidade varchar(40), 
    endereco varchar(30),
    complemento varchar(50)
);