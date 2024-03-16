using System;

namespace Solução_12_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de área | Academia de Programação 2024!\n");
            Console.WriteLine("Informe o comprimento do terreno (em metros):");
            string comprimentoString = Console.ReadLine();
            double comprimento = Convert.ToDouble(comprimentoString);

            Console.WriteLine("Agora, informe a largura do terreno (em metros):");
            string larguraString = Console.ReadLine();
            double largura = Convert.ToDouble(larguraString);

            double calculoArea = comprimento * largura;

            Console.WriteLine($"A área do terreno é de: {calculoArea}m²");
            if (comprimento == largura)
            {
                Console.WriteLine("Mas infelizmente o terreno não está nos padrões de venda da imobiliária.");
            }
        }
    }
}
