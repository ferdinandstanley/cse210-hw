public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed / 60) * Minutes; // Distance in miles
    public override double GetSpeed() => speed; // Speed is already in mph
    public override double GetPace() => 60 / speed; // Pace in min per mile
}