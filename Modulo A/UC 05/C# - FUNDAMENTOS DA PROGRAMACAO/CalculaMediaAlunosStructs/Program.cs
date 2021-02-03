using System;

namespace CalculaMediaAlunosStructs
{
    struct Aluno
    {
        public string nome;
        public double nota;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos;
            double media;
            int quantidade;

            Console.Write("Informe quantos alunos: ");
            quantidade = int.Parse(Console.ReadLine());

            alunos = new Aluno[quantidade];
            media = 0;

            for(int i = 0; i < quantidade; i++){
                alunos[i] = new Aluno();

                Console.Write("Digite o nome do aluno: ");
                alunos[i].nome = Console.ReadLine();

                Console.Write("Digite a nota do aluno: ");
                alunos[i].nota = double.Parse(Console.ReadLine()); 
                
                media = media + alunos[i].nota;
            }

            media = media / quantidade;

            Console.WriteLine("Média: {0}", media);

            for(int i = 0; i < quantidade; i++)
            {
                if(alunos[i].nota >= media)
                {
                    Console.WriteLine("Aluno {0} acima da média. Nota {1}", 
                                        alunos[i].nome, alunos[i].nota);
                }
            }
            Console.WriteLine("Fim do Programa");
        }
    }
}
