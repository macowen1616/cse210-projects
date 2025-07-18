using System;

public class ListGoals
{
    public void PerformActivity()
    {
        Console.WriteLine("\nCurrent Goals:");
        int index = 1;
        foreach (Goal g in GoalManager.goals)
        {
            Console.WriteLine($"{index}. {g.GetStatus()}");
            index++;
        }
    }
}
