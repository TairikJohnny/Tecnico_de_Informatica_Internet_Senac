using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ExemploCRUD.Models
{
    public class UsuarioBanco
    {
        private const string DadosConexao = "Database=exemplo_crud; Data Source= localhost; User Id=root";

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Console.WriteLine("Banco de dados funcionando!");

            Conexao.Close();
        }

        public Usuario ValidarLogin(Usuario usuario)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Usuario WHERE Login=@Login AND Senha=@Senha";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario UsuarioEncontrado = null;

            if (Reader.Read())
            {

                UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento")))
                {
                    UsuarioEncontrado.DataNascimento = Reader.GetString("DataNascimento");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Conta")))
                {
                    UsuarioEncontrado.Conta = Reader.GetString("Conta");
                }
            }
            Conexao.Close();
            return UsuarioEncontrado;
        }

        public List<Usuario> Listar()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Usuario";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>();

            while (Reader.Read())
            {

                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento")))
                {
                    UsuarioEncontrado.DataNascimento = Reader.GetString("DataNascimento");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Conta")))
                {
                    UsuarioEncontrado.Conta = Reader.GetString("Conta");
                }

                Lista.Add(UsuarioEncontrado);
            }
            Conexao.Close();
            return Lista;
        }

        public void Inserir(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "INSERT INTO Usuario (Nome, DataNascimento, Login, Senha, Conta) VALUES (@Nome, @DataNascimento, @Login, @Senha, @Conta)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            Comando.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Conta", usuario.Conta);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Atualizar(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "UPDATE Usuario SET Nome=@Nome, DataNascimento=@DataNascimento, Login=@Login, Senha=@Senha, Conta=@Conta WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            Comando.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Conta", usuario.Conta);
            Comando.Parameters.AddWithValue("@Id", usuario.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Remover(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "DELETE FROM Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public Usuario BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            string Query = "SELECT * FROM Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario UsuarioEncontrado = new Usuario();

            if (Reader.Read())
            {

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento")))
                {
                    UsuarioEncontrado.DataNascimento = Reader.GetString("DataNascimento");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Conta")))
                {
                    UsuarioEncontrado.Conta = Reader.GetString("Conta");
                }
            }
            Conexao.Close();
            return UsuarioEncontrado;
        }
    }
}