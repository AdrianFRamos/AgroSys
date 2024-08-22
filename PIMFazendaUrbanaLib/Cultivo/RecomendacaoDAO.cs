using MySql.Data.MySqlClient;

namespace PIMFazendaUrbanaLib
{
    public class RecomendacaoDAO
    {
        private string connectionString;
        public RecomendacaoDAO()
        {
            this.connectionString = ConnectionString.GetConnectionString();
        }

        public List<Cultivo> GerarRecomendacao(string regiao, string estacao)
        {
            List<Cultivo> cultivos = new List<Cultivo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT c.*
                                FROM cultivo c
                                JOIN recomendacaocultivo rec ON c.id_cultivo = rec.id_cultivo
                                WHERE rec.regiao = @regiao AND rec.estacao = @estacao ORDER BY id_cultivo;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@regiao", regiao);
                    command.Parameters.AddWithValue("@estacao", estacao);

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

    }
}
