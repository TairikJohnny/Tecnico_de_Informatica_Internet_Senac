using System;

namespace ConverteCelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp_celsius, temp_fahrenheit; //declarando as variaveis 
            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            temp_celsius = float.Parse(Console.ReadLine()); //le e converte de string para float
            temp_fahrenheit = (temp_celsius * 1.8f) + 32f; //formula para conversão
            Console.WriteLine("A temperatura em Fahrenheit é: {0:N}°F", temp_fahrenheit);
        }
    }
}
