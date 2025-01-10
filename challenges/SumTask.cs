namespace tasks.challenges
{
    public static class SumTask
    {
        public static void Run()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("O valor final da variável SOMA é: " + SOMA);
        }
    }
}
