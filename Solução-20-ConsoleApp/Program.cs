using System;

namespace Solução_20_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classificador de Números Par e Ímpar | Academia de Programação 2024!\n");
            Console.WriteLine("Por favor, digite um número e pressione Enter para verificar se é par ou ímpar:");

            string numeroString = Console.ReadLine();

            // Validar entrada
            int numero = Convert.ToInt32(numeroString);

            // Verificar se o número é par ou ímpar
            if (numero % 2 != 0)
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é par.");
            }
        }
    }
}
