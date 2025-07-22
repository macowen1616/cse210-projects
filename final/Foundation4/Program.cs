using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4) 
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Biking");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                continue;
            }

            if (choice == 1)
            {
                RunningAct ract = new RunningAct();
                ract.PerformActivity();
                Console.WriteLine(); // Optional spacing
            }
            else if (choice == 2)
            {
                BikingAct bact = new BikingAct();
                bact.PerformActivity();
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                SwimmingAct sact = new SwimmingAct();
                sact.PerformActivity();
                Console.WriteLine();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 4.");
            }
        }
    }
}
