using System;

namespace Solução_01_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume, precisamos de algumas informações. " +
                "Por favor, insira as dimensões do objeto (comprimento x largura x altura).");

            Console.WriteLine("Insira a unidade de medida (por exemplo, cm, m, etc.): ");
            string unidadeDeMedida = Console.ReadLine();

            Console.WriteLine("Insira o comprimento: ");
            string comprimentoString = Console.ReadLine();
            double comprimento = Convert.ToDouble(comprimentoString);

            Console.WriteLine("Insira a largura: ");
            string larguraString = Console.ReadLine();
            double largura = Convert.ToDouble(larguraString);

            Console.WriteLine("Insira a altura: ");
            string alturaString = Console.ReadLine();
            double altura = Convert.ToDouble(alturaString);

            double calcVolume = comprimento * largura * altura;

            Console.WriteLine($"O volume do objeto é de {calcVolume.ToString("F")} {unidadeDeMedida}³");
        }
    }
}
