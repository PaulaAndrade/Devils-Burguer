use devils_burger
SELECT
	TOP 1 sum(i.quantidade) as quantia, c.nomeproduto
FROM
	tb_cardapio c
INNER JOIN
	tb_itens_pedido i
ON
	i.idproduto = c.idproduto
GROUP BY c.nomeproduto
ORDER BY quantia desc