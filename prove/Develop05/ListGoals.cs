using System;

class List
{
    public void PerformActivity()
    {
        Console.WriteLine($"\nYour Score: {GoalManager.Score}");
        for (int i = 0; i < GoalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalManager.Goals[i].GetStatus()}");
        }
    }
}
