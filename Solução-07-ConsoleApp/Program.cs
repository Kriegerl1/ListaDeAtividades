using System;

namespace Solução_07_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de salário comissionado | Academia de Programação 2024!\n");

            Console.WriteLine("Por favor, insira o salário base do vendedor:");
            string salarioBaseString = Console.ReadLine();
            double salarioBase = Convert.ToDouble(salarioBaseString);

            Console.WriteLine("Por favor, insira o total de vendas do vendedor:");
            string vendasTotaisString = Console.ReadLine();
            int vendasTotais = Convert.ToInt32(vendasTotaisString);
 
            Console.WriteLine("Por favor, insira o valor do produto vendido:");
            string valorProdutoVendidoString = Console.ReadLine();
            double valorProdutoVendido = Convert.ToDouble(valorProdutoVendidoString);

            Console.WriteLine("Por favor, insira a porcentagem da comissão (%):");
            string porcentagemComissaoString = Console.ReadLine();
            double porcentagemComissao = Convert.ToDouble(porcentagemComissaoString);

            double salarioTotal = salarioBase + (vendasTotais * (valorProdutoVendido * (porcentagemComissao / 100)));

            Console.WriteLine($"O Salário total do vendedor é de: {salarioTotal:F}");

        }
    }
}
