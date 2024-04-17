namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };

            const int nome = 0;
            const int especie = 1;
            const int idade = 2;
            const int peso = 3;

            Console.WriteLine("## Pesquisa dos Pets ##");
            MenuDeOpcoes(out string operacao);
            
            if (operacao == "exit")
            {
                return;
            }

            switch (operacao)
            {
                case "0":
                    for (int i = 0; i < animais.GetLength(0); i++)
                    {
                        Console.WriteLine($"Localizado estes nomes: {animais[i, nome]}");
                    }
                    break;
                case "1":
                    for (int i = 0; i < animais.GetLength(0); i++)
                    {
                        Console.WriteLine($"Localizado estas especies: {animais[i, especie]}");
                    }
                    break;
                case "2":
                    for (int i = 0; i < animais.GetLength(0); i++)
                    {
                        Console.WriteLine($"Localizado estas idades: {animais[i, idade]}");
                    }
                    break;
                case "3":
                    for (int i = 0; i < animais.GetLength(0); i++)
                    {
                        Console.WriteLine($"Localizado esses pesos: {animais[i, peso]}");
                    }
                    break;
                default:
                    Console.WriteLine("Não localizado nenhum item");
                    break;
            }

            static void MenuDeOpcoes(out string operacao)
            {
                Console.Clear();//Limpar a tela
                Console.WriteLine(@"
                Para pesquisar por nome digite 0 
                Para pesquisar por especie digite 1
                Para pesquisar por idade digite 2
                Para pesquisar por peso digite 3
                Para sair, digite 'sair'");

                operacao = Console.ReadLine().ToLower();
                operacao = operacao == null ? string.Empty : operacao.Trim();
            }
        }
    }
}
