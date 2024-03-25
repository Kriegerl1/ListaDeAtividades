namespace Solução_14_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Idade por dias | Academia de programação 2024!\n");

            string nome = obterValor<string>("Digite seu Nome: ");

            Console.WriteLine($"Olá {nome}, para que eu possa calcular a sua idade em dias, preciso que informe a sua idade.");

            int idade = obterValor<int>("Digite sua idade: ");

            int idadeDias = idade * 365;

            Console.WriteLine($"Você tem {idadeDias} dias de vida.");
        }

        static Tipo obterValor<Tipo>(string texto)
        {
            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (Tipo)Convert.ChangeType(input, typeof(Tipo));
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido, tente novamente!");
                return obterValor<Tipo>(texto);
            }
        }
    }
}