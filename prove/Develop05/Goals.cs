using System;

abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();

    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        switch (type)
        {
            case "SimpleGoal": return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "EternalGoal": return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "ListGoals": return new ListGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            case "NegativeGoal": return new NegativeGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
            default: throw new Exception("Unknown goal type.");
        }
    }
}

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points, bool isComplete = false)
        : base(name, desc, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {Name}";

    public override string Serialize() =>
        $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}

class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => Points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[∞] {Name}";

    public override string Serialize() =>
        $"EternalGoal|{Name}|{Description}|{Points}";
}

class ListGoals : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ListGoals(string name, string desc, int points, int targetCount, int currentCount = 0)
        : base(name, desc, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = 500;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
                return Points + _bonusPoints;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {Name} -- Completed {_currentCount}/{_targetCount} times";

    public override string Serialize() =>
        $"ListGoals|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}";
}


//Good