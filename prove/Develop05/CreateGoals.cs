using System;

public class CreateGoals
{
    public void PerformActivity()
    {
        Console.WriteLine("Types: 1. Simple 2. Eternal 3. Checklist");
        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        if (type == "1")
            GoalManager.Goals.Add(new SimpleGoal(name, desc, pts));
        else if (type == "2")
            GoalManager.Goals.Add(new EternalGoal(name, desc, pts));
        else if (type == "3")
        {
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            GoalManager.Goals.Add(new ChecklistGoal(name, desc, pts, bonus, 0, target));
        }
    }
}
