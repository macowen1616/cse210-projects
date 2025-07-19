using System;

class RecordEvent
{
    public void PerformActivity()
    {
        if (GoalManager.Goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        new List().PerformActivity();
        Console.Write("Which goal did you accomplish (or fail)? ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > GoalManager.Goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        int earned = GoalManager.Goals[index - 1].RecordEvent();
        GoalManager.Score += earned;
        Console.WriteLine($"Points {(earned >= 0 ? "gained" : "lost")}: {earned}. Total Score: {GoalManager.Score}");
    }
}


//Good