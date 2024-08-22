using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class CultivoDAO // Classe DAO (Data Access Object) para manipulação de dados de cultivos no banco de dados
    {
        private string connectionString;
        public CultivoDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // 1 - MÉTODO CADASTRAR CULTIVO NO BANCO
        public void CadastrarCultivo(Cultivo cultivo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertCultivoQuery = @"INSERT INTO cultivo (nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo) 
                                                      VALUES (@nome, @variedade, @tempoProdTradicional, @tempoProdControlado, @categoria, @status)";

                        using (MySqlCommand insertCultivoCommand = new MySqlCommand(insertCultivoQuery, connection, transaction))
                        {
                            insertCultivoCommand.Parameters.AddWithValue("@nome", cultivo.Nome);
                            insertCultivoCommand.Parameters.AddWithValue("@variedade", cultivo.Variedade);
                            insertCultivoCommand.Parameters.AddWithValue("@tempoProdTradicional", cultivo.TempoProdTradicional);
                            insertCultivoCommand.Parameters.AddWithValue("@tempoProdControlado", cultivo.TempoProdControlado);
                            insertCultivoCommand.Parameters.AddWithValue("@categoria", cultivo.Categoria);
                            insertCultivoCommand.Parameters.AddWithValue("@status", cultivo.StatusAtivo);
                            insertCultivoCommand.ExecuteNonQuery();
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

        // 2 - MÉTODO ALTERAR CULTIVO NO BANCO
        public void AlterarCultivo(Cultivo cultivo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateCultivoQuery = @"UPDATE cultivo SET 
                                                      nome_cultivo = @Nome,
                                                      variedade_cultivo = @Variedade,
                                                      tempoprodtrad_cultivo = @TempoProdTradicional,
                                                      tempoprodctrl_cultivo = @TempoProdControlado,
                                                      categoria_cultivo = @Categoria,
                                                      ativo_cultivo = @Status
                                                      WHERE id_cultivo = @CultivoId";

                        using (MySqlCommand updateCultivoCommand = new MySqlCommand(updateCultivoQuery, connection, transaction))
                        {
                            updateCultivoCommand.Parameters.AddWithValue("@CultivoId", cultivo.ID);
                            updateCultivoCommand.Parameters.AddWithValue("@Nome", cultivo.Nome);
                            updateCultivoCommand.Parameters.AddWithValue("@Variedade", cultivo.Variedade);
                            updateCultivoCommand.Parameters.AddWithValue("@TempoProdTradicional", cultivo.TempoProdTradicional);
                            updateCultivoCommand.Parameters.AddWithValue("@TempoProdControlado", cultivo.TempoProdControlado);
                            updateCultivoCommand.Parameters.AddWithValue("@Categoria", cultivo.Categoria);
                            updateCultivoCommand.Parameters.AddWithValue("@Status", cultivo.StatusAtivo);
                            updateCultivoCommand.ExecuteNonQuery();
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

        // 3 - MÉTODO EXCLUIR (DESATIVAR) CULTIVO DO BANCO
        public void ExcluirCultivo(int cultivoId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateCultivoQuery = "UPDATE cultivo SET ativo_cultivo = @status WHERE id_cultivo = @id";
                        using (MySqlCommand updateCultivoCommand = new MySqlCommand(updateCultivoQuery, connection, transaction))
                        {
                            updateCultivoCommand.Parameters.AddWithValue("@status", false);
                            updateCultivoCommand.Parameters.AddWithValue("@id", cultivoId);
                            updateCultivoCommand.ExecuteNonQuery();
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

        // 4 - MÉTODO LISTAR APENAS CULTIVOS ATIVOS DO BANCO
        public List<Cultivo> ListarCultivosAtivos()
        {
            List<Cultivo> cultivos = new List<Cultivo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT id_cultivo, nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo
                                 FROM cultivo
                                 WHERE ativo_cultivo = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cultivo cultivo = new Cultivo
                            {
                                ID = reader.GetInt32("id_cultivo"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                StatusAtivo = reader.GetBoolean("ativo_cultivo")
                            };
                            cultivos.Add(cultivo);
                        }
                    }
                }
            }
            return cultivos;
        }

        // 4.2 - MÉTODO LISTAR APENAS CULTIVOS INATIVOS DO BANCO
        public List<Cultivo> ListarCultivosInativos()
        {
            List<Cultivo> cultivosInativos = new List<Cultivo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT id_cultivo, nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo
                                 FROM cultivo
                                 WHERE ativo_cultivo = false";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cultivo cultivo = new Cultivo
                            {
                                ID = reader.GetInt32("id_cultivo"),
                                Nome = reader.GetString("nome_cultivo"),
                                Variedade = reader.GetString("variedade_cultivo"),
                                TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                                TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                                Categoria = reader.GetString("categoria_cultivo"),
                                StatusAtivo = reader.GetBoolean("ativo_cultivo")
                            };
                            cultivosInativos.Add(cultivo);
                        }
                    }
                }
            }
            return cultivosInativos;
        }

        // 5.1 - MÉTODO CONSULTAR CULTIVO NO BANCO POR ID (somente cultivos ativos)
        public Cultivo ConsultarCultivoID(int cultivoId)
        {
            Cultivo cultivo = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT id_cultivo, nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo
                                 FROM cultivo
                                 WHERE id_cultivo = @Id AND ativo_cultivo = true";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", cultivoId);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        cultivo = new Cultivo
                        {
                            ID = cultivoId,
                            Nome = reader.GetString("nome_cultivo"),
                            Variedade = reader.GetString("variedade_cultivo"),
                            TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                            TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                            Categoria = reader.GetString("categoria_cultivo"),
                            StatusAtivo = reader.GetBoolean("ativo_cultivo")
                        };
                    }
                    return cultivo;
                }
            }
        }

        // 5.2 - MÉTODO CONSULTAR CULTIVO NO BANCO POR NOME (somente cultivos ativos)
        public Cultivo ConsultarCultivoNome(string cultivoNome)
        {
            Cultivo cultivo = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT id_cultivo, nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo
                                 FROM cultivo
                                 WHERE nome_cultivo = @Nome AND ativo_cultivo = true";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", cultivoNome);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        cultivo = new Cultivo
                        {
                            ID = reader.GetInt32("id_cultivo"),
                            Nome = reader.GetString("nome_cultivo"),
                            Variedade = reader.GetString("variedade_cultivo"),
                            TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                            TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                            Categoria = reader.GetString("categoria_cultivo"),
                            StatusAtivo = reader.GetBoolean("ativo_cultivo")
                        };
                    }
                }
            }
            return cultivo;
        }

        // 6- MÉTODO FILTRAR LISTA DE CULTIVOS POR NOME
        public List<Cultivo> FiltrarCultivosNome(string cultivoNome)
        {
            List<Cultivo> cultivos = new List<Cultivo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT id_cultivo, nome_cultivo, variedade_cultivo, tempoprodtrad_cultivo, tempoprodctrl_cultivo, categoria_cultivo, ativo_cultivo
                                 FROM cultivo
                                 WHERE nome_cultivo LIKE @nome AND ativo_cultivo = true";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", "%" + cultivoNome + "%");

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cultivo cultivo = new Cultivo
                        {
                            ID = reader.GetInt32("id_cultivo"),
                            Nome = reader.GetString("nome_cultivo"),
                            Variedade = reader.GetString("variedade_cultivo"),
                            TempoProdTradicional = reader.GetInt32("tempoprodtrad_cultivo"),
                            TempoProdControlado = reader.GetInt32("tempoprodctrl_cultivo"),
                            Categoria = reader.GetString("categoria_cultivo"),
                            StatusAtivo = reader.GetBoolean("ativo_cultivo")
                        };
                        cultivos.Add(cultivo);
                    }
                }
            }
            return cultivos;
        }

        public List<string> ListarCategorias()
        {
            List<string> categorias = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT categoria_cultivo FROM cultivo WHERE ativo_cultivo = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader.GetString("categoria_cultivo"));
                        }
                    }
                }
            }
            return categorias;
        }

    }
}
