using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class InsumoDAO
    {
        private string connectionString;

        public InsumoDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // Método para cadastrar um insumo no banco de dados
        public void CadastrarInsumo(Insumo insumo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertInsumoQuery = @"INSERT INTO estoqueinsumo 
                                                    (nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo) 
                                                    VALUES 
                                                    (@nome_insumo, @categoria_insumo, @qtd_insumo, @unidqtd_insumo, @ativo_insumo)";

                        using (MySqlCommand insertInsumoCommand = new MySqlCommand(insertInsumoQuery, connection, transaction))
                        {
                            insertInsumoCommand.Parameters.AddWithValue("@nome_insumo", insumo.Nome);
                            insertInsumoCommand.Parameters.AddWithValue("@categoria_insumo", insumo.Categoria);
                            insertInsumoCommand.Parameters.AddWithValue("@qtd_insumo", insumo.Qtd);
                            insertInsumoCommand.Parameters.AddWithValue("@unidqtd_insumo", insumo.Unidqtd);
                            insertInsumoCommand.Parameters.AddWithValue("@ativo_insumo", insumo.Ativo);
                            insertInsumoCommand.ExecuteNonQuery();
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

        // Método para alterar um insumo no banco de dados
        public void AlterarInsumo(Insumo insumo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateInsumoQuery = @"UPDATE estoqueinsumo SET 
                                                    nome_insumo = @Nome,
                                                    categoria_insumo = @Categoria,
                                                    unidqtd_insumo = @Unidqtd
                                                    WHERE id_insumo = @InsumoId";

                        using (MySqlCommand updateInsumoCommand = new MySqlCommand(updateInsumoQuery, connection, transaction))
                        {
                            updateInsumoCommand.Parameters.AddWithValue("@InsumoId", insumo.Id);
                            updateInsumoCommand.Parameters.AddWithValue("@Nome", insumo.Nome);
                            updateInsumoCommand.Parameters.AddWithValue("@Categoria", insumo.Categoria);
                            updateInsumoCommand.Parameters.AddWithValue("@Unidqtd", insumo.Unidqtd);
                            updateInsumoCommand.ExecuteNonQuery();
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

        // Método para desativar um insumo no banco de dados
        public void DesativarInsumo(int idInsumo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateInsumoQuery = @"UPDATE estoqueinsumo SET 
                                                    ativo_insumo = @ativo_insumo 
                                                    WHERE id_insumo = @id_insumo";

                        using (MySqlCommand updateInsumoCommand = new MySqlCommand(updateInsumoQuery, connection, transaction))
                        {
                            updateInsumoCommand.Parameters.AddWithValue("@ativo_insumo", false);
                            updateInsumoCommand.Parameters.AddWithValue("@id_insumo", idInsumo);
                            updateInsumoCommand.ExecuteNonQuery();
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

        // Método para listar todos os insumos ativos
        public List<Insumo> ListarInsumosAtivos()
        {
            List<Insumo> insumos = new List<Insumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE ativo_insumo = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Insumo insumo = new Insumo
                            {
                                Id = reader.GetInt32("id_insumo"),
                                Nome = reader.GetString("nome_insumo"),
                                Categoria = reader.GetString("categoria_insumo"),
                                Qtd = reader.GetInt32("qtd_insumo"),
                                Unidqtd = reader.GetString("unidqtd_insumo"),
                                Ativo = reader.GetBoolean("ativo_insumo")
                            };
                            insumos.Add(insumo);
                        }
                    }
                }
            }
            return insumos;
        }

        // Método para listar todos os insumos ativos com quantidade maior que zero
        public List<Insumo> ListarInsumosEmEstoque()
        {
            List<Insumo> insumos = new List<Insumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE ativo_insumo = true AND qtd_insumo > 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Insumo insumo = new Insumo
                            {
                                Id = reader.GetInt32("id_insumo"),
                                Nome = reader.GetString("nome_insumo"),
                                Categoria = reader.GetString("categoria_insumo"),
                                Qtd = reader.GetInt32("qtd_insumo"),
                                Unidqtd = reader.GetString("unidqtd_insumo"),
                                Ativo = reader.GetBoolean("ativo_insumo")
                            };
                            insumos.Add(insumo);
                        }
                    }
                }
            }
            return insumos;
        }

        // Método para listar todas as saídas de insumos
        public List<SaidaInsumo> ListarSaidaInsumos()
        {
            List<SaidaInsumo> saidainsumos = new List<SaidaInsumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT si.id_saidainsumo, si.qtd_saidainsumo, si.unidqtd_saidainsumo, si.data_saidainsumo, si.id_insumo,
                        i.nome_insumo, i.categoria_insumo
                        FROM saidainsumo si
                        LEFT JOIN estoqueinsumo i ON si.id_insumo = i.id_insumo";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SaidaInsumo saidainsumo = new SaidaInsumo
                            {
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.IsDBNull(reader.GetOrdinal("nome_insumo")) ? null : reader.GetString("nome_insumo"),
                                CategoriaInsumo = reader.IsDBNull(reader.GetOrdinal("categoria_insumo")) ? null : reader.GetString("categoria_insumo"),
                                Id = reader.GetInt32("id_saidainsumo"),
                                Qtd = reader.GetInt32("qtd_saidainsumo"),
                                Unidqtd = reader.GetString("unidqtd_saidainsumo"),
                                Data = reader.GetDateTime("data_saidainsumo")
                            };
                            saidainsumos.Add(saidainsumo);
                        }
                    }
                }
            }
            return saidainsumos;
        }

        // Método para filtrar saídas de insumos pelo nome do insumo
        public List<SaidaInsumo> FiltrarSaidaInsumosNome(string insumoNome)
        {
            List<SaidaInsumo> saidainsumos = new List<SaidaInsumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT si.id_saidainsumo, si.qtd_saidainsumo, si.unidqtd_saidainsumo, si.data_saidainsumo, si.id_insumo,
                        i.nome_insumo, i.categoria_insumo
                        FROM saidainsumo si
                        LEFT JOIN estoqueinsumo i ON si.id_insumo = i.id_insumo
                        WHERE i.nome_insumo LIKE @nome";    

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + insumoNome + "%");
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SaidaInsumo saidainsumo = new SaidaInsumo
                            {
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.IsDBNull(reader.GetOrdinal("nome_insumo")) ? null : reader.GetString("nome_insumo"),
                                CategoriaInsumo = reader.IsDBNull(reader.GetOrdinal("categoria_insumo")) ? null : reader.GetString("categoria_insumo"),
                                Id = reader.GetInt32("id_saidainsumo"),
                                Qtd = reader.GetInt32("qtd_saidainsumo"),
                                Unidqtd = reader.GetString("unidqtd_saidainsumo"),
                                Data = reader.GetDateTime("data_saidainsumo")
                            };
                            saidainsumos.Add(saidainsumo);
                        }
                    }
                }
            }
            return saidainsumos;
        }

        // Método para listar todos os insumos inativos
        public List<Insumo> ListarInsumosInativos()
        {
            List<Insumo> insumos = new List<Insumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE ativo_insumo = false";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Insumo insumo = new Insumo
                            {
                                Id = reader.GetInt32("id_insumo"),
                                Nome = reader.GetString("nome_insumo"),
                                Categoria = reader.GetString("categoria_insumo"),
                                Qtd = reader.GetInt32("qtd_insumo"),
                                Unidqtd = reader.GetString("unidqtd_insumo"),
                                Ativo = reader.GetBoolean("ativo_insumo")
                            };
                            insumos.Add(insumo);
                        }
                    }
                }
            }
            return insumos;
        }

        // Método para consultar insumo por ID
        public Insumo ConsultarInsumoPorID(int idInsumo)
        {
            Insumo insumo = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE id_insumo = @id_insumo";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_insumo", idInsumo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            insumo = new Insumo
                            {
                                Id = idInsumo,
                                Nome = reader.GetString("nome_insumo"),
                                Categoria = reader.GetString("categoria_insumo"),
                                Qtd = reader.GetInt32("qtd_insumo"),
                                Unidqtd = reader.GetString("unidqtd_insumo"),
                                Ativo = reader.GetBoolean("ativo_insumo")
                            };
                        }
                    }
                }
            }
            return insumo;
        }

        public List<Insumo> FiltrarInsumosNome(string insumoNome)
        {
            List<Insumo> insumos = new List<Insumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE nome_insumo LIKE @nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", "%" + insumoNome + "%");

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Insumo insumo = new Insumo
                        {
                            Id = reader.GetInt32("id_insumo"),
                            Nome = reader.GetString("nome_insumo"),
                            Categoria = reader.GetString("categoria_insumo"),
                            Qtd = reader.GetInt32("qtd_insumo"),
                            Unidqtd = reader.GetString("unidqtd_insumo"),
                            Ativo = reader.GetBoolean("ativo_insumo")
                        };
                        insumos.Add(insumo);
                    }
                }
            }
            return insumos;
        }

        // Método para filtrar insumos pela unidade
        public List<Insumo> FiltrarInsumosPorUnidade(string unidade)
        {
            List<Insumo> insumos = new List<Insumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT id_insumo, nome_insumo, categoria_insumo, qtd_insumo, unidqtd_insumo, ativo_insumo 
                                FROM estoqueinsumo 
                                WHERE unidqtd_insumo LIKE @unidade";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@unidade", "%" + unidade + "%");

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Insumo insumo = new Insumo
                        {
                            Id = reader.GetInt32("id_insumo"),
                            Nome = reader.GetString("nome_insumo"),
                            Categoria = reader.GetString("categoria_insumo"),
                            Qtd = reader.GetInt32("qtd_insumo"),
                            Unidqtd = reader.GetString("unidqtd_insumo"),
                            Ativo = reader.GetBoolean("ativo_insumo")
                        };
                        insumos.Add(insumo);
                    }
                }
            }
            return insumos;
        }

        // Método para obter a categoria do insumo pelo nome
        public string ObterCategoriaPorNomeInsumo(string nomeInsumo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT categoria_insumo 
                                FROM estoqueinsumo 
                                WHERE nome_insumo = @nomeInsumo LIMIT 1";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeInsumo", nomeInsumo);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString("categoria_insumo");
                    }
                }
            }
            return null;
        }

        public void CadastrarSaidaInsumo(SaidaInsumo saidainsumo, Insumo insumo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertSaidaInsumoQuery = @"INSERT INTO saidainsumo 
                                                    (qtd_saidainsumo, unidqtd_saidainsumo, id_insumo) 
                                                    VALUES 
                                                    (@quantidade, @unidade, @idinsumo)";

                        using (MySqlCommand insertSaidaInsumoCommand = new MySqlCommand(insertSaidaInsumoQuery, connection, transaction))
                        {
                            insertSaidaInsumoCommand.Parameters.AddWithValue("@quantidade", saidainsumo.Qtd);
                            insertSaidaInsumoCommand.Parameters.AddWithValue("@unidade", saidainsumo.Unidqtd);
                            insertSaidaInsumoCommand.Parameters.AddWithValue("@idinsumo", saidainsumo.IdInsumo);
                            insertSaidaInsumoCommand.ExecuteNonQuery();
                        }

                        string updateInsumoQuery = @"UPDATE estoqueinsumo SET 
                                                    qtd_insumo = @Qtd
                                                    WHERE id_insumo = @InsumoId";

                        using (MySqlCommand updateInsumoCommand = new MySqlCommand(updateInsumoQuery, connection, transaction))
                        {
                            updateInsumoCommand.Parameters.AddWithValue("@InsumoId", insumo.Id);
                            updateInsumoCommand.Parameters.AddWithValue("@Qtd", insumo.Qtd - saidainsumo.Qtd);
                            updateInsumoCommand.ExecuteNonQuery();
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

        public void AumentarQtdInsumo(Insumo insumo, int qtd)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateInsumoQuery = @"UPDATE estoqueinsumo SET 
                                                    qtd_insumo = @Qtd,
                                                    WHERE id_insumo = @InsumoId";

                        using (MySqlCommand updateInsumoCommand = new MySqlCommand(updateInsumoQuery, connection, transaction))
                        {
                            updateInsumoCommand.Parameters.AddWithValue("@InsumoId", insumo.Id);
                            updateInsumoCommand.Parameters.AddWithValue("@Qtd", insumo.Qtd + qtd);
                            updateInsumoCommand.ExecuteNonQuery();
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

        public List<SaidaInsumo> FiltrarSaidaInsumosPorNomeEPeriodo(string insumoNome, DateTime dataInicio, DateTime dataFim)
        {
            List<SaidaInsumo> saidainsumos = new List<SaidaInsumo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT si.id_saidainsumo, si.qtd_saidainsumo, si.unidqtd_saidainsumo, si.data_saidainsumo, si.id_insumo,
                        i.nome_insumo, i.categoria_insumo
                        FROM saidainsumo si
                        LEFT JOIN estoqueinsumo i ON si.id_insumo = i.id_insumo
                        WHERE i.nome_insumo LIKE @nome AND si.data_saidainsumo BETWEEN @dataInicio AND @dataFim";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + insumoNome + "%");
                    command.Parameters.AddWithValue("@dataInicio", dataInicio.ToString("yyyy-MM-dd 00:00:00"));
                    command.Parameters.AddWithValue("@dataFim", dataFim.ToString("yyyy-MM-dd 23:59:59"));
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SaidaInsumo saidainsumo = new SaidaInsumo
                            {
                                IdInsumo = reader.GetInt32("id_insumo"),
                                NomeInsumo = reader.IsDBNull(reader.GetOrdinal("nome_insumo")) ? null : reader.GetString("nome_insumo"),
                                CategoriaInsumo = reader.IsDBNull(reader.GetOrdinal("categoria_insumo")) ? null : reader.GetString("categoria_insumo"),
                                Id = reader.GetInt32("id_saidainsumo"),
                                Qtd = reader.GetInt32("qtd_saidainsumo"),
                                Unidqtd = reader.GetString("unidqtd_saidainsumo"),
                                Data = reader.GetDateTime("data_saidainsumo")
                            };
                            saidainsumos.Add(saidainsumo);
                        }
                    }
                }
            }
            return saidainsumos;
        }




    }
}
