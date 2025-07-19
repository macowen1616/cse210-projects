using System;
using System.IO;

class LoadGoals
{
    public void PerformActivity()
    {
        Console.Write("Filename to load: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            GoalManager.Goals.Clear();
            using (StreamReader reader = new StreamReader(file))
            {
                GoalManager.Score = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    Goal goal = Goal.Deserialize(reader.ReadLine());
                    GoalManager.Goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}


//Good
