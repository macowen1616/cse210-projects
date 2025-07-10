using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Biking");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    RunningAct Ract = new RunningAct();
    Ract.PerformActivity();
}
else if (choice == 2)
{
BikingAct Bact = new BikingAct();
    Bact.PerformActivity(); 
}
else if (choice == 3)
{
    SwimmingAct Sact = new SwimmingAct();
    Sact.PerformActivity();
}

            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-4.");
            }
        }
    }
}