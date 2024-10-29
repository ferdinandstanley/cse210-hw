public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Minutes) * 60; // Speed in mph

    public override double GetPace() => Minutes / distance; // Pace in min per mile
}
