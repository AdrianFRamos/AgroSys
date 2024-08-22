using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class EstoqueProdutoDAO
    {
        private string connectionString;

        public EstoqueProdutoDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }


        // Método para listar estoque de produtos (ativos)
        public List<EstoqueProduto> ListarEstoqueProdutoAtivos()
        {
            List<EstoqueProduto> produtos = new List<EstoqueProduto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ep.id_estoqueproduto, ep.qtd_estoqueproduto, ep.unidqtd_estoqueproduto, 
                                ep.dataentrada_estoqueproduto, ep.ativo_estoqueproduto,
                                c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo,
                                p.id_producao,
                                p.data_producao,
                                p.datacolheita_producao
                                FROM estoqueproduto ep
                                LEFT JOIN producao p ON ep.id_producao = p.id_producao 
                                LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo 
                                WHERE ep.ativo_estoqueproduto = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstoqueProduto produto = new EstoqueProduto
                            {
                                Id = reader.GetInt32("id_estoqueproduto"),
                                Qtd = reader.GetInt32("qtd_estoqueproduto"),
                                Unidqtd = reader.GetString("unidqtd_estoqueproduto"),
                                DataEntrada = reader.GetDateTime("dataentrada_estoqueproduto"),
                                StatusAtivo = reader.GetBoolean("ativo_estoqueproduto"),

                                NomeCultivo = reader.GetString("nome_cultivo"),
                                VariedadeCultivo = reader.GetString("variedade_cultivo"),
                                CategoriaCultivo = reader.GetString("categoria_cultivo"),

                                IdProducao = reader.GetInt32("id_producao"),
                                DataProducao = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao")
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

        // Método para filtrar estoque de produtos (ativos) pelo nome
        public List<EstoqueProduto> FiltrarProdutosNome(string produtoNome)
        {
            List<EstoqueProduto> produtos = new List<EstoqueProduto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ep.id_estoqueproduto, ep.qtd_estoqueproduto, ep.unidqtd_estoqueproduto, 
                            ep.dataentrada_estoqueproduto, ep.ativo_estoqueproduto,
                            c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo,
                            p.id_producao,
                            p.data_producao,
                            p.datacolheita_producao
                            FROM estoqueproduto ep
                            LEFT JOIN producao p ON ep.id_producao = p.id_producao 
                            LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo 
                            WHERE ep.ativo_estoqueproduto = true
                            AND c.variedade_cultivo LIKE @nome";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + produtoNome + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstoqueProduto produto = new EstoqueProduto
                            {
                                Id = reader.GetInt32("id_estoqueproduto"),
                                Qtd = reader.GetInt32("qtd_estoqueproduto"),
                                Unidqtd = reader.GetString("unidqtd_estoqueproduto"),
                                DataEntrada = reader.GetDateTime("dataentrada_estoqueproduto"),
                                StatusAtivo = reader.GetBoolean("ativo_estoqueproduto"),

                                NomeCultivo = reader.GetString("nome_cultivo"),
                                VariedadeCultivo = reader.GetString("variedade_cultivo"),
                                CategoriaCultivo = reader.GetString("categoria_cultivo"),

                                IdProducao = reader.GetInt32("id_producao"),
                                DataProducao = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao")
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

        // Método para filtrar produtos pela unidade
        public List<EstoqueProduto> FiltrarProdutosPorUnidade(string unidade)
        {
            List<EstoqueProduto> produtos = new List<EstoqueProduto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ep.id_estoqueproduto, ep.qtd_estoqueproduto, ep.unidqtd_estoqueproduto, 
                            ep.dataentrada_estoqueproduto, ep.ativo_estoqueproduto,
                            c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo,
                            p.id_producao,
                            p.data_producao,
                            p.datacolheita_producao
                            FROM estoqueproduto ep
                            LEFT JOIN producao p ON ep.id_producao = p.id_producao 
                            LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo 
                            WHERE ep.ativo_estoqueproduto = true
                            AND ep.unidqtd_estoqueproduto LIKE @unidade";

                MySqlCommand command = new MySqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@unidade", "%" + unidade + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstoqueProduto produto = new EstoqueProduto
                            {
                                Id = reader.GetInt32("id_estoqueproduto"),
                                Qtd = reader.GetInt32("qtd_estoqueproduto"),
                                Unidqtd = reader.GetString("unidqtd_estoqueproduto"),
                                DataEntrada = reader.GetDateTime("dataentrada_estoqueproduto"),
                                StatusAtivo = reader.GetBoolean("ativo_estoqueproduto"),

                                NomeCultivo = reader.GetString("nome_cultivo"),
                                VariedadeCultivo = reader.GetString("variedade_cultivo"),
                                CategoriaCultivo = reader.GetString("categoria_cultivo"),

                                IdProducao = reader.GetInt32("id_producao"),
                                DataProducao = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao")
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

    }
}
