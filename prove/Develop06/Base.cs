abstract class Goal
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public abstract void RecordEvent();
    public abstract string GetStatus();

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }
}