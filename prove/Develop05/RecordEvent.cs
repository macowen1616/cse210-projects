using System;

public class RecordEvent
{
    public void PerformActivity()
    {
        Console.WriteLine("Choose a goal to record:");
        for (int i = 0; i < GoalManager.goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalManager.goals[i].Name}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < GoalManager.goals.Count)
        {
            GoalManager.goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
