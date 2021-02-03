using System;

namespace CalculaAreaRetanguloTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double retangulo = CalculaAreaRetangulo(10, 5);
            Console.WriteLine($"Área do retângulo: {retangulo}");
            
            double triangulo = CalculaAreaTriangulo(3, 4);
            Console.WriteLine($"Área do triângulo: {triangulo}");
        }
        static double CalculaAreaRetangulo(double b, double h)
        {
            double area = b * h;
            return area;
        }
        static double CalculaAreaTriangulo(double b, double h)
        {
            double area = CalculaAreaRetangulo(b, h);
            area = area / 2;
            return area;
        }
        
    }
}
