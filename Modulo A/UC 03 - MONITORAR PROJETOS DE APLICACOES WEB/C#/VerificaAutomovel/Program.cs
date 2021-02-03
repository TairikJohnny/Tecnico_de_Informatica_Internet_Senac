using System;

namespace VerificaAutomovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            int ano; 

            Console.WriteLine("Informe a cor desejada para o automóvel:");
            cor = Console.ReadLine(); 

            Console.WriteLine("Informe o ano inicial:");
            ano = int.Parse(Console.ReadLine()); 

            if((cor=="preto" || cor=="cinza") && ano>=2016)
            {
                Console.WriteLine("Automóvel aprovado.");
            }
            else{
                Console.WriteLine("Automovel reprovado");
            }
        }
    }
}
