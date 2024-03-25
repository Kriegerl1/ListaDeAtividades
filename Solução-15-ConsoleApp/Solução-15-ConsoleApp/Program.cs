    namespace Solução_15_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura | Academia de programação 2024!\n");


            double celsius = obterValor($"Digite a temperatura que deseja fazer a conversão: ");


            double conversor = (celsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em fahrenheit é: {conversor}");
        }

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}