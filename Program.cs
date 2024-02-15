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


    static void CreateDataFile()
    {
        Console.Write("Enter number of weeks: ");
        int weeks = int.Parse(Console.ReadLine());

        // write the data into a file
        using (StreamWriter writer = new StreamWriter("dataGenerate.txt"))
        {
            for (int i = 0; i < weeks; i++)
            {
                // giving back date for each week
                writer.WriteLine($"Week of {DateTime.Today.AddDays(7 * i):MMM, dd, yyyy}");
                // returning or generate random data for each day of the week -multiples of 2
                for (int j = 0; j < 7; j++)
                {
                    writer.Write($"{(j + 1) * 2},");
                }
            
                writer.WriteLine(); 
            }
        }

        Console.WriteLine("Data file created.");
    }
}
