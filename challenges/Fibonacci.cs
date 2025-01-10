namespace tasks.challenges
{
    public static class Fibonacci
    {
        public static void Run()
        {
            Console.WriteLine("Informe um número para verificar na sequência de Fibonacci:");
            int number = int.Parse(Console.ReadLine());
            int a = 0, b = 1, temp;

            while (b < number)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            if (b == number || number == 0)
                Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
