namespace tasks.challenges
{
    public static class RevenueByState
    {
        public static void Run()
        {
            var states = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double total = states.Values.Sum();

            Console.WriteLine("Percentual de faturamento por estado:");
            foreach (var state in states)
            {
                double percentage = (state.Value / total) * 100;
                Console.WriteLine($"{state.Key}: {percentage:F2}%");
            }
        }
    }
}
