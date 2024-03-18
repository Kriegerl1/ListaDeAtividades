using System;

namespace Solução_04_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de consumo de combustível | Academia de Programação 2024!\n");

            Console.WriteLine("Digite a quilometragem inicial do veículo:");
            string inicioString = Console.ReadLine();
            double inicio = Convert.ToDouble(inicioString);

            Console.WriteLine("Digite a quilometragem final do veículo:");
            string finalString = Console.ReadLine();
            double fim = Convert.ToDouble(finalString);

            Console.WriteLine("Informe a quantidade total de combustível consumida (em litros):");
            string gasTotalString = Console.ReadLine();
            double gasTotal = Convert.ToDouble(gasTotalString);

            if (inicio >= fim)
            {
                Console.WriteLine("Erro: A quilometragem inicial não pode ser maior ou igual à quilometragem final.");
            }
            else
            {
                double mediaKM = (fim - inicio) / gasTotal;
                Console.WriteLine($"O consumo médio do veículo foi de {mediaKM:F2} km/l.");
            }
        }
    }
}