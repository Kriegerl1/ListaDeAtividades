namespace Solução_17_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leitura de Valores | Academia de programação 2024!");


            double a = obterValor("Insira o valor de A:");

            double b = obterValor("Insira o valor de B:");

            double c = obterValor("Insira o valor de C:");

            calculoDeIMC(a, b, c);
        }

        static void calculoDeIMC(double a, double b, double c)
        {
            double resultado = a + b;

            if (resultado < c)
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");
                Console.WriteLine("A soma dos valores A e B é menor que o valor de C.");
            }
            else if (resultado > c)
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");

                Console.WriteLine("A soma dos valores A e B é maior que o valor de C.");
            }
            else
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");

                Console.WriteLine("A soma dos valores de A e B é igual ao valor de C");
            }
        }

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}