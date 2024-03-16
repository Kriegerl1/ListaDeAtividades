using System;

namespace Solução18ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());


            int[] numeros = { numero1, numero2, numero3 };

            Array.Sort(numeros);

            Console.WriteLine("Números ordenados:");
            foreach (int numero in numeros)
            {
                Array.Reverse(numeros);
                Console.WriteLine(numero);
            }
        }
    }
}
