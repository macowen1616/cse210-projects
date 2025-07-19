using System;
using System.IO;

class SaveGoals
{
    public void PerformActivity()
    {
        Console.Write("Filename to save: ");
        string file = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(GoalManager.Score);
                foreach (Goal g in GoalManager.Goals)
                    writer.WriteLine(g.Serialize());
            }
            Console.WriteLine("Goals saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }
}

//Good