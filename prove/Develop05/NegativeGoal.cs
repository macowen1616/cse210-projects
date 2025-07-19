class NegativeGoal : Goal
{
    private int _times;

    public NegativeGoal(string name, string desc, int points, int times = 0)
        : base(name, desc, points)
    {
        _times = times;
    }

    public override int RecordEvent()
    {
        _times++;
        return -Points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[!] {Name} -- Occurred {_times} times";

    public override string Serialize() =>
        $"NegativeGoal|{Name}|{Description}|{Points}|{_times}";
}


//gOOD