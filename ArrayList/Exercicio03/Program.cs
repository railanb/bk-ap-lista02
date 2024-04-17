namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

            Console.WriteLine("## Matriz 3x3 ##");
           
            int[,] matriz = new int[3, 3]; 

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.WriteLine("Digite um valor inteiro: ");
                    if(int.TryParse(Console.ReadLine(), out int valorinteiro))
                    {
                        matriz[i, j] = valorinteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor Invalido!");
                        i--;
                    }
                }
            }
            for (int i = 0;i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
