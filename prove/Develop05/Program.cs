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
            choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    CreateGoals Create = new CreateGoals();
    Create.PerformActivity();
}
else if (choice == 2)
{
    ListGoals listG = new ListGoals();
    listG.PerformActivity();
}
else if (choice == 3)
{
    SaveGoals save = new SaveGoals();
    save.PerformActivity();
}
else if (choice == 4)
{
    LoadGoals load = new LoadGoals();
    load.PerformActivity();
}
else if (choice == 5)
{
    RecordEvent record = new RecordEvent();
    record.PerformActivity();
}


            else if (choice == 6)
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