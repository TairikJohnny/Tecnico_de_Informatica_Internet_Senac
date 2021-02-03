using System;

namespace MediaSalariosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0,media;
            int cont;

            for(cont=1;cont<=5;cont++)
            {
              Console.WriteLine("Informe o valor do salário:");
              salario = float.Parse(Console.ReadLine());
              soma = soma + salario; 
            }

            media = soma / cont;
            
            Console.WriteLine("O valor médio dos salários é: {0:N}",media);
        }
    }
}
