using System;

namespace ARQUITETURA_WEB_EM_CAMADAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            int dias = 100; //atribuindo valor a variavel
            string nomeClienteAtual = "Fulano";
            //float fornecedor;
            //float alturaCliente;
            /*
            nomeClienteAtual = Console.ReadLine(); //entrada de dados
            dias = int.Parse(Console.ReadLine()); //convertendo uma entrada do tipo inteiro
            alturaCliente = float.Parse(Console.ReadLine()); //convertendo uma entrada do tipo float
            */
            //saida de dados
            Console.WriteLine("Hello World!");
            Console.WriteLine("Segunda linha " + dias); //concatenando
            Console.WriteLine("A altura é: {0:N}"); //numero de casas decimais 
            Console.WriteLine("O nome é: {0} e os dias são: {1}", nomeClienteAtual, dias); //duas variaves na saida de dados
            //outra maneira de substituir variaveis
            string info = $"A quantidade de dias é {dias} e o nome do cliente é {nomeClienteAtual}";
            Console.WriteLine(info);

        }
    }
}
