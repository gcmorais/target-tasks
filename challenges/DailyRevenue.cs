using System.Text.Json;

namespace tasks.challenges
{
    public static class DailyRevenue
    {
        public static void Run()
        {
            string json = @"[10, 20, 0, 0, 30, 40, 50, 0, 60, 70]";
            var revenues = JsonSerializer.Deserialize<List<int>>(json);
            var validRevenues = revenues.Where(r => r > 0).ToList();
            double average = validRevenues.Average();

            Console.WriteLine($"Menor faturamento diário: {validRevenues.Min()}");
            Console.WriteLine($"Maior faturamento diário: {validRevenues.Max()}");
            Console.WriteLine($"Dias com faturamento acima da média: {validRevenues.Count(r => r > average)}");
        }
    }
}
