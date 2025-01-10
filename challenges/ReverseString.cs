namespace tasks.challenges
{
    public static class ReverseString
    {
        public static void Run()
        {
            Console.WriteLine("Informe a string que deseja inverter:");
            string input = Console.ReadLine();
            char[] reversed = new char[input.Length];

            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                reversed[i] = input[j];
            }

            Console.WriteLine($"String invertida: {new string(reversed)}");
        }
    }
}
