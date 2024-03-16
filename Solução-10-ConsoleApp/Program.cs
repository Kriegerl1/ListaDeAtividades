using System;

namespace Solução_10_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de média ponderada | Academia de Programação 2024!\n");

            Console.WriteLine("Digite a primeira nota:");
            string nota1String = Console.ReadLine();
            double nota1 = Convert.ToDouble(nota1String);
            Console.WriteLine("Digite o peso da primeira nota:");
            string peso1String = Console.ReadLine();
            int peso1 = Convert.ToInt32(peso1String);

            Console.WriteLine("Digite a segunda nota:");
            string nota2String = Console.ReadLine();
            double nota2 = Convert.ToDouble(nota2String);
            Console.WriteLine("Digite o peso da segunda nota:");
            string peso2String = Console.ReadLine();
            int peso2 = Convert.ToInt32(peso2String);

            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");
        }
    }
}
