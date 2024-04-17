namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = 0;

            Console.WriteLine("Entre com o tamanho do vetor: ");
            if(int.TryParse(Console.ReadLine(), out tamanhoVetor) )
            {
                int[] vetor = new int[tamanhoVetor];
                int[] vetor2 = new int[tamanhoVetor];
                int[] vetorResultado = new int[tamanhoVetor];
                PreenchimentoVetor(vetor);
                PreenchimentoVetor(vetor2);
                for(int i = 0; i < vetor.Length; i++)
                {
                    vetorResultado[i] = vetor[i] + vetor2[i];
                }
                ImprimeVetor(vetorResultado);
            }

            static void PreenchimentoVetor(int[] vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Digite um valor inteiro: ");
                    if (int.TryParse(Console.ReadLine(), out int valorinteiro))
                    {
                        vetor[i] = valorinteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor Invalido!");
                        i--;
                    }
                }
                ImprimeVetor(vetor);
            }
        }
        static void ImprimeVetor(int[] vetor)
        {
            foreach (int valorInteiro in vetor)
            {
                Console.WriteLine($"Valor: {valorInteiro}");
            }
        }
    }
}
