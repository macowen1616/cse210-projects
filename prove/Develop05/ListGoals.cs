using System;

public class ListGoals
{
    public void PerformActivity()
    {
        Console.WriteLine($"\nYou have {GoalManager.TotalPoints} points.");
        for (int i = 0; i < GoalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalManager.Goals[i].GetDetailsString()}");
        }
    }
}

