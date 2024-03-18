using System;

namespace Solução_05_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume de Esfera | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume de uma esfera, precisamos que você informe o raio da esfera.");

            Console.Write("Digite o valor do raio: ");
            string raioString = Console.ReadLine();
            double raio = Convert.ToDouble(raioString);

            double raioCubico = Math.Pow(raio, 3);
            double PI = Math.PI;

            double calculoVolume = (4.0 / 3.0) * PI * raioCubico;

            Console.WriteLine($"O volume da esfera é: {calculoVolume.ToString("F")} unidades cúbicas.");
        }
    }
}