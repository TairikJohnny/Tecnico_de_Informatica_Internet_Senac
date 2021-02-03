using System;
using System.Security.Cryptography;
using System.Text;
namespace TesteMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = args[0]; // Obtém o string digitado no console
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, nome);
                Console.WriteLine("O hash da string digitada <" + nome + "> é: " + hash + ".");
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Converte a string de entrada em um array de bytes e calcula o hash
            byte[] dado = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Cria um construtor de string para passar os bytes gerados
            StringBuilder sBuilder = new StringBuilder();
            // Converte cada byte do hash em uma string em hexadecimal
            for (int i = 0; i < dado.Length; i++)
            {
                sBuilder.Append(dado[i].ToString("x2"));
            }
            // Retorna a string já em hexadecimal
            return sBuilder.ToString();
        }
    }
}