use devils_burger
select * from tb_cardapio
select c.nomeproduto as produto, c.preco, sum(i.quantidade) as quantia from tb_cardapio c left join tb_itens_pedido i on c.idproduto = i.idproduto group by c.nomeproduto, c.preco order by quantia desc