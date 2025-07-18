using System.IO;

public class SaveGoals
{
    public void PerformActivity()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal g in GoalManager.goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to goals.txt!");
    }
}
