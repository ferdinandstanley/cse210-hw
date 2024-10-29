public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50.0 / 1000) * 0.62; // Distance in miles

    public override double GetSpeed() => (GetDistance() / Minutes) * 60; // Speed in mph

    public override double GetPace() => Minutes / GetDistance(); // Pace in min per mile
}