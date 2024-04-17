using System.Drawing;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.

            Console.WriteLine("## Comparação de 5 valores maior e menor ##");

            int[] numero = { num(), num(), num(), num(), num() };

            Console.WriteLine($"## \nO menor numero é {numero.Min()}");
            Console.WriteLine($"## \nO maior numero é {numero.Max()}");

            Console.WriteLine("\n--> Os valores informados foram ");


            foreach (int i in numero)
            {
                Console.Write($"{i} ");
            }

        }
        static int num()
        {
            Console.Write("Digite um valor: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
