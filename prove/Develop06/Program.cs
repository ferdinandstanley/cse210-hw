using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest");
            Console.WriteLine($"Current Score: {goalManager.Score}");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.AddGoal();
                    break;
                case "2":
                    goalManager.RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.SaveProgress();
                    break;
                case "5":
                    goalManager.LoadProgress();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    //I added a save/load progress functionality to keep track of goals across sessions.
    //Displayed gamification with an Eternal Goal type that lets users continually gain points.
    //Included bonuses for Checklist Goals when target completion is reached.
}