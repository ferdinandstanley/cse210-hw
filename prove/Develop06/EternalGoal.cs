class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"{Name} recorded! You gained {Points} points.");
    }

    public override string GetStatus()
    {
        return "[∞] " + Name;
    }
}