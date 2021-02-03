using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont,resto,contZero=0;

            Console.WriteLine("Informe um número inteiro:");
            num = int.Parse(Console.ReadLine());

            cont = num;
            while(cont<0)
            {
               resto = num % cont; 
               if(resto==0)
                    contZero++;
                cont--; 
            }

            if(contZero>2)
                Console.WriteLine("O número {0} não é primo.",num);
            else
                Console.WriteLine("O número {0} é primo.",num);
        }
    }
}
