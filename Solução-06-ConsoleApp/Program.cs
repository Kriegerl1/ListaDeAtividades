using System;

namespace Solução_06_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Celsius para Fahrenheit | Academia de Programação 2024!\n");

            Console.WriteLine("Por favor, digite a temperatura em Celsius que deseja converter para Fahrenheit:");
            string cString = Console.ReadLine();
            double C = Convert.ToDouble(cString);

            double conversor = (9.0 / 5.0) * C + 32;

            Console.WriteLine($"A temperatura convertida de Celsius para Fahrenheit é: {conversor}°F");
        }
    }
}
