class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Create data file");
        Console.WriteLine("2. Parse data file");

        int choice;
        // Reading user input
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
    }
}
