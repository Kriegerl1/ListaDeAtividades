using System;

namespace Solução_02_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura | Academia de programação 2024!\n");

            Console.WriteLine("Digite a temperatura em Graus Fahrenheit para fazer a conversão:");

            string fahrenheitString = Console.ReadLine();
            double fahrenheit = Convert.ToDouble(fahrenheitString);

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");
        }
    }
}