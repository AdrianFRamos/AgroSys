using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class ProducaoDAO
    {
        private string connectionString;

        public ProducaoDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // 1 - MÉTODO CADASTRAR PRODUCAO NO BANCO
        public void CadastrarProducao(Producao producao)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Cria uma nova conexão com o banco de dados usando a classe MySqlConnection
            {
                connection.Open(); // Abre a conexão com o banco de dados
                using (MySqlTransaction transaction = connection.BeginTransaction()) // Inicia uma transação para garantir a consistência dos dados
                {
                    try // Tenta executar as operações dentro da transação
                    {
                        string insertProducaoQuery = @"INSERT INTO producao 
                                                    (qtd_producao, unidqtd_producao, data_producao, datacolheita_producao, 
                                                    ambientectrl_producao, finalizado_producao, id_cultivo) 
                                                    VALUES (@qtd, @unidqtd, @data, @datacolheita, @ambientectrl, @statusfinalizado, @idcultivo)";

                        using (MySqlCommand insertProducaoCommand = new MySqlCommand(insertProducaoQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                        {
                            insertProducaoCommand.Parameters.AddWithValue("@qtd", producao.Qtd);
                            insertProducaoCommand.Parameters.AddWithValue("@unidqtd", producao.Unidqtd);
                            insertProducaoCommand.Parameters.AddWithValue("@data", producao.Data);
                            insertProducaoCommand.Parameters.AddWithValue("@datacolheita", producao.DataColheita);
                            insertProducaoCommand.Parameters.AddWithValue("@ambientectrl", producao.AmbienteControlado);
                            insertProducaoCommand.Parameters.AddWithValue("@statusfinalizado", producao.StatusFinalizado);
                            insertProducaoCommand.Parameters.AddWithValue("@idcultivo", producao.IdCultivo);
                            insertProducaoCommand.ExecuteNonQuery();
                        }
                        // COMMIT de todas as inserções no banco de dados
                        transaction.Commit(); // Efetua o commit da transação se todas as operações forem bem-sucedidas
                    }
                    catch (Exception) // Captura exceções caso ocorram erros durante a execução das operações
                    {
                        transaction.Rollback(); // Em caso de erro, faz o rollback da transação
                        throw;
                    }
                }
            }
        }

        // 2 - MÉTODO ALTERAR PRODUCAO NO BANCO
        // NÃO FUNCIONAL
        public void AlterarProducao(Producao producao)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateProducaoQuery = @"UPDATE producao SET 
                                                qtd_producao = @qtd,
                                                dt_producao = @data,
                                                finalizado_producao = @statusfinalizado
                                                WHERE id_producao = @ProducaoId";

                        using (MySqlCommand updateProducaoCommand = new MySqlCommand(updateProducaoQuery, connection, transaction))
                        {
                            updateProducaoCommand.Parameters.AddWithValue("@ProducaoId", producao.Id);
                            updateProducaoCommand.Parameters.AddWithValue("@qtd", producao.Qtd);
                            updateProducaoCommand.Parameters.AddWithValue("@data", producao.Data);
                            updateProducaoCommand.Parameters.AddWithValue("@statusfinalizado", producao.StatusFinalizado);
                            updateProducaoCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // 3 - MÉTODO FINALIZAR PRODUCAO NO BANCO
        public void FinalizarProducao(int producaoId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateProducaoQuery = "UPDATE producao SET finalizado_producao = @statusfinalizado, datacolheita_producao = @datacolheita WHERE id_producao = @id";
                        using (MySqlCommand updateClienteCommand = new MySqlCommand(updateProducaoQuery, connection, transaction))
                        {
                            updateClienteCommand.Parameters.AddWithValue("@statusfinalizado", true);
                            updateClienteCommand.Parameters.AddWithValue("@datacolheita", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            updateClienteCommand.Parameters.AddWithValue("@id", producaoId);
                            updateClienteCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // 4 - Listagem
        // 4.1 - MÉTODO LISTAR PRODUCOES NO BANCO
        public List<Producao> ListarProducoes()
        {
            List<Producao> producoes = new List<Producao>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT p.id_producao, p.qtd_producao, p.unidqtd_producao, 
                                p.data_producao, p.datacolheita_producao, 
                                p.ambientectrl_producao, p.finalizado_producao, p.id_cultivo,
                                c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo, c.tempoprodtrad_cultivo, c.tempoprodctrl_cultivo
                                FROM producao p
                                LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producao producao = new Producao
                            {
                                Id = reader.GetInt32("id_producao"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Qtd = reader.GetInt32("qtd_producao"),
                                Unidqtd = reader.GetString("unidqtd_producao"),
                                Data = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao"),
                                AmbienteControlado = reader.GetBoolean("ambientectrl_producao"),
                                StatusFinalizado = reader.GetBoolean("finalizado_producao"),
                            };
                            producoes.Add(producao);
                        }
                    }
                }
            }
            return producoes;
        }

        // 4.2 - MÉTODO LISTAR PRODUCOES (NÃO FINALIZADAS) NO BANCO
        public List<Producao> ListarProducoesNaoFinalizadas()
        {
            List<Producao> producoes = new List<Producao>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT p.id_producao, p.qtd_producao, p.unidqtd_producao, 
                                DATE_FORMAT(p.data_producao, '%Y-%m-%d %H:%i:%s') AS data_producao,
                                DATE_FORMAT(p.datacolheita_producao, '%Y-%m-%d %H:%i:%s') AS datacolheita_producao,
                                p.ambientectrl_producao, p.finalizado_producao, p.id_cultivo,
                                c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo, c.tempoprodtrad_cultivo, c.tempoprodctrl_cultivo
                                FROM producao p
                                LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo
                                WHERE p.finalizado_producao = false";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producao producao = new Producao
                            {
                                Id = reader.GetInt32("id_producao"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Qtd = reader.GetInt32("qtd_producao"),
                                Unidqtd = reader.GetString("unidqtd_producao"),
                                Data = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao"),
                                AmbienteControlado = reader.GetBoolean("ambientectrl_producao"),
                                StatusFinalizado = reader.GetBoolean("finalizado_producao"),
                            };
                            producoes.Add(producao);
                        }
                    }
                }
            }
            return producoes;
        }

        // 4.3 - MÉTODO FILTRAR PRODUCOES POR NOME DE CULTIVO NO BANCO
        public List<Producao> FiltrarProducoesNome(string cultivoNome)
        {
            List<Producao> producoes = new List<Producao>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT p.id_producao, p.qtd_producao, p.unidqtd_producao, 
                                p.data_producao, p.datacolheita_producao, 
                                p.ambientectrl_producao, p.finalizado_producao, p.id_cultivo,
                                c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo, c.tempoprodtrad_cultivo, c.tempoprodctrl_cultivo
                                FROM producao p
                                LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo 
                                WHERE c.nome_cultivo LIKE @NomeCultivo";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeCultivo", "%" + cultivoNome + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producao producao = new Producao
                            {
                                Id = reader.GetInt32("id_producao"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Qtd = reader.GetInt32("qtd_producao"),
                                Unidqtd = reader.GetString("unidqtd_producao"),
                                Data = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao"),
                                AmbienteControlado = reader.GetBoolean("ambientectrl_producao"),
                                StatusFinalizado = reader.GetBoolean("finalizado_producao"),
                            };
                            producoes.Add(producao);
                        }
                    }
                }
            }
            return producoes;
        }

        public List<Producao> FiltrarProducoesPorNomeEPeriodo(string cultivoNome, DateTime dataInicio, DateTime dataFim)
        {
            List<Producao> producoes = new List<Producao>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT p.id_producao, p.qtd_producao, p.unidqtd_producao, 
                                p.data_producao, p.datacolheita_producao, 
                                p.ambientectrl_producao, p.finalizado_producao, p.id_cultivo,
                                c.nome_cultivo, c.variedade_cultivo, c.categoria_cultivo, c.tempoprodtrad_cultivo, c.tempoprodctrl_cultivo
                                FROM producao p
                                LEFT JOIN cultivo c ON p.id_cultivo = c.id_cultivo 
                                WHERE c.nome_cultivo LIKE @NomeCultivo AND p.data_producao BETWEEN @dataInicio AND @dataFim";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeCultivo", "%" + cultivoNome + "%");
                    command.Parameters.AddWithValue("@dataInicio", dataInicio.ToString("yyyy-MM-dd 00:00:00"));
                    command.Parameters.AddWithValue("@dataFim", dataFim.ToString("yyyy-MM-dd 23:59:59"));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producao producao = new Producao
                            {
                                Id = reader.GetInt32("id_producao"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Qtd = reader.GetInt32("qtd_producao"),
                                Unidqtd = reader.GetString("unidqtd_producao"),
                                Data = reader.GetDateTime("data_producao"),
                                DataColheita = reader.GetDateTime("datacolheita_producao"),
                                AmbienteControlado = reader.GetBoolean("ambientectrl_producao"),
                                StatusFinalizado = reader.GetBoolean("finalizado_producao"),
                            };
                            producoes.Add(producao);
                        }
                    }
                }
            }
            return producoes;
        }

        // 5 - MÉTODO CONSULTAR PRODUCAO POR ID NO BANCO
        // NÃO FUNCIONAL
        public Producao ConsultarProducaoID(int producaoId)
        {
            Producao producao = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT p.id_producao, p.qtd_producao, p.dt_producao, p.finalizado_producao, p.ativo_producao
                                FROM producao p
                                WHERE id_producao = @Id";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", producaoId);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        producao = new Producao
                        {
                            Id = producaoId,
                            Qtd = reader.GetInt32(reader.GetString("qtd_producao")),
                            Data = reader.GetDateTime("data_producao"),
                            StatusFinalizado = reader.GetBoolean("finalizado_producao"),
                        };
                    }
                    return producao;
                }
            }
        }


    }
}
