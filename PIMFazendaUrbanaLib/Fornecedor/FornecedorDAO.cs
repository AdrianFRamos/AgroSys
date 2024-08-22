using MySql.Data.MySqlClient;
using System.Data;

namespace PIMFazendaUrbanaLib
{
    public class FornecedorDAO // Classe DAO (Data Access Object) para manipulação de dados de fornecedores no banco de dados
    {
        private string connectionString;
        public FornecedorDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // 1 - MÉTODO CADASTRAR FORNECEDOR NO BANCO
        // ********** FUNCIONAL **********
        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Cria uma nova conexão com o banco de dados usando a classe MySqlConnection
            {
                connection.Open(); // Abre a conexão com o banco de dados
                using (MySqlTransaction transaction = connection.BeginTransaction()) // Inicia uma transação para garantir a consistência dos dados
                {
                    try // Tenta executar as operações dentro da transação
                    {
                        string insertFornecedorQuery = @"INSERT INTO fornecedor (nome_fornecedor, email_fornecedor, cnpj_fornecedor, ativo_fornecedor) 
                                                    VALUES (@nome, @email, @cnpj, @status)"; // Define a consulta SQL para inserir os dados do fornecedor

                        using (MySqlCommand insertFornecedorCommand = new MySqlCommand(insertFornecedorQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                        {
                            // Adiciona os parâmetros ao comando com os valores do fornecedor, puxando da instância da classe Fornecedor
                            insertFornecedorCommand.Parameters.AddWithValue("@nome", fornecedor.Nome);
                            insertFornecedorCommand.Parameters.AddWithValue("@email", fornecedor.Email);
                            insertFornecedorCommand.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
                            insertFornecedorCommand.Parameters.AddWithValue("@status", fornecedor.StatusAtivo);
                            insertFornecedorCommand.ExecuteNonQuery(); // Executa a consulta SQL para inserir os dados do fornecedor

                            int fornecedorId = (int)insertFornecedorCommand.LastInsertedId; // Recupera o ID do fornecedor recém-cadastrado

                            EnderecoFornecedor endereco = fornecedor.Endereco; // Instancia um objeto EnderecoFornecedor com os dados do endereço do fornecedor

                            string insertEnderecoQuery = @"INSERT INTO enderecofornecedor (id_fornecedor, logradouro_endfornecedor, numero_endfornecedor, complemento_endfornecedor, 
                                                        bairro_endfornecedor, cidade_endfornecedor, uf_endfornecedor, cep_endfornecedor, ativo_endfornecedor) 
                                                        VALUES (@fornecedorId, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @cep, @status)"; // Define a consulta SQL para cadastrar o endereço do fornecedor

                            using (MySqlCommand insertEnderecoCommand = new MySqlCommand(insertEnderecoQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                            {
                                // Adiciona os parâmetros ao comando com os valores do endereço do fornecedor, puxando da instância da classe EnderecoFornecedor
                                insertEnderecoCommand.Parameters.AddWithValue("@fornecedorId", fornecedorId);
                                insertEnderecoCommand.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                                insertEnderecoCommand.Parameters.AddWithValue("@numero", endereco.Numero);
                                insertEnderecoCommand.Parameters.AddWithValue("@complemento", endereco.Complemento);
                                insertEnderecoCommand.Parameters.AddWithValue("@bairro", endereco.Bairro);
                                insertEnderecoCommand.Parameters.AddWithValue("@cidade", endereco.Cidade);
                                insertEnderecoCommand.Parameters.AddWithValue("@uf", endereco.UF);
                                insertEnderecoCommand.Parameters.AddWithValue("@cep", endereco.CEP);
                                insertEnderecoCommand.Parameters.AddWithValue("@status", endereco.StatusAtivo);
                                insertEnderecoCommand.ExecuteNonQuery(); // Executa a consulta SQL para cadastrar o endereço do fornecedor
                            }

                            TelefoneFornecedor telefone = fornecedor.Telefone; // Instancia um objeto TelefoneFornecedor com os dados do telefone do fornecedor

                            string insertTelefoneQuery = @"INSERT INTO telefonefornecedor (id_fornecedor, ddd_telfornecedor, numero_telfornecedor, ativo_telfornecedor) 
                                                        VALUES (@fornecedorId, @ddd, @numero, @status)"; // Define a consulta SQL para cadastrar o telefone do fornecedor

                            using (MySqlCommand insertTelefoneCommand = new MySqlCommand(insertTelefoneQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                            {
                                // Adiciona os parâmetros ao comando com os valores do telefone do fornecedor, puxando da instância da classe TelefoneFornecedor
                                insertTelefoneCommand.Parameters.AddWithValue("@fornecedorId", fornecedorId);
                                insertTelefoneCommand.Parameters.AddWithValue("@ddd", telefone.DDD);
                                insertTelefoneCommand.Parameters.AddWithValue("@numero", telefone.Numero);
                                insertTelefoneCommand.Parameters.AddWithValue("@status", telefone.StatusAtivo);
                                insertTelefoneCommand.ExecuteNonQuery(); // Executa a consulta SQL para cadastrar o telefone do fornecedor
                            }
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

        // 2- MÉTODO ALTERAR FORNECEDOR NO BANCO
        // ********** FUNCIONAL **********
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateFornecedorQuery = @"UPDATE fornecedor SET 
                                                nome_fornecedor = @Nome,
                                                cnpj_fornecedor = @Cnpj,
                                                email_fornecedor = @Email
                                                WHERE id_fornecedor = @FornecedorId";

                        using (MySqlCommand updateFornecedorCommand = new MySqlCommand(updateFornecedorQuery, connection, transaction))
                        {
                            updateFornecedorCommand.Parameters.AddWithValue("@FornecedorId", fornecedor.ID);
                            updateFornecedorCommand.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                            updateFornecedorCommand.Parameters.AddWithValue("@Email", fornecedor.Email);
                            updateFornecedorCommand.Parameters.AddWithValue("@Cnpj", fornecedor.CNPJ);
                            updateFornecedorCommand.ExecuteNonQuery();
                        }

                        EnderecoFornecedor endereco = fornecedor.Endereco;

                        string updateEnderecoQuery = @"UPDATE enderecofornecedor SET 
                                                logradouro_endfornecedor = @Logradouro,
                                                numero_endfornecedor = @Numero,
                                                complemento_endfornecedor = @Complemento,
                                                bairro_endfornecedor = @Bairro,
                                                cidade_endfornecedor = @Cidade,
                                                uf_endfornecedor = @UF,
                                                cep_endfornecedor = @CEP
                                                WHERE id_fornecedor = @FornecedorId";

                        using (MySqlCommand updateEnderecoCommand = new MySqlCommand(updateEnderecoQuery, connection, transaction))
                        {
                            updateEnderecoCommand.Parameters.AddWithValue("@FornecedorId", fornecedor.ID);
                            updateEnderecoCommand.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                            updateEnderecoCommand.Parameters.AddWithValue("@Numero", endereco.Numero);
                            updateEnderecoCommand.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                            updateEnderecoCommand.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                            updateEnderecoCommand.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                            updateEnderecoCommand.Parameters.AddWithValue("@UF", endereco.UF);
                            updateEnderecoCommand.Parameters.AddWithValue("@CEP", endereco.CEP);
                            updateEnderecoCommand.ExecuteNonQuery();
                        }

                        TelefoneFornecedor telefone = fornecedor.Telefone;

                        string updateTelefoneQuery = @"UPDATE telefonefornecedor SET 
                                                ddd_telfornecedor = @DDD,
                                                numero_telfornecedor = @Numero
                                                WHERE id_fornecedor = @FornecedorId";

                        using (MySqlCommand updateTelefoneCommand = new MySqlCommand(updateTelefoneQuery, connection, transaction))
                        {
                            updateTelefoneCommand.Parameters.AddWithValue("@FornecedorId", fornecedor.ID);
                            updateTelefoneCommand.Parameters.AddWithValue("@DDD", telefone.DDD);
                            updateTelefoneCommand.Parameters.AddWithValue("@Numero", telefone.Numero);
                            updateTelefoneCommand.ExecuteNonQuery();
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

        // 3- MÉTODO EXCLUIR (DESATIVAR) FORNECEDOR DO BANCO
        // ********** FUNCIONAL **********
        public void ExcluirFornecedor(int fornecedorId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Desativar o fornecedor
                        string updateFornecedorQuery = "UPDATE fornecedor SET ativo_fornecedor = @status WHERE id_fornecedor = @id";
                        using (MySqlCommand updateFornecedorCommand = new MySqlCommand(updateFornecedorQuery, connection, transaction))
                        {
                            updateFornecedorCommand.Parameters.AddWithValue("@status", false);
                            updateFornecedorCommand.Parameters.AddWithValue("@id", fornecedorId);
                            updateFornecedorCommand.ExecuteNonQuery();
                        }

                        // Desativar o telefone do fornecedor
                        string updateTelefoneQuery = "UPDATE telefonefornecedor SET ativo_telfornecedor = @status WHERE id_fornecedor = @id";
                        using (MySqlCommand updateTelefoneCommand = new MySqlCommand(updateTelefoneQuery, connection, transaction))
                        {
                            updateTelefoneCommand.Parameters.AddWithValue("@status", false);
                            updateTelefoneCommand.Parameters.AddWithValue("@id", fornecedorId);
                            updateTelefoneCommand.ExecuteNonQuery();
                        }

                        // Desativar o endereço do fornecedor
                        string updateEnderecoQuery = "UPDATE enderecofornecedor SET ativo_endfornecedor = @status WHERE id_fornecedor = @id";
                        using (MySqlCommand updateEnderecoCommand = new MySqlCommand(updateEnderecoQuery, connection, transaction))
                        {
                            updateEnderecoCommand.Parameters.AddWithValue("@status", false);
                            updateEnderecoCommand.Parameters.AddWithValue("@id", fornecedorId);
                            updateEnderecoCommand.ExecuteNonQuery();
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

        // 4- Listagem
        // 4.1- MÉTODO LISTAR APENAS FORNECEDORES ATIVOS DO BANCO
        // ********** FUNCIONAL **********
        public List<Fornecedor> ListarFornecedoresAtivos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.email_fornecedor, f.cnpj_fornecedor, f.ativo_fornecedor, 
                                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                                FROM fornecedor f
                                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                                WHERE f.ativo_fornecedor = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int fornecedorId = reader.GetInt32("id_fornecedor");

                            Fornecedor fornecedor = new Fornecedor
                            {
                                ID = fornecedorId,
                                Nome = reader.GetString("nome_fornecedor"),
                                Email = reader.GetString("email_fornecedor"),
                                CNPJ = reader.GetString("cnpj_fornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                                Telefone = new TelefoneFornecedor
                                {
                                    DDD = reader.GetString("ddd_telfornecedor"),
                                    Numero = reader.GetString("numero_telfornecedor"),
                                    StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                                },
                                Endereco = new EnderecoFornecedor
                                {
                                    Logradouro = reader.GetString("logradouro_endfornecedor"),
                                    Numero = reader.GetString("numero_endfornecedor"),
                                    Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                    Bairro = reader.GetString("bairro_endfornecedor"),
                                    Cidade = reader.GetString("cidade_endfornecedor"),
                                    UF = reader.GetString("uf_endfornecedor"),
                                    CEP = reader.GetString("cep_endfornecedor"),
                                    StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                                }
                            };
                            fornecedores.Add(fornecedor);
                        }
                    }
                }
            }
            return fornecedores;
        }

        // 4.2- MÉTODO LISTAR APENAS FORNECEDORES INATIVOS DO BANCO
        // ********** FUNCIONAL **********
        public List<Fornecedor> ListarFornecedoresInativos()
        {
            List<Fornecedor> fornecedoresInativos = new List<Fornecedor>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.email_fornecedor, f.cnpj_fornecedor, f.ativo_fornecedor, 
                                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                                FROM fornecedor f
                                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int fornecedorId = reader.GetInt32("id_fornecedor");

                            Fornecedor fornecedor = new Fornecedor
                            {
                                ID = fornecedorId,
                                Nome = reader.GetString("nome_fornecedor"),
                                Email = reader.GetString("email_fornecedor"),
                                CNPJ = reader.GetString("cnpj_fornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                                Telefone = new TelefoneFornecedor
                                {
                                    DDD = reader.GetString("ddd_telfornecedor"),
                                    Numero = reader.GetString("numero_telfornecedor"),
                                    StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                                },
                                Endereco = new EnderecoFornecedor
                                {
                                    Logradouro = reader.GetString("logradouro_endfornecedor"),
                                    Numero = reader.GetString("numero_endfornecedor"),
                                    Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                    Bairro = reader.GetString("bairro_endfornecedor"),
                                    Cidade = reader.GetString("cidade_endfornecedor"),
                                    UF = reader.GetString("uf_endfornecedor"),
                                    CEP = reader.GetString("cep_endfornecedor"),
                                    StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                                }
                            };
                            fornecedoresInativos.Add(fornecedor);
                        }
                    }
                }
            }
            return fornecedoresInativos;
        }

        // 5- Consulta
        // 5.1- MÉTODO CONSULTAR (PESQUISAR) FORNECEDOR NO BANCO POR ID (somente fornecedores ativos)
        // ********** FUNCIONAL **********
        public Fornecedor ConsultarFornecedorID(int fornecedorId)
        {
            Fornecedor fornecedor = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.cnpj_fornecedor, f.email_fornecedor,
                                f.ativo_fornecedor, 
                                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                                FROM fornecedor f
                                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                                WHERE f.id_fornecedor = @Id";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", fornecedorId);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        fornecedor = new Fornecedor
                        {
                            ID = fornecedorId,
                            Nome = reader.GetString("nome_fornecedor"),
                            CNPJ = reader.GetString("cnpj_fornecedor"),
                            Email = reader.GetString("email_fornecedor"),
                            StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                            Telefone = new TelefoneFornecedor
                            {
                                DDD = reader.GetString("ddd_telfornecedor"),
                                Numero = reader.GetString("numero_telfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                            },
                            Endereco = new EnderecoFornecedor
                            {
                                Logradouro = reader.GetString("logradouro_endfornecedor"),
                                Numero = reader.GetString("numero_endfornecedor"),
                                Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                Bairro = reader.GetString("bairro_endfornecedor"),
                                Cidade = reader.GetString("cidade_endfornecedor"),
                                UF = reader.GetString("uf_endfornecedor"),
                                CEP = reader.GetString("cep_endfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                            }
                        };
                    }
                    return fornecedor;
                }
            }
        }

        // 5.2- MÉTODO CONSULTAR (PESQUISAR) FORNECEDOR NO BANCO POR NOME (somente fornecedores ativos)
        public Fornecedor ConsultarFornecedorNome(string fornecedorNome)
        {
            Fornecedor fornecedor = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.cnpj_fornecedor, f.email_fornecedor, 
                                f.ativo_fornecedor, 
                                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                                FROM fornecedor f
                                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                                WHERE f.nome_fornecedor = @Nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", fornecedorNome);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        fornecedor = new Fornecedor
                        {
                            ID = reader.GetInt32("id_fornecedor"),
                            Nome = fornecedorNome,
                            CNPJ = reader.GetString("cnpj_fornecedor"),
                            Email = reader.GetString("email_fornecedor"),
                            StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                            Telefone = new TelefoneFornecedor
                            {
                                DDD = reader.GetString("ddd_telfornecedor"),
                                Numero = reader.GetString("numero_telfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                            },
                            Endereco = new EnderecoFornecedor
                            {
                                Logradouro = reader.GetString("logradouro_endfornecedor"),
                                Numero = reader.GetString("numero_endfornecedor"),
                                Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                Bairro = reader.GetString("bairro_endfornecedor"),
                                Cidade = reader.GetString("cidade_endfornecedor"),
                                UF = reader.GetString("uf_endfornecedor"),
                                CEP = reader.GetString("cep_endfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                            }
                        };
                    }
                    return fornecedor;
                }
            }
        }

        // 5.3- MÉTODO CONSULTAR (PESQUISAR) FORNECEDOR NO BANCO POR CNPJ (somente fornecedores ativos)
        public Fornecedor ConsultarFornecedorCNPJ(string fornecedorCNPJ)
        {
            Fornecedor fornecedor = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.cnpj_fornecedor, f.email_fornecedor, 
                                f.ativo_fornecedor, 
                                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                                FROM fornecedor f
                                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                                WHERE f.cnpj_fornecedor = @CNPJ";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CNPJ", fornecedorCNPJ);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        fornecedor = new Fornecedor
                        {
                            ID = reader.GetInt32("id_fornecedor"),
                            Nome = reader.GetString("nome_fornecedor"),
                            CNPJ = fornecedorCNPJ,
                            Email = reader.GetString("email_fornecedor"),
                            StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                            Telefone = new TelefoneFornecedor
                            {
                                DDD = reader.GetString("ddd_telfornecedor"),
                                Numero = reader.GetString("numero_telfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                            },
                            Endereco = new EnderecoFornecedor
                            {
                                Logradouro = reader.GetString("logradouro_endfornecedor"),
                                Numero = reader.GetString("numero_endfornecedor"),
                                Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                Bairro = reader.GetString("bairro_endfornecedor"),
                                Cidade = reader.GetString("cidade_endfornecedor"),
                                UF = reader.GetString("uf_endfornecedor"),
                                CEP = reader.GetString("cep_endfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                            }
                        };
                    }
                    return fornecedor;
                }
            }
        }

        // 6- MÉTODO FILTRAR LISTA DE FORNECEDORES POR NOME
        // ********** FUNCIONAL **********
        public List<Fornecedor> FiltrarFornecedoresNome(string fornecedorNome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT f.id_fornecedor, f.nome_fornecedor, f.email_fornecedor, f.cnpj_fornecedor, f.ativo_fornecedor, 
                t.ddd_telfornecedor, t.numero_telfornecedor, t.ativo_telfornecedor, 
                e.logradouro_endfornecedor, e.numero_endfornecedor, e.complemento_endfornecedor, e.bairro_endfornecedor, e.cidade_endfornecedor, 
                e.uf_endfornecedor, e.cep_endfornecedor, e.ativo_endfornecedor
                FROM fornecedor f
                LEFT JOIN telefonefornecedor t ON f.id_fornecedor = t.id_fornecedor
                LEFT JOIN enderecofornecedor e ON f.id_fornecedor = e.id_fornecedor
                WHERE f.nome_fornecedor LIKE @nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", "%" + fornecedorNome + "%");

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor
                        {
                            ID = reader.GetInt32("id_fornecedor"),
                            Nome = reader.GetString("nome_fornecedor"),
                            Email = reader.GetString("email_fornecedor"),
                            CNPJ = reader.GetString("cnpj_fornecedor"),
                            StatusAtivo = reader.GetBoolean("ativo_fornecedor"),
                            Telefone = new TelefoneFornecedor
                            {
                                DDD = reader.GetString("ddd_telfornecedor"),
                                Numero = reader.GetString("numero_telfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_telfornecedor")
                            },
                            Endereco = new EnderecoFornecedor
                            {
                                Logradouro = reader.GetString("logradouro_endfornecedor"),
                                Numero = reader.GetString("numero_endfornecedor"),
                                Complemento = reader.IsDBNull("complemento_endfornecedor") ? null : reader.GetString("complemento_endfornecedor"),
                                Bairro = reader.GetString("bairro_endfornecedor"),
                                Cidade = reader.GetString("cidade_endfornecedor"),
                                UF = reader.GetString("uf_endfornecedor"),
                                CEP = reader.GetString("cep_endfornecedor"),
                                StatusAtivo = reader.GetBoolean("ativo_endfornecedor")
                            }
                        };
                        fornecedores.Add(fornecedor);
                    }
                }
            }
            return fornecedores;
        }



    }
}
