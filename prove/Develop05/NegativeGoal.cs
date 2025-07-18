public class NegativeGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You triggered a negative goal: '{Name}'. You lost {Points} points!");
        IsCompleted = true;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{Name},{Description},{Points},{IsCompleted}";
    }

    public override string GetStatus()
    {
        return $"[{"X",1}] {Name} ({Description}) - Lose {Points} pts";
    }
}
