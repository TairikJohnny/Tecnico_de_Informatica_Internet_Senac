using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            DateTime hoje = DateTime.Today;
            DateTime dt_nascimento;

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a sua data de nascimento: (dd/mm/aaaa)");
            dt_nascimento = DateTime.Parse(Console.ReadLine());

            idade = hoje.Year - dt_nascimento.Year;

            Console.WriteLine(idade);

            if (idade >= 18){
                Console.WriteLine("Ola " + nome + ", você é maior de idade, a sua senha é: " + idade + nome);
            }
            else{
                Console.WriteLine("Ola " + nome + ", você é menor de idade, a sua senha é: " + nome + idade);
            }
        }
    }
}
