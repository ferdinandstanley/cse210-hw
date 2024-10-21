// Base class for the shared behavior of all thw class
abstract class Activity
{
    private int duration;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {GetActivityName()}...");
        Console.WriteLine(GetActivityDescription());
        Console.Write("How long, in seconds, would you like for your session: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 

        PerformActivity();

        EndActivity();
    }

    private void EndActivity()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3); 
        Console.WriteLine($"You completed the {GetActivityName()} for {duration} seconds.");
        LogActivity(); 
        ShowSpinner(3);
    }

    // To log the activity details
    private void LogActivity()
    {
        string logMessage = $"{DateTime.Now}: Completed {GetActivityName()} for {duration} seconds.";
        using (StreamWriter sw = new StreamWriter("activity_log.txt", true))
        {
            sw.WriteLine(logMessage);
        }
    }

    protected abstract string GetActivityName();
    protected abstract string GetActivityDescription();
    protected abstract void PerformActivity();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b-");
            Thread.Sleep(1000);
            Console.Write("\b\\");
            Thread.Sleep(1000);
            Console.Write("\b|");
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int GetDuration() => duration;
}