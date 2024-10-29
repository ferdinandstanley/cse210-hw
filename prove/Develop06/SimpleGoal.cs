class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{Name} completed! You gained {Points} points.");
        }
        else
        {
            Console.WriteLine($"{Name} is already complete.");
        }
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X] " + Name : "[ ] " + Name;
    }
}