using System;

namespace SomandoMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
           Somar(62, 24);
        }
        static void Somar(int num1, int num2)
        {
            int soma;
            soma = num1 + num2;
            Console.WriteLine("Resultado da soma " + soma);
        }
    }
}
