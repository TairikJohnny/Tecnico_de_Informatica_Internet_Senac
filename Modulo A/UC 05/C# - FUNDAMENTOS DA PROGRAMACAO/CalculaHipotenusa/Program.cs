using System;

namespace CalculaHipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1, cateto2, hipotenusa;
            string continua;

            do{
                Console.Write("Informe cateto oposto: ");
                cateto1 = double.Parse(Console.ReadLine());

                Console.Write("Informe cateto adjacente: ");
                cateto2 = double.Parse(Console.ReadLine());

                hipotenusa = Math.Sqrt(Quadrado(cateto1) + Quadrado(cateto2));

                Console.WriteLine("Hipotenusa: " + hipotenusa);

                Console.Write("Deseja continuar? [s/n] ");

                continua = Console.ReadLine();
                
            }while(continua != "n");
        }
        static double Quadrado(double numero)
        {
            double quadrado = numero * numero;
            return quadrado;
        }
    }
}
