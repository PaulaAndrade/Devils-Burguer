use devils_burger;
truncate table tb_cardapio;
insert into tb_cardapio (nomeproduto, tipo, preco) VALUES
('Hambúrguer do Diabo', 'principal', 25.95),
('Batata Frita Labareda', 'principal', 12.50),
('Devil Duplo', 'principal', 35.95),
('Vegan Devils', 'principal', 30.00),
('Batata Frita Pecado Infernal', 'principal', 17.50),
('Burguer Gula Infernal', 'principal', 30.50),
('Combo Infernal', 'combo', 40.00),
('Salada', 'principal', 15.55),
('Refrigerante de Guaraná 350 Ml', 'bebida', 6.00),
('Refrigerante de Uva 350 Ml', 'bebida', 6.00),
('Suco de Laranja 350 Ml', 'bebida', 5.00),
('Suco de Laranja 650 Ml', 'bebida', 9.00),
('Suco de Maracujá 350 Ml', 'bebida', 5.00),
('Suco de Maracujá 650 Ml', 'bebida', 9.00),
('Suco de Morango e Laranja 350 Ml', 'bebida', 5.50),
('Suco de Morango e Laranja 650 Ml', 'bebida', 10.00),
('Brigadeiro no Pote', 'sobremesa', 7.00),
('Milkshake Chocolate', 'sobremesa', 9.50),
('Milkshake Baunilha', 'sobremesa', 9.50),
('Milkshake Misto Tematizado', 'sobremesa', 10.00),
('Pudim', 'sobremesa', 6.50),
('Mousse de Maracujá', 'sobremesa', 5.00)
select * from tb_cardapio;