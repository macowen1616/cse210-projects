using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.PerformActivity();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.PerformActivity();
            }
            else if (choice == 3)
            {
                ListeningActivity listening = new ListeningActivity();
                listening.PerformActivity();
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
