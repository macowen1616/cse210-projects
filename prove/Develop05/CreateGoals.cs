using System;

public class CreateGoals
{
    public void PerformActivity()
    {
        Console.WriteLine("Enter goal type:");
        Console.WriteLine("1. Negative Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            GoalManager.goals.Add(new NegativeGoal(name, desc, points));
            Console.WriteLine("Negative goal created!");
        }
        // You can add more goal types here later
    }
}
