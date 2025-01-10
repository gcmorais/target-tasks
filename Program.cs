using tasks.challenges;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Selecione o desafio para executar (1 a 5):");
                int escolha;

                // Valida entrada numérica
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        SumTask.Run();
                        break;
                    case 2:
                        Fibonacci.Run();
                        break;
                    case 3:
                        DailyRevenue.Run();
                        break;
                    case 4:
                        RevenueByState.Run();
                        break;
                    case 5:
                        ReverseString.Run();
                        break;
                    default:
                        Console.WriteLine("Desafio inválido.");
                        break;
                }

                Console.WriteLine("\n------------------------------------------------------------------------");
                Console.WriteLine("\nDeseja realizar outra operação? (Y para continuar / X para sair)");
                var opcao = Console.ReadKey().Key;

                if (opcao == ConsoleKey.X)
                {
                    continuar = false;
                }
            }

            Console.WriteLine("\nPrograma encerrado. Até logo!");
        }
    }
}
