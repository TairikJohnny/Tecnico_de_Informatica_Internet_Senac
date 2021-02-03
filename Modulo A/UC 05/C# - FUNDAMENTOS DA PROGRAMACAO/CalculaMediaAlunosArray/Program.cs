using System;

namespace CalculaMediaAlunosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            string[] nomes;
            double media;
            int quantidade;

            Console.Write("Informe quantos alunos: ");
            quantidade = int.Parse(Console.ReadLine());

            notas = new double[quantidade];
            nomes = new string[quantidade];
            media = 0;

            for(int i = 0; i < quantidade; i++){
                Console.Write("Digite o nome do aluno: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a nota do aluno: ");
                notas[i] = double.Parse(Console.ReadLine()); 
                //vírgula separa decimal p/ o double.Parse
                media = media + notas[i];
            }

            media = media / quantidade;

            Console.WriteLine("Média: {0}", media);

            for(int i = 0; i < quantidade; i++)
            {
                if(notas[i] >= media)
                {
                    Console.WriteLine("Aluno {0} acima da média. Nota {1}",
                                        nomes[i], notas[i]);
                }
            }
            
            Console.WriteLine("Fim do Programa");
        }
    }
}
