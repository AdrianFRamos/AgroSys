using MySql.Data.MySqlClient;
using System.Data;

namespace PIMFazendaUrbanaLib
{
    public class ClienteDAO // Classe DAO (Data Access Object) para manipulação de dados de clientes no banco de dados
    {
        private string connectionString;
        public ClienteDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        // 1 - MÉTODO CADASTRAR CLIENTE NO BANCO
        // ********** FUNCIONAL **********
        public void CadastrarCliente(Cliente cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Cria uma nova conexão com o banco de dados usando a classe MySqlConnection
            {
                connection.Open(); // Abre a conexão com o banco de dados
                using (MySqlTransaction transaction = connection.BeginTransaction()) // Inicia uma transação para garantir a consistência dos dados
                {
                    try // Tenta executar as operações dentro da transação
                    {
                        string insertClienteQuery = @"INSERT INTO cliente (nome_cliente, email_cliente, cnpj_cliente, ativo_cliente) 
                                                    VALUES (@nome, @email, @cnpj, @status)"; // Define a consulta SQL para inserir os dados do cliente

                        using (MySqlCommand insertClienteCommand = new MySqlCommand(insertClienteQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                        {
                            // Adiciona os parâmetros ao comando com os valores do cliente, puxando da instância da classe Cliente
                            insertClienteCommand.Parameters.AddWithValue("@nome", cliente.Nome);
                            insertClienteCommand.Parameters.AddWithValue("@email", cliente.Email);
                            insertClienteCommand.Parameters.AddWithValue("@cnpj", cliente.CNPJ);
                            insertClienteCommand.Parameters.AddWithValue("@status", cliente.StatusAtivo);
                            insertClienteCommand.ExecuteNonQuery(); // Executa a consulta SQL para inserir os dados do cliente

                            int clienteId = (int)insertClienteCommand.LastInsertedId; // Recupera o ID do cliente recém-cadastrado

                            EnderecoCliente endereco = cliente.Endereco; // Instancia um objeto EnderecoCliente com os dados do endereço do cliente

                            string insertEnderecoQuery = @"INSERT INTO enderecocliente (id_cliente, logradouro_endcliente, numero_endcliente, complemento_endcliente, 
                                                        bairro_endcliente, cidade_endcliente, uf_endcliente, cep_endcliente, ativo_endcliente) 
                                                        VALUES (@clienteId, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @cep, @status)"; // Define a consulta SQL para cadastrar o endereço do cliente

                            using (MySqlCommand insertEnderecoCommand = new MySqlCommand(insertEnderecoQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                            {
                                // Adiciona os parâmetros ao comando com os valores do endereço do cliente, puxando da instância da classe EnderecoCliente
                                insertEnderecoCommand.Parameters.AddWithValue("@clienteId", clienteId);
                                insertEnderecoCommand.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                                insertEnderecoCommand.Parameters.AddWithValue("@numero", endereco.Numero);
                                insertEnderecoCommand.Parameters.AddWithValue("@complemento", endereco.Complemento);
                                insertEnderecoCommand.Parameters.AddWithValue("@bairro", endereco.Bairro);
                                insertEnderecoCommand.Parameters.AddWithValue("@cidade", endereco.Cidade);
                                insertEnderecoCommand.Parameters.AddWithValue("@uf", endereco.UF);
                                insertEnderecoCommand.Parameters.AddWithValue("@cep", endereco.CEP);
                                insertEnderecoCommand.Parameters.AddWithValue("@status", endereco.StatusAtivo);
                                insertEnderecoCommand.ExecuteNonQuery(); // Executa a consulta SQL para cadastrar o endereço do cliente
                            }

                            TelefoneCliente telefone = cliente.Telefone; // Instancia um objeto TelefoneCliente com os dados do telefone do cliente

                            string insertTelefoneQuery = @"INSERT INTO telefonecliente (id_cliente, ddd_telcliente, numero_telcliente, ativo_telcliente) 
                                                        VALUES (@clienteId, @ddd, @numero, @status)"; // Define a consulta SQL para cadastrar o telefone do cliente

                            using (MySqlCommand insertTelefoneCommand = new MySqlCommand(insertTelefoneQuery, connection, transaction)) // Cria um comando MySqlCommand com a consulta SQL, a conexão e a transação
                            {
                                // Adiciona os parâmetros ao comando com os valores do telefone do cliente, puxando da instância da classe TelefoneCliente
                                insertTelefoneCommand.Parameters.AddWithValue("@clienteId", clienteId);
                                insertTelefoneCommand.Parameters.AddWithValue("@ddd", telefone.DDD);
                                insertTelefoneCommand.Parameters.AddWithValue("@numero", telefone.Numero);
                                insertTelefoneCommand.Parameters.AddWithValue("@status", telefone.StatusAtivo);
                                insertTelefoneCommand.ExecuteNonQuery(); // Executa a consulta SQL para cadastrar o telefone do cliente
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

        // 2- MÉTODO ALTERAR CLIENTE NO BANCO
        // ********** FUNCIONAL **********
        public void AlterarCliente(Cliente cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction()) 
                {
                    try
                    {
                        string updateClienteQuery = @"UPDATE cliente SET 
                                                nome_cliente = @Nome,
                                                cnpj_cliente = @Cnpj,
                                                email_cliente = @Email
                                                WHERE id_cliente = @ClienteId";

                        using (MySqlCommand updateClienteCommand = new MySqlCommand(updateClienteQuery, connection, transaction))
                        {
                            updateClienteCommand.Parameters.AddWithValue("@ClienteId", cliente.ID);
                            updateClienteCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
                            updateClienteCommand.Parameters.AddWithValue("@Email", cliente.Email);
                            updateClienteCommand.Parameters.AddWithValue("@Cnpj", cliente.CNPJ);
                            updateClienteCommand.ExecuteNonQuery();
                        }

                        EnderecoCliente endereco = cliente.Endereco;

                        string updateEnderecoQuery = @"UPDATE enderecocliente SET 
                                                logradouro_endcliente = @Logradouro,
                                                numero_endcliente = @Numero,
                                                complemento_endcliente = @Complemento,
                                                bairro_endcliente = @Bairro,
                                                cidade_endcliente = @Cidade,
                                                uf_endcliente = @UF,
                                                cep_endcliente = @CEP
                                                WHERE id_cliente = @ClienteId";

                        using (MySqlCommand updateEnderecoCommand = new MySqlCommand(updateEnderecoQuery, connection, transaction))
                        {
                            updateEnderecoCommand.Parameters.AddWithValue("@ClienteId", cliente.ID);
                            updateEnderecoCommand.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                            updateEnderecoCommand.Parameters.AddWithValue("@Numero", endereco.Numero);
                            updateEnderecoCommand.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                            updateEnderecoCommand.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                            updateEnderecoCommand.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                            updateEnderecoCommand.Parameters.AddWithValue("@UF", endereco.UF);
                            updateEnderecoCommand.Parameters.AddWithValue("@CEP", endereco.CEP);
                            updateEnderecoCommand.ExecuteNonQuery();
                        }

                        TelefoneCliente telefone = cliente.Telefone;

                        string updateTelefoneQuery = @"UPDATE telefonecliente SET 
                                                ddd_telcliente = @DDD,
                                                numero_telcliente = @Numero
                                                WHERE id_cliente = @ClienteId";

                        using (MySqlCommand updateTelefoneCommand = new MySqlCommand(updateTelefoneQuery, connection, transaction))
                        {
                            updateTelefoneCommand.Parameters.AddWithValue("@ClienteId", cliente.ID);
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

        // 3- MÉTODO EXCLUIR (DESATIVAR) CLIENTE DO BANCO
        // ********** FUNCIONAL **********
        public void ExcluirCliente(int clienteId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Desativar o cliente
                        string updateClienteQuery = "UPDATE cliente SET ativo_cliente = @status WHERE id_cliente = @id";
                        using (MySqlCommand updateClienteCommand = new MySqlCommand(updateClienteQuery, connection, transaction))
                        {
                            updateClienteCommand.Parameters.AddWithValue("@status", false);
                            updateClienteCommand.Parameters.AddWithValue("@id", clienteId);
                            updateClienteCommand.ExecuteNonQuery();
                        }

                        // Desativar o telefone do cliente
                        string updateTelefoneQuery = "UPDATE telefonecliente SET ativo_telcliente = @status WHERE id_cliente = @id";
                        using (MySqlCommand updateTelefoneCommand = new MySqlCommand(updateTelefoneQuery, connection, transaction))
                        {
                            updateTelefoneCommand.Parameters.AddWithValue("@status", false);
                            updateTelefoneCommand.Parameters.AddWithValue("@id", clienteId);
                            updateTelefoneCommand.ExecuteNonQuery();
                        }

                        // Desativar o endereço do cliente
                        string updateEnderecoQuery = "UPDATE enderecocliente SET ativo_endcliente = @status WHERE id_cliente = @id";
                        using (MySqlCommand updateEnderecoCommand = new MySqlCommand(updateEnderecoQuery, connection, transaction))
                        {
                            updateEnderecoCommand.Parameters.AddWithValue("@status", false);
                            updateEnderecoCommand.Parameters.AddWithValue("@id", clienteId);
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
        // 4.1- MÉTODO LISTAR APENAS CLIENTES ATIVOS DO BANCO
        // ********** FUNCIONAL **********
        public List<Cliente> ListarClientesAtivos()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT c.id_cliente, c.nome_cliente, c.email_cliente, c.cnpj_cliente, c.ativo_cliente, 
                                t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                                e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                                e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                                FROM cliente c
                                LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                                LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                                WHERE c.ativo_cliente = true";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int clienteId = reader.GetInt32("id_cliente");

                            Cliente cliente = new Cliente
                            {
                                ID = clienteId,
                                Nome = reader.GetString("nome_cliente"),
                                Email = reader.GetString("email_cliente"),
                                CNPJ = reader.GetString("cnpj_cliente"),
                                StatusAtivo = reader.GetBoolean("ativo_cliente"),
                                Telefone = new TelefoneCliente
                                {
                                    DDD = reader.GetString("ddd_telcliente"),
                                    Numero = reader.GetString("numero_telcliente"),
                                    StatusAtivo = reader.GetBoolean("ativo_telcliente")
                                },
                                Endereco = new EnderecoCliente
                                {
                                    Logradouro = reader.GetString("logradouro_endcliente"),
                                    Numero = reader.GetString("numero_endcliente"),
                                    Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                    Bairro = reader.GetString("bairro_endcliente"),
                                    Cidade = reader.GetString("cidade_endcliente"),
                                    UF = reader.GetString("uf_endcliente"),
                                    CEP = reader.GetString("cep_endcliente"),
                                    StatusAtivo = reader.GetBoolean("ativo_endcliente")
                                }
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }

        // 4.2- MÉTODO LISTAR APENAS CLIENTES INATIVOS DO BANCO
        // O método ListarClientesInativos é responsável por obter a lista de todos os clientes inativos cadastrados no banco de dados e exibir esses dados na tela.
        // ********** FUNCIONAL **********
        public List<Cliente> ListarClientesInativos()
        {
            List<Cliente> clientesInativos = new List<Cliente>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT c.id_cliente, c.nome_cliente, c.email_cliente, c.cnpj_cliente, c.ativo_cliente, 
                        t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                        e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                        e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                        FROM cliente c
                        LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                        LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                        WHERE c.ativo_cliente = 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int clienteId = reader.GetInt32("id_cliente");

                            Cliente cliente = new Cliente
                            {
                                ID = clienteId,
                                Nome = reader.GetString("nome_cliente"),
                                Email = reader.GetString("email_cliente"),
                                CNPJ = reader.GetString("cnpj_cliente"),
                                StatusAtivo = reader.GetBoolean("ativo_cliente"),
                                Telefone = new TelefoneCliente
                                {
                                    DDD = reader.GetString("ddd_telcliente"),
                                    Numero = reader.GetString("numero_telcliente"),
                                    StatusAtivo = reader.GetBoolean("ativo_telcliente")
                                },
                                Endereco = new EnderecoCliente
                                {
                                    Logradouro = reader.GetString("logradouro_endcliente"),
                                    Numero = reader.GetString("numero_endcliente"),
                                    Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                    Bairro = reader.GetString("bairro_endcliente"),
                                    Cidade = reader.GetString("cidade_endcliente"),
                                    UF = reader.GetString("uf_endcliente"),
                                    CEP = reader.GetString("cep_endcliente"),
                                    StatusAtivo = reader.GetBoolean("ativo_endcliente")
                                }
                            };
                            clientesInativos.Add(cliente);
                        }
                    }
                }
            }
            return clientesInativos;
        }

        // 5- Consulta
        // 5.1- MÉTODO CONSULTAR (PESQUISAR) CLIENTE NO BANCO POR ID (somente clientes ativos)
        // ********** FUNCIONAL **********
        public Cliente ConsultarClienteID(int clienteId)
        {
            Cliente cliente = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.id_cliente, c.nome_cliente, c.cnpj_cliente, c.email_cliente,
                                c.ativo_cliente, 
                                t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                                e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                                e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                                FROM cliente c
                                LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                                LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                                WHERE c.id_cliente = @Id";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", clienteId);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            ID = clienteId,
                            Nome = reader.GetString("nome_cliente"),
                            CNPJ = reader.GetString("cnpj_cliente"),
                            Email = reader.GetString("email_cliente"),
                            StatusAtivo = reader.GetBoolean("ativo_cliente"),
                            Telefone = new TelefoneCliente
                            {
                                DDD = reader.GetString("ddd_telcliente"),
                                Numero = reader.GetString("numero_telcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_telcliente")
                            },
                            Endereco = new EnderecoCliente
                            {
                                Logradouro = reader.GetString("logradouro_endcliente"),
                                Numero = reader.GetString("numero_endcliente"),
                                Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                Bairro = reader.GetString("bairro_endcliente"),
                                Cidade = reader.GetString("cidade_endcliente"),
                                UF = reader.GetString("uf_endcliente"),
                                CEP = reader.GetString("cep_endcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_endcliente")
                            }
                        };
                    }
                    return cliente;
                }
            }
        }

        // 5.2- MÉTODO CONSULTAR (PESQUISAR) CLIENTE NO BANCO POR NOME (somente clientes ativos)
        public Cliente ConsultarClienteNome(string clienteNome)
        {
            Cliente cliente = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.id_cliente, c.nome_cliente, c.cnpj_cliente, c.email_cliente, 
                                c.ativo_cliente, 
                                t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                                e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                                e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                                FROM cliente c
                                LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                                LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                                WHERE c.nome_cliente = @Nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", clienteNome);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            ID = reader.GetInt32("id_cliente"),
                            Nome = clienteNome,
                            CNPJ = reader.GetString("cnpj_cliente"),
                            Email = reader.GetString("email_cliente"),
                            StatusAtivo = reader.GetBoolean("ativo_cliente"),
                            Telefone = new TelefoneCliente
                            {
                                DDD = reader.GetString("ddd_telcliente"),
                                Numero = reader.GetString("numero_telcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_telcliente")
                            },
                            Endereco = new EnderecoCliente
                            {
                                Logradouro = reader.GetString("logradouro_endcliente"),
                                Numero = reader.GetString("numero_endcliente"),
                                Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                Bairro = reader.GetString("bairro_endcliente"),
                                Cidade = reader.GetString("cidade_endcliente"),
                                UF = reader.GetString("uf_endcliente"),
                                CEP = reader.GetString("cep_endcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_endcliente")
                            }
                        };
                    }
                    return cliente;
                }
            }
        }

        // 5.3- MÉTODO CONSULTAR (PESQUISAR) CLIENTE NO BANCO POR CNPJ (somente clientes ativos)
        public Cliente ConsultarClienteCNPJ(string clienteCNPJ)
        {
            Cliente cliente = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.id_cliente, c.nome_cliente, c.cnpj_cliente, c.email_cliente, 
                                c.ativo_cliente, 
                                t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                                e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                                e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                                FROM cliente c
                                LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                                LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                                WHERE c.cnpj_cliente = @CNPJ";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CNPJ", clienteCNPJ);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            ID = reader.GetInt32("id_cliente"),
                            Nome = reader.GetString("nome_cliente"),
                            CNPJ = clienteCNPJ,
                            Email = reader.GetString("email_cliente"),
                            StatusAtivo = reader.GetBoolean("ativo_cliente"),
                            Telefone = new TelefoneCliente
                            {
                                DDD = reader.GetString("ddd_telcliente"),
                                Numero = reader.GetString("numero_telcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_telcliente")
                            },
                            Endereco = new EnderecoCliente
                            {
                                Logradouro = reader.GetString("logradouro_endcliente"),
                                Numero = reader.GetString("numero_endcliente"),
                                Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                Bairro = reader.GetString("bairro_endcliente"),
                                Cidade = reader.GetString("cidade_endcliente"),
                                UF = reader.GetString("uf_endcliente"),
                                CEP = reader.GetString("cep_endcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_endcliente")
                            }
                        };
                    }
                    return cliente;
                }
            }
        }

        // 6- MÉTODO FILTRAR LISTA DE CLIENTES POR NOME
        // ********** FUNCIONAL **********
        public List<Cliente> FiltrarClientesNome(string clienteNome)
        {
            List<Cliente> clientes = new List<Cliente>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.id_cliente, c.nome_cliente, c.email_cliente, c.cnpj_cliente, c.ativo_cliente, 
                        t.ddd_telcliente, t.numero_telcliente, t.ativo_telcliente, 
                        e.logradouro_endcliente, e.numero_endcliente, e.complemento_endcliente, e.bairro_endcliente, e.cidade_endcliente, 
                        e.uf_endcliente, e.cep_endcliente, e.ativo_endcliente
                        FROM cliente c
                        LEFT JOIN telefonecliente t ON c.id_cliente = t.id_cliente
                        LEFT JOIN enderecocliente e ON c.id_cliente = e.id_cliente
                        WHERE c.nome_cliente LIKE @nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", "%" + clienteNome + "%");

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            ID = reader.GetInt32("id_cliente"),
                            Nome = reader.GetString("nome_cliente"),
                            Email = reader.GetString("email_cliente"),
                            CNPJ = reader.GetString("cnpj_cliente"),
                            StatusAtivo = reader.GetBoolean("ativo_cliente"),
                            Telefone = new TelefoneCliente
                            {
                                DDD = reader.GetString("ddd_telcliente"),
                                Numero = reader.GetString("numero_telcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_telcliente")
                            },
                            Endereco = new EnderecoCliente
                            {
                                Logradouro = reader.GetString("logradouro_endcliente"),
                                Numero = reader.GetString("numero_endcliente"),
                                Complemento = reader.IsDBNull("complemento_endcliente") ? null : reader.GetString("complemento_endcliente"),
                                Bairro = reader.GetString("bairro_endcliente"),
                                Cidade = reader.GetString("cidade_endcliente"),
                                UF = reader.GetString("uf_endcliente"),
                                CEP = reader.GetString("cep_endcliente"),
                                StatusAtivo = reader.GetBoolean("ativo_endcliente")
                            }
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }




    }
}
