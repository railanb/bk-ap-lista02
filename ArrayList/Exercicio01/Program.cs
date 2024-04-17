using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.

            Console.WriteLine("## Digite os valores para o Array ##");

            int[] valor = { valorEntr(), valorEntr(), valorEntr(), valorEntr(), valorEntr() };

            Console.WriteLine("Os valores informados são: ");

            foreach (int i in valor)
            {
                Console.Write($"{i} ");
            }

        }
        static int valorEntr()
        {
            Console.Write("Informe o valor: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
