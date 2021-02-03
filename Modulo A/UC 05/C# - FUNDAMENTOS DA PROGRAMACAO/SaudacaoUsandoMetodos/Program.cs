using System;

namespace SaudacaoUsandoMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}");
            BoasVindas();
        }
        static void BoasVindas()
        {
            if(DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Tenha um bom dia");
            }
            else
            {
                Console.WriteLine("Tenha uma boa noite!");
            }
        }
    }
}
