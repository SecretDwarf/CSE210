class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("02 April 2023", 30, 3);
        Cycling cycling = new Cycling("02 April 2023", 30, 10);
        Swimming swimming = new Swimming("02 April 2023", 30, 60);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}