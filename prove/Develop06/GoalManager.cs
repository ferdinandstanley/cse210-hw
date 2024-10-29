class GoalManager
{
    private List<Goal> _goals;
    public int Score { get; private set; }

    public GoalManager()
    {
        _goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, points));
                Console.WriteLine("Simple Goal created.");
                break;
            case "2":
                _goals.Add(new EternalGoal(name, points));
                Console.WriteLine("Eternal Goal created.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                Console.WriteLine("Checklist Goal created.");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            Score += _goals[choice].Points;
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine($"Total Score: {Score}");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter("progress.txt"))
        {
            writer.WriteLine(Score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points}");
            }
        }
        Console.WriteLine("Progress saved.");
    }

    public void LoadProgress()
    {
        if (File.Exists("progress.txt"))
        {
            using (StreamReader reader = new StreamReader("progress.txt"))
            {
                Score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string goalType = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    if (goalType == "SimpleGoal")
                        _goals.Add(new SimpleGoal(name, points));
                    else if (goalType == "EternalGoal")
                        _goals.Add(new EternalGoal(name, points));
                    else if (goalType == "ChecklistGoal")
                    {
                        int targetCount = int.Parse(parts[3]);
                        int bonusPoints = int.Parse(parts[4]);
                        _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                    }
                }
            }
            Console.WriteLine("Progress loaded.");
        }
        else
        {
            Console.WriteLine("No saved progress found.");
        }
    }
}