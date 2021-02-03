using System;

namespace MetodoRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial: " + CalculaFatorial(4));
        }

        private static float CalculaFatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculaFatorial(n - 1);
            }
        }
    }
}
