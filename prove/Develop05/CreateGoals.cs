using System;

class CreateGoals
{
    public void PerformActivity()
    {
        Console.WriteLine("Select a goal type:\n1. Simple\n2. Eternal\n3. ListGoals\n4. Negative");
        if (!int.TryParse(Console.ReadLine(), out int type))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points.");
            return;
        }

        Goal goal = null;
        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name, desc, points);
                break;
            case 2:
                goal = new EternalGoal(name, desc, points);
                break;
            case 3:
                Console.Write("How many times to complete this goal? ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target number.");
                    return;
                }
                goal = new ListGoals(name, desc, points, target);
                break;
            case 4:
                goal = new NegativeGoal(name, desc, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        GoalManager.Goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }
}
