class BreathingActivity : Activity
{
    protected override string GetActivityName() => "Breathing Activity";

    protected override string GetActivityDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        int interval = 4; // Breathing in/out every 4 seconds
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            Countdown(interval);
            Console.WriteLine("Breathe out...");
            Countdown(interval);
            duration -= interval * 2;
        }
    }
}