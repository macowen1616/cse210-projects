using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (choice == 1)
            {
                new CreateGoals().PerformActivity();
            }
            else if (choice == 2)
            {
                new List().PerformActivity();
            }
            else if (choice == 3)
            {
                new SaveGoals().PerformActivity();
            }
            else if (choice == 4)
            {
                new LoadGoals().PerformActivity();
            }
            else if (choice == 5)
            {
                new RecordEvent().PerformActivity();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}


//Good 