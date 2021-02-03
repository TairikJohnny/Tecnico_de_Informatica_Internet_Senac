using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ExemploCRUD.Models
{
    public class PacoteBanco
    {
        private const string DadosConexao = "Database=exemplo_crud; Data Source=localhost; User Id=root";

        public List<Pacote> Listar()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Pacotes";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Pacote> Lista = new List<Pacote>();

            while (Reader.Read())
            {

                Pacote PacoteEncontrado = new Pacote();

                PacoteEncontrado.IdPacotes = Reader.GetInt32("IdPacotes");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomePacote")))
                {
                    PacoteEncontrado.NomePacote = Reader.GetString("NomePacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("OrigemPacote")))
                {
                    PacoteEncontrado.OrigemPacote = Reader.GetString("OrigemPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DestinoPacote")))
                {
                    PacoteEncontrado.DestinoPacote = Reader.GetString("DestinoPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("AtrativosPacote")))
                {
                    PacoteEncontrado.AtrativosPacote = Reader.GetString("AtrativosPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Saida")))
                {
                    PacoteEncontrado.Saida = Reader.GetString("Saida");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Retorno")))
                {
                    PacoteEncontrado.Retorno = Reader.GetString("Retorno");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Id")))
                {
                    PacoteEncontrado.Id = Reader.GetInt32("Id");
                }

                Lista.Add(PacoteEncontrado);
            }
            Conexao.Close();
            return Lista;
        }

        public void Atualizar(Pacote pacote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "UPDATE Pacotes SET NomePacote=@NomePacote, OrigemPacote=@OrigemPacote, DestinoPacote=@DestinoPacote, AtrativosPacote=@AtrativosPacote, Saida=@Saida, Retorno=@Retorno, Id=@Id WHERE IdPacotes=@IdPacotes";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@NomePacote", pacote.NomePacote);
            Comando.Parameters.AddWithValue("@OrigemPacote", pacote.OrigemPacote);
            Comando.Parameters.AddWithValue("@DestinoPacote", pacote.DestinoPacote);
            Comando.Parameters.AddWithValue("@AtrativosPacote", pacote.AtrativosPacote);
            Comando.Parameters.AddWithValue("@Saida", pacote.Saida);
            Comando.Parameters.AddWithValue("@Retorno", pacote.Retorno);
            Comando.Parameters.AddWithValue("@Id", pacote.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Remover(int IdPacotes)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "DELETE FROM Pacotes WHERE IdPacotes=@IdPacotes";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdPacotes", IdPacotes);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public Pacote BuscarPorId(int IdPacotes)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Pacotes WHERE IdPacotes=@IdPacotes";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdPacotes", IdPacotes);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Pacote PacoteEncontrado = new Pacote();

            if (Reader.Read())
            {

                PacoteEncontrado.Id = Reader.GetInt32("IdPacotes");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomePacote")))
                {
                    PacoteEncontrado.NomePacote = Reader.GetString("NomePacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("OrigemPacote")))
                {
                    PacoteEncontrado.OrigemPacote = Reader.GetString("OrigemPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DestinoPacote")))
                {
                    PacoteEncontrado.DestinoPacote = Reader.GetString("DestinoPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("AtrativosPacote")))
                {
                    PacoteEncontrado.AtrativosPacote = Reader.GetString("AtrativosPacote");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Saida")))
                {
                    PacoteEncontrado.Saida = Reader.GetString("Saida");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Retorno")))
                {
                    PacoteEncontrado.Retorno = Reader.GetString("Retorno");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Id")))
                {
                    PacoteEncontrado.Id = Reader.GetInt32("Id");
                }
            }
            Conexao.Close();
            return PacoteEncontrado;
        }

        public void Inserir(Pacote pacote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO Pacotes (NomePacote, OrigemPacote, DestinoPacote, AtrativosPacote, Saida, Retorno, Id) VALUES (@NomePacote, @OrigemPacote, @DestinoPacote, @AtrativosPacote, @Saida, @Retorno, @Id)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@NomePacote", pacote.NomePacote);
            Comando.Parameters.AddWithValue("@OrigemPacote", pacote.OrigemPacote);
            Comando.Parameters.AddWithValue("@DestinoPacote", pacote.DestinoPacote);
            Comando.Parameters.AddWithValue("@AtrativosPacote", pacote.AtrativosPacote);
            Comando.Parameters.AddWithValue("@Saida", pacote.Saida);
            Comando.Parameters.AddWithValue("@Retorno", pacote.Retorno);
            Comando.Parameters.AddWithValue("@Id", pacote.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}