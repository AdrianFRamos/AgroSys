using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class CompraDAO
    {
        private string connectionString;

        public CompraDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // Método para cadastrar um novo pedido de compra
        public void CadastrarPedidoCompra(PedidoCompra pedidoCompra, MySqlTransaction transaction)
        {
            string insertPedidoQuery = @"INSERT INTO pedidocompra (data_pedidocompra, id_fornecedor) 
                                 VALUES (@dataPedidoCompra, @idFornecedor);
                                 SELECT LAST_INSERT_ID();";

            using (MySqlCommand insertPedidoCommand = new MySqlCommand(insertPedidoQuery, transaction.Connection, transaction))
            {
                insertPedidoCommand.Parameters.AddWithValue("@dataPedidoCompra", pedidoCompra.Data);
                insertPedidoCommand.Parameters.AddWithValue("@idFornecedor", pedidoCompra.IdFornecedor);
                pedidoCompra.Id = Convert.ToInt32(insertPedidoCommand.ExecuteScalar());
            }
        }

        // Método para cadastrar um novo item de compra
        public void CadastrarCompraItem(PedidoCompraItem compraItem, MySqlTransaction transaction)
        {
            string insertItemQuery = @"INSERT INTO compraitem (qtd_compraitem, unidqtd_compraitem, valor_compraitem, id_pedidocompra, id_insumo) 
                               VALUES (@qtdCompraItem, @unidQtdCompraItem, @valorCompraItem, @idPedidoCompra, @idInsumo)";
            using (MySqlCommand insertItemCommand = new MySqlCommand(insertItemQuery, transaction.Connection, transaction))
            {
                insertItemCommand.Parameters.AddWithValue("@qtdCompraItem", compraItem.Qtd);
                insertItemCommand.Parameters.AddWithValue("@unidQtdCompraItem", compraItem.UnidQtd);
                insertItemCommand.Parameters.AddWithValue("@valorCompraItem", compraItem.Valor);
                insertItemCommand.Parameters.AddWithValue("@idPedidoCompra", compraItem.IdPedidoCompra);
                insertItemCommand.Parameters.AddWithValue("@idInsumo", compraItem.IdInsumo);
                insertItemCommand.ExecuteNonQuery();
            }
        }

        // Método para listar todos os pedidos de compra
        public List<PedidoCompra> ListarPedidosCompra()
        {
            List<PedidoCompra> pedidosCompra = new List<PedidoCompra>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_pedidocompra, data_pedidocompra, id_fornecedor FROM pedidocompra";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoCompra pedidoCompra = new PedidoCompra
                            {
                                Id = reader.GetInt32("id_pedidocompra"),
                                Data = reader.GetDateTime("data_pedidocompra"),
                                IdFornecedor = reader.GetInt32("id_fornecedor")
                            };
                            pedidosCompra.Add(pedidoCompra);
                        }
                    }
                }
            }
            return pedidosCompra;
        }

        // Método para consultar um pedido de compra pelo ID
        public PedidoCompra ConsultarPedidoCompra(int idPedidoCompra)
        {
            PedidoCompra pedidoCompra = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_pedidocompra, data_pedidocompra, id_fornecedor FROM pedidocompra WHERE id_pedidocompra = @idPedidoCompra";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPedidoCompra", idPedidoCompra);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pedidoCompra = new PedidoCompra
                        {
                            Id = reader.GetInt32("id_pedidocompra"),
                            Data = reader.GetDateTime("data_pedidocompra"),
                            IdFornecedor = reader.GetInt32("id_fornecedor")
                        };
                    }
                }
            }
            return pedidoCompra;
        }

        // Método para obter o ID do último pedido de compra cadastrado
        public int? ObterUltimoIdPedidoCompra()
        {
            int? idPedidoCompra = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(id_pedidocompra) FROM pedidocompra";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            idPedidoCompra = reader.GetInt32(0);
                        }
                    }
                }
            }
            return idPedidoCompra;
        }

        // Método para listar todos os itens de compra
        public List<PedidoCompraItem> ListarRegistrosDeCompra()
        {
            List<PedidoCompraItem> compraItens = new List<PedidoCompraItem>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ci.id_compraitem, ci.qtd_compraitem, ci.unidqtd_compraitem, ci.valor_compraitem, ci.id_pedidocompra, ci.id_insumo, 
                                i.nome_insumo, pc.data_pedidocompra, f.nome_fornecedor
                                FROM compraitem ci
                                LEFT JOIN estoqueinsumo i ON ci.id_insumo = i.id_insumo
                                LEFT JOIN pedidocompra pc ON ci.id_pedidocompra = pc.id_pedidocompra
                                LEFT JOIN fornecedor f ON pc.id_fornecedor = f.id_fornecedor";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoCompraItem compraItem = new PedidoCompraItem
                            {
                                Id = reader.GetInt32("id_compraitem"),
                                Qtd = reader.GetInt32("qtd_compraitem"),
                                UnidQtd = reader.GetString("unidqtd_compraitem"),
                                Valor = reader.GetDecimal("valor_compraitem"),
                                IdPedidoCompra = reader.GetInt32("id_pedidocompra"),
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.GetString("nome_insumo"),
                                Data = reader.GetDateTime("data_pedidocompra"),
                                NomeFornecedor = reader.GetString("nome_fornecedor")
                            };
                            compraItens.Add(compraItem);
                        }
                    }
                }
            }
            return compraItens;
        }

        // Método para filtrar os itens de compra por nome de insumo
        public List<PedidoCompraItem> FiltrarRegistrosDeCompraNome(string insumoNome)
        {
            List<PedidoCompraItem> compraItens = new List<PedidoCompraItem>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ci.id_compraitem, ci.qtd_compraitem, ci.unidqtd_compraitem, ci.valor_compraitem, ci.id_pedidocompra, ci.id_insumo, 
                                i.nome_insumo, pc.data_pedidocompra, f.nome_fornecedor
                                FROM compraitem ci
                                LEFT JOIN estoqueinsumo i ON ci.id_insumo = i.id_insumo
                                LEFT JOIN pedidocompra pc ON ci.id_pedidocompra = pc.id_pedidocompra
                                LEFT JOIN fornecedor f ON pc.id_fornecedor = f.id_fornecedor
                                WHERE i.nome_insumo LIKE @nome";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + insumoNome + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoCompraItem compraItem = new PedidoCompraItem
                            {
                                Id = reader.GetInt32("id_compraitem"),
                                Qtd = reader.GetInt32("qtd_compraitem"),
                                UnidQtd = reader.GetString("unidqtd_compraitem"),
                                Valor = reader.GetDecimal("valor_compraitem"),
                                IdPedidoCompra = reader.GetInt32("id_pedidocompra"),
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.GetString("nome_insumo"),
                                Data = reader.GetDateTime("data_pedidocompra"),
                                NomeFornecedor = reader.GetString("nome_fornecedor")
                            };
                            compraItens.Add(compraItem);
                        }
                    }
                }
            }
            return compraItens;
        }

        // Método para consultar um item de compra pelo ID
        public PedidoCompraItem ConsultarCompraItem(int idCompraItem)
        {
            PedidoCompraItem compraItem = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_compraitem, qtd_compraitem, unidqtd_compraitem, valor_compraitem, id_pedidocompra, id_insumo FROM compraitem WHERE id_compraitem = @idCompraItem";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCompraItem", idCompraItem);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        compraItem = new PedidoCompraItem
                        {
                            Id = reader.GetInt32("id_compraitem"),
                            Qtd = reader.GetInt32("qtd_compraitem"),
                            UnidQtd = reader.GetString("unidqtd_compraitem"),
                            Valor = reader.GetDecimal("valor_compraitem"),
                            IdPedidoCompra = reader.GetInt32("id_pedidocompra"),
                            IdInsumo = reader.GetInt32("id_insumo")
                        };
                    }
                }
            }
            return compraItem;
        }

        public List<PedidoCompraItem> FiltrarRegistrosDeCompraPorNomeEPeriodo(string insumoNome, DateTime dataInicio, DateTime dataFim)
        {
            List<PedidoCompraItem> compraItens = new List<PedidoCompraItem>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ci.id_compraitem, ci.qtd_compraitem, ci.unidqtd_compraitem, ci.valor_compraitem, ci.id_pedidocompra, ci.id_insumo, 
                        i.nome_insumo, pc.data_pedidocompra, f.nome_fornecedor
                        FROM compraitem ci
                        LEFT JOIN estoqueinsumo i ON ci.id_insumo = i.id_insumo
                        LEFT JOIN pedidocompra pc ON ci.id_pedidocompra = pc.id_pedidocompra
                        LEFT JOIN fornecedor f ON pc.id_fornecedor = f.id_fornecedor
                        WHERE i.nome_insumo LIKE @nome AND pc.data_pedidocompra BETWEEN @dataInicio AND @dataFim";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + insumoNome + "%");
                    command.Parameters.AddWithValue("@dataInicio", dataInicio.ToString("yyyy-MM-dd 00:00:00"));
                    command.Parameters.AddWithValue("@dataFim", dataFim.ToString("yyyy-MM-dd 23:59:59"));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoCompraItem compraItem = new PedidoCompraItem
                            {
                                Id = reader.GetInt32("id_compraitem"),
                                Qtd = reader.GetInt32("qtd_compraitem"),
                                UnidQtd = reader.GetString("unidqtd_compraitem"),
                                Valor = reader.GetDecimal("valor_compraitem"),
                                IdPedidoCompra = reader.GetInt32("id_pedidocompra"),
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.GetString("nome_insumo"),
                                Data = reader.GetDateTime("data_pedidocompra"),
                                NomeFornecedor = reader.GetString("nome_fornecedor")
                            };
                            compraItens.Add(compraItem);
                        }
                    }
                }
            }
            return compraItens;
        }

    }
}
