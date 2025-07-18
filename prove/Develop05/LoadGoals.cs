using System;
using System.IO;

public class LoadGoals
{
    public void PerformActivity()
    {
        GoalManager.goals.Clear();

        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "NegativeGoal")
            {
                string name = data[0];
                string desc = data[1];
                int points = int.Parse(data[2]);
                bool completed = bool.Parse(data[3]);

                NegativeGoal ng = new NegativeGoal(name, desc, points);
                if (completed) ng.RecordEvent(); // simulate marking it complete

                GoalManager.goals.Add(ng);
            }

            // Add support for other goal types if needed
        }

        Console.WriteLine("Goals loaded from goals.txt!");
    }
}
