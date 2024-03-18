using System;

namespace Solução_09_ConsoleApp
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média harmônica | Academia de Programação 2024!\n");
            Console.WriteLine("Definitivamente só a média foi harmonica nisso...\n");
            
            
            Console.WriteLine("Digite os números separados por espaço:");

            string[] input = Console.ReadLine().Split(' ');

            int n = input.Length;
            double media_harmonica;
            double soma = 0;

            for (int i = 0; i < input.Length; i++)
            {
                soma = soma + Convert.ToInt32(input[i]);
            } 

            media_harmonica = soma / n;

            Console.WriteLine($"\nA Média Harmônica é:{ media_harmonica}");
            Console.ReadLine();
        }
    }
}