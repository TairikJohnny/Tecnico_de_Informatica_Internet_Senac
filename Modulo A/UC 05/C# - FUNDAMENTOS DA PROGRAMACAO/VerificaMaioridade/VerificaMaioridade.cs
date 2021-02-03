using System;

namespace C__LINGUEGEM_DE_SCRIPTS_E_FUNDAMENTOS_DA_PROGRAMACAO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* definição de variáveis locais do tipo inteiro */
            int anoNascimento, idade;

            Console.WriteLine("Informe o ano que voce nasceu: ");

            anoNascimento = int.Parse(Console.ReadLine()); //leitura de dados do usuário

            idade = DateTime.Now.Year - anoNascimento; //ano atual - ano informado

            /* desvio condicional */
            if (idade > 0)
            {
                if (idade >= 18) //if aninhado
                {
                    Console.WriteLine("Maior de idade");
                }
                else 
                {
                    Console.WriteLine("Menor de idade");
                }
            }
            else // idade é menor que zero
            {
                Console.WriteLine("Ano de nascimento inválido");
            }
        }
    }
}
