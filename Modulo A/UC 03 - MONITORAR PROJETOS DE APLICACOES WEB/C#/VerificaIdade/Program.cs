using System;

namespace VerificaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            
            Console.WriteLine("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("Voçê já tem idade para tirar carta!!!");
            }
            else{
                Console.WriteLine("Voçê ainda não pode tirar carta!!!");
            }
        }
    }
}
