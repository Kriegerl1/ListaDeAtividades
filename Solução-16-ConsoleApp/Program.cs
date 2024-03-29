﻿namespace CalculoDeDeduçãoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Dedução | Academia de programação 2024!");

            Console.WriteLine("Informe o salário atual do funcionário:");

            string salarioAtualString = Console.ReadLine();
            double salarioAtual = Convert.ToDouble(salarioAtualString);

            double aumentoSalarial = salarioAtual * 1.15;
            double impostoSalario = aumentoSalarial * .92;

            Console.WriteLine($"O salário inicial é: {salarioAtual.ToString("F")}\nO salário com aumento é: {aumentoSalarial.ToString("F")}\n" +
                $"O salário com impostos é: {impostoSalario.ToString("F")}");

        }
    }
}
