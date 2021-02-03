using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; //declaração da variável nome
                float media, nota1, nota2, nota3, nota4; //declaração das variáveis de notas e média
                Console.WriteLine("Informe seu nome:");
                nome = Console.ReadLine(); //leitura do nome
                Console.WriteLine("Informe a primeira nota:");
                nota1 = float.Parse(Console.ReadLine()); //leitura da primeira nota
                Console.WriteLine("Informe a segunda nota:");
                nota2 = float.Parse(Console.ReadLine()); //leitura da segunda nota
                Console.WriteLine("Informe a terceira nota:");
                nota3 = float.Parse(Console.ReadLine()); //leitura da terceira nota
                Console.WriteLine("Informe a quarta nota:");
                nota4 = float.Parse(Console.ReadLine()); //leitura da quarta nota
                media = (nota1 + nota2 + nota3 + nota4) / 4; // expressão aritmética para cálculo da média
                Console.WriteLine(nome+", você ficou com média {0:N}",media); //impressão do nome e média
        }
    }
}
