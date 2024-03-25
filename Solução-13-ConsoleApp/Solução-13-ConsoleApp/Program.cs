namespace Solução_13_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padaria Hotpão | Academia de programação 2024!\n");


            double paes = obterValor("Quantidade de pães vendidos no dia: ");
            double calculoPaes = paes * 0.12;

            Console.WriteLine("Valor arrecadado com pães foi: " + calculoPaes);

            double broa = obterValor("Quantidade de Broa vendidos no dia: ");
            double calculoBroa = broa * 1.5;

            Console.WriteLine("Valor arrecadado com Broas foi: " + calculoBroa);

            double arrecadacao = calculoBroa + calculoPaes;

            Console.WriteLine("Arrecadação do dia foi: " + arrecadacao.ToString("F"));

            double poupanca = arrecadacao * 0.1;

            Console.WriteLine("Valor direcionado para a poupança é: " + poupanca.ToString("F"));
        }
        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}