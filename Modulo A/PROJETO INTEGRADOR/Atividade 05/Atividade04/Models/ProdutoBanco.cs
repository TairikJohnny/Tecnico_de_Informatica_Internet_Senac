using System.Collections.Generic;
using MySqlConnector;

namespace Atividade04.Models
{
    public class ProdutoBanco
    {
        private const string DadosConexao = "Database=exemplo_crud; Data Source=localhost; User Id=root";

        public List<Produto> Listar()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Produto";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Produto> Lista = new List<Produto>();

            while (Reader.Read())
            {

                Produto ProdutoEncontrado = new Produto();

                ProdutoEncontrado.IdProduto = Reader.GetInt32("IdProduto");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                {
                    ProdutoEncontrado.NomeProduto = Reader.GetString("NomeProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("MarcaProduto")))
                {
                    ProdutoEncontrado.MarcaProduto = Reader.GetString("MarcaProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("CorProduto")))
                {
                    ProdutoEncontrado.CorProduto = Reader.GetString("CorProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("TamanhoProduto")))
                {
                    ProdutoEncontrado.TamanhoProduto = Reader.GetString("TamanhoProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("QuantidadeEstoque")))
                {
                    ProdutoEncontrado.QuantidadeEstoque = Reader.GetInt32("QuantidadeEstoque");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Preco")))
                {
                    ProdutoEncontrado.Preco = Reader.GetDouble("Preco");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DataCadastro")))
                {
                    ProdutoEncontrado.DataCadastro = Reader.GetString("DataCadastro");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Id")))
                {
                    ProdutoEncontrado.Id = Reader.GetInt32("Id");
                }

                Lista.Add(ProdutoEncontrado);
            }
            Conexao.Close();
            return Lista;
        }

        public void Atualizar(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "UPDATE Produto SET NomeProduto=@NomeProduto, MarcaProduto=@MarcaProduto, CorProduto=@CorProduto, TamanhoProduto=@TamanhoProduto, QuantidadeEstoque=@QuantidadeEstoque, Preco=@Preco, DataCadastro=@DataCadastro, Id=@Id WHERE IdProduto=@IdProduto";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            Comando.Parameters.AddWithValue("@MarcaProduto", produto.MarcaProduto);
            Comando.Parameters.AddWithValue("@CorProduto", produto.CorProduto);
            Comando.Parameters.AddWithValue("@TamanhoProduto", produto.TamanhoProduto);
            Comando.Parameters.AddWithValue("@QuantidadeEstoque", produto.QuantidadeEstoque);
            Comando.Parameters.AddWithValue("@Preco", produto.Preco);
            Comando.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
            Comando.Parameters.AddWithValue("@Id", produto.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Remover(int IdProduto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "DELETE FROM Produto WHERE IdProduto=@IdProduto";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdProduto", IdProduto);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public Produto BuscarPorId(int IdProduto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Produto WHERE IdProduto=@IdProduto";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdProduto", IdProduto);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Produto ProdutoEncontrado = new Produto();

            if (Reader.Read())
            {

                ProdutoEncontrado.IdProduto = Reader.GetInt32("IdProduto");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                {
                    ProdutoEncontrado.NomeProduto = Reader.GetString("NomeProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("MarcaProduto")))
                {
                    ProdutoEncontrado.MarcaProduto = Reader.GetString("MarcaProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("CorProduto")))
                {
                    ProdutoEncontrado.CorProduto = Reader.GetString("CorProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("TamanhoProduto")))
                {
                    ProdutoEncontrado.TamanhoProduto = Reader.GetString("TamanhoProduto");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("QuantidadeEstoque")))
                {
                    ProdutoEncontrado.QuantidadeEstoque = Reader.GetInt32("QuantidadeEstoque");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Preco")))
                {
                    ProdutoEncontrado.Preco = Reader.GetDouble("Preco");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DataCadastro")))
                {
                    ProdutoEncontrado.DataCadastro = Reader.GetString("DataCadastro");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Id")))
                {
                    ProdutoEncontrado.Id = Reader.GetInt32("Id");
                }
            }
            Conexao.Close();
            return ProdutoEncontrado;
        }

        public void Inserir(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO Produto (NomeProduto, MarcaProduto, CorProduto, TamanhoProduto, QuantidadeEstoque, Preco, DataCadastro, Id) VALUES (@NomeProduto, @MarcaProduto, @CorProduto, @TamanhoProduto, @QuantidadeEstoque, @Preco, @DataCadastro, @Id)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            Comando.Parameters.AddWithValue("@MarcaProduto", produto.MarcaProduto);
            Comando.Parameters.AddWithValue("@CorProduto", produto.CorProduto);
            Comando.Parameters.AddWithValue("@TamanhoProduto", produto.TamanhoProduto);
            Comando.Parameters.AddWithValue("@QuantidadeEstoque", produto.QuantidadeEstoque);
            Comando.Parameters.AddWithValue("@Preco", produto.Preco);
            Comando.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
            Comando.Parameters.AddWithValue("@Id", produto.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}