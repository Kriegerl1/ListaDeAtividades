using System;

namespace CalculadoraMediaHarmonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média Harmônica\n");
            Console.WriteLine("Digite os números separados por espaço:");

            string input = Console.ReadLine();

            string[] numerosStr = input.Split(' ');

            double somaReciprocos = 0;

            int n = numerosStr.Length;

            foreach (string numeroStr in numerosStr)
            {
                if (double.TryParse(numeroStr, out double numero))
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("Não é possível calcular a média harmônica com números iguais a zero.");
                        return;
                    }
                    somaReciprocos += 1 / numero;
                }
                else
                {
                    Console.WriteLine($"'{numeroStr}' não é um número válido.");
                    return;
                }
            }

            double mediaHarmonica = n / somaReciprocos;

            Console.WriteLine($"A média harmônica é: {mediaHarmonica}");
        }
    }
}
