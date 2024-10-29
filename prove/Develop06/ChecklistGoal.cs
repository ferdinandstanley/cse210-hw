class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount < _targetCount)
        {
            Console.WriteLine($"{Name} progress recorded! You gained {Points} points. ({_currentCount}/{_targetCount})");
        }
        else if (_currentCount == _targetCount)
        {
            Console.WriteLine($"{Name} completed! You gained {Points} points and a bonus of {_bonusPoints} points.");
        }
        else
        {
            Console.WriteLine($"{Name} is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[ ] {Name} - Completed {_currentCount}/{_targetCount} times";
    }
}