using System;

public class RecordEvent
{
    public void PerformActivity()
    {
        for (int i = 0; i < GoalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalManager.Goals[i].GetDetailsString()}");
        }

        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < GoalManager.Goals.Count)
        {
            int points = GoalManager.Goals[index].RecordEvent();
            GoalManager.TotalPoints += points;
            Console.WriteLine($"You earned {points} points!");
        }
    }
}
