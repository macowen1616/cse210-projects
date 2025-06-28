public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}

public class SimpleGoal : Goal
{
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
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"[{"X",1}] {_shortName} ({_description})";

    public override string GetStringRepresentation() =>
        $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[ ] {_shortName} ({_description})";

    public override string GetStringRepresentation() =>
        $"EternalGoal:{_shortName},{_description},{_points}";
}

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string desc, int points, int bonus, int current, int target)
        : base(name, desc, points)
    {
        _bonusPoints = bonus;
        _currentCount = current;
        _targetCount = target;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() =>
        $"[{"X",1}] {_shortName} ({_description}) -- Completed {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal:{_shortName},{_description},{_points},{_bonusPoints},{_currentCount},{_targetCount}";
}
