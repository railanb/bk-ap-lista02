namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numers = new int[4, 4];

            Random random = new Random();

            for (int i = 0; i < numers.GetLength(0); i++)
            {
                for (int j = 0; j < numers.GetLongLength(0); j++)
                {

                    numers[i, j] = random.Next(int.MinValue, int.MaxValue);
                }
            }
            int maior = numers[0, 0];
            for (int i = 0; i < numers.GetLength(0); i++)
            {
                for (int j = 0; j < numers.GetLongLength(0); j++)
                {
                    if (numers[i, j] > maior)
                    {
                        maior = numers[i, j];
                    }
                }
            }
            Console.WriteLine($"O maior valor da matrix seria: {maior}");
        }
    }
}
