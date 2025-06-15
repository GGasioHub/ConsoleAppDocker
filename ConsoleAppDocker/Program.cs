internal class Program
{
    private static async Task Main(string[] args)
    {
        int i = 1;
        while (true)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Updated {i++}");
        }
    }
}