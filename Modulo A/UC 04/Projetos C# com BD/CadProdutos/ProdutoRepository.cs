using System;
using System.Collections.Generic;
using MySqlConnector;

namespace CadProdutos
{
    public class ProdutoRepository
    {
        // Criando uma conexao e declarando a string como constante
        // Database=admprodutos = nome do BD
        // Data Source=localhost = endereco do BD
        // User Id=root = usuario BD
        // Caso tivesse senha = Password=123456789
        private const string enderecoConexao = "Database=admprodutos;Data Source=localhost;User Id=root;";

        // Passando as variaveis na chamada do metodo
        public void Insert(string nome, string fabricante)
        {
            // Abrindo conexao
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);

            // Abrindo a conexao
            conexao.Open();

            // Insert na tabela produto
            string sqlInsert =
            "INSERT INTO produto (nome, fabricante, preco, dataCadastro, disponivel)"+
            "VALUES ('"+ nome +"', '"+ fabricante +"', 1.99, NOW(), 1)";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);
            
            // Executa o comando no BD
            comando.ExecuteNonQuery();

            // Encerrando a conexao
            conexao.Close();
        }

        public List<Produto> Query(string filtroNome)
        {
            // Abrindo conexao
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            // Select no BD
            string sqlSelect = "SELECT * FROM produto";
            // Verificando se ha valor no filtroNome se tiver utiliza o filtro abaixo
            if(!String.IsNullOrEmpty(filtroNome))
            sqlSelect = sqlSelect + $" WHERE nome like '{filtroNome}%'";

            sqlSelect = sqlSelect + " ORDER BY nome";

            // Criando um objeto da classe MySqlCommand
            MySqlCommand comandoQuery = new MySqlCommand(sqlSelect, conexao);
            // Atribuindo os valores a variavel resultado
            MySqlDataReader resultado = comandoQuery.ExecuteReader();

            // Criando uma lista chamada listaProdutos da classe Produto
            List<Produto> listaProdutos = new List<Produto>();

            // Quando o resultado.Read() retornar false pq acabou os registros, sai do while
            while(resultado.Read()){
                // Criando um objeto
                Produto item = new Produto();
                // Retornando os resultados
                item.Id=resultado.GetInt32("Id");
                item.Nome = resultado.GetString("Nome");
                item.Fabricante = resultado.GetString("Fabricante");
                item.Preco = resultado.GetDecimal("preco");
                item.Disponivel = resultado.GetBoolean("disponivel");
                item.DataCadastro = resultado.GetDateTime("dataCadastro");
                // Adicionando os valeros na lista
                listaProdutos.Add(item);
            }
            // Encerrando a conexao
            resultado.Close();
            conexao.Close();

            return listaProdutos;
        }

        public void Update(Produto p)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlUpdate =
                "UPDATE produto " +
                " SET nome = '"+ p.Nome +"', fabricante = '"+ p.Fabricante + "', " +
                " preco = "+ p.Preco.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) +", "+
                " disponivel = " + (p.Disponivel ? 1 : 0) +
                " WHERE id="+ p.Id ;

            MySqlCommand comando = new MySqlCommand(sqlUpdate, conexao);
            comando.ExecuteNonQuery();
            
            conexao.Close();
        }
    }
}