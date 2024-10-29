public abstract class Activity
{
    private DateTime date;
    private int minutes;

    protected Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    protected int Minutes => minutes; // Protected property to access minutes

    public abstract double GetDistance(); // Abstract method for distance
    public abstract double GetSpeed();    // Abstract method for speed
    public abstract double GetPace();     // Abstract method for pace

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2}";
    }
}