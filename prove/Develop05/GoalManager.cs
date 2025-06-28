using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public static List<Goal> Goals = new List<Goal>();
    public static int TotalPoints = 0;

    public static void SaveToFile()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(TotalPoints);
            foreach (Goal g in Goals)
                file.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved to goals.txt.");
    }

    public static void LoadFromFile()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        TotalPoints = int.Parse(lines[0]);
        Goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
                Goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            else if (type == "EternalGoal")
                Goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            else if (type == "ChecklistGoal")
                Goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
        }
        Console.WriteLine("Goals loaded from goals.txt.");
    }
}
