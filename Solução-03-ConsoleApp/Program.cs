using System;

namespace Solução_03_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume de Cilindro | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume, precisamos de algumas informações. " +
                "Por favor, insira as dimensões do cilindro (raio x altura).");

            Console.WriteLine("Insira a unidade de medida (por exemplo, cm, m, etc.): ");
            string unidadeMedida = Console.ReadLine();

            double PI = Math.PI;

            Console.WriteLine("Insira o raio do cilindro: ");
            string raioString = Console.ReadLine();
            double raio = Convert.ToDouble(raioString);

            Console.WriteLine("Insira a altura do cilindro: ");
            string alturaString = Console.ReadLine();
            double altura = Convert.ToDouble(alturaString);

            double raioQuadrado = Math.Pow(raio, 2);
            double volumeDoCilindro = PI * raioQuadrado * altura;

            Console.WriteLine($"O volume do cilindro é: {volumeDoCilindro.ToString("F")} {unidadeMedida}³");
        }
    }
}