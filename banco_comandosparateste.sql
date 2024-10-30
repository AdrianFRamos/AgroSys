describe estoqueinsumo;

select * from estoqueinsumo;

update estoqueinsumo set qtd_insumo = 30 where id_insumo = 2;

select * from saidainsumo;

update cultivo set nome_cultivo = 'batata do igor 2' where id_cultivo = 63;

update estoqueinsumo set qtd_insumo = 10 where id_insumo = 1;

SELECT id_saidainsumo, qtd_saidainsumo, unidqtd_saidainsumo, data_saidainsumo FROM saidainsumo;

update saidainsumo set data_saidainsumo = '2024-06-07 20:49:46' where id_saidainsumo = 2;

select * from producao;

SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE ativo_insumo = true AND qtd_insumo > 0;

UPDATE producao SET finalizado_producao = true, datacolheita_producao = @data WHERE id_producao = @id;

select * from estoqueproduto;

select * from cultivo;

select * from compraitem;
select * from pedidocompra;

select * from vendaitem;
select * from pedidovenda;
update pedidovenda set data_pedidovenda = '2024-06-07 20:49:46' where id_pedidovenda = 3;

SET @nome = 'alho';
SELECT vi.id_vendaitem, vi.qtd_vendaitem, vi.unidqtd_vendaitem, vi.valor_vendaitem, vi.id_pedidovenda, vi.id_estoqueproduto, 
                                cul.variedade_cultivo, pv.data_pedidovenda, cli.nome_cliente
                                FROM vendaitem vi
                                LEFT JOIN estoqueproduto ep ON vi.id_estoqueproduto = ep.id_estoqueproduto
                                LEFT JOIN producao pr ON ep.id_producao = pr.id_producao
                                LEFT JOIN cultivo cul ON pr.id_cultivo = cul.id_cultivo
                                LEFT JOIN pedidovenda pv ON vi.id_pedidovenda = pv.id_pedidovenda
                                LEFT JOIN cliente cli ON pv.id_cliente = cli.id_cliente
                                WHERE cul.variedade_cultivo = @nome;